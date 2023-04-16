using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using AForge.Video;
using AForge.Video.DirectShow;
using Accord.Video.FFMPEG;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace TAISAT_Arayuz
{
    public partial class TAISAT : Form
    {
        public TAISAT()
        {
            InitializeComponent();
        }
        //TO-DO 
        //power
        //TO-DO 
        bool isStation = true;//Video Transfer için istasyon kontrolü
        List<string> logs = new List<string>();//CSV kaydı için oluşturulan liste 
        bool maximized = false;//Tek seferlik tam ekran moduna geçmek için gerekli değişken 
        //3D Simulation Değişkenleri
        string _3DSimExePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/3D Sim/New Unity Project.exe";
        [DllImport("user32.dll")] static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", SetLastError = true)] internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        Process simApplication;
        const int WS_BORDER = 8388608;
        const int WS_DLGFRAME = 4194304;
        const int WS_CAPTION = WS_BORDER | WS_DLGFRAME;
        const int WS_SYSMENU = 524288;
        const int WS_THICKFRAME = 262144;
        const int WS_MINIMIZE = 536870912;
        const int WS_MAXIMIZEBOX = 65536;
        const int GWL_STYLE = (int)-16L;
        const int GWL_EXSTYLE = (int)-20L;
        const int WS_EX_DLGMODALFRAME = (int)0x1L;
        const int SWP_NOMOVE = 0x2;
        const int SWP_NOSIZE = 0x1;
        const int SWP_FRAMECHANGED = 0x20;
        int count = 5;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int GetWindowLongA(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int SetWindowLongA(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);
        public void MakeExternalWindowBorderless(IntPtr MainWindowHandle)
        {
            int Style = 0;
            Style = GetWindowLongA(MainWindowHandle, GWL_STYLE);
            Style = Style & ~WS_CAPTION;
            Style = Style & ~WS_SYSMENU;
            Style = Style & ~WS_THICKFRAME;
            Style = Style & ~WS_MINIMIZE;
            Style = Style & ~WS_MAXIMIZEBOX;
            SetWindowLongA(MainWindowHandle, GWL_STYLE, Style);
            Style = GetWindowLongA(MainWindowHandle, GWL_EXSTYLE);
            SetWindowLongA(MainWindowHandle, GWL_EXSTYLE, Style | WS_EX_DLGMODALFRAME);
            SetWindowPos(MainWindowHandle, new IntPtr(0), 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_FRAMECHANGED);
        }
        //3D Simulation Değişkenleri Ve Fonksiyonları
        Process p = new Process();//CMD Processi
        //FTP Değişkenleri
        string ftpUserName = "pi";
        string ftpPassword = "raspberry";
        string ftpFile = @"";
        bool waitVideoTransfer = true;
        string bytes = "";
        //FTP Değişkenleri
        Label[] statusLabels;//0-7 Arası Uydu Statusu Belirten labellar  
        //Video Kaydı Değişkenleri
        int width, height;
        int resolution = 480;
        string videorecordpath = @"";
        FilterInfoCollection fCollection;
        VideoCaptureDevice cam;
        VideoFileWriter videoWriter = new VideoFileWriter();
        System.Drawing.Bitmap videoBitmap;
        TimeSpan currentTime;
        TimeSpan startTime;
        TimeSpan finishTime;
        TimeSpan elapsedTime;
        //Video Kaydı Değişkenleri  
        string raspberryIP = ""; //Video Gönderen IP 
        string[] cache; string log = ""; //Log   
        bool seperation = false; //Seperation
        //Port Okuma Değişkenleri
        SerialPort port;
        string buffer = string.Empty;
        int bufferSize = 175;
        //Port Okuma Değişkenleri 
        int _data = 0, data = 0, resetWait = 5; //İletişim kontrolü için değişkenler
        //Offline Map
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        bool gapi = !true;
        bool gmap = !false;
        string mapCacheFolder = @"C:\Users\Administrator\AppData\Local\GMap.NET";
        //Offline Map
        //My Functions
        public void InitBrowser()//Google
        {
            var settings = new CefSettings();
            settings.RegisterScheme(new CefCustomScheme { SchemeName = "localfolder", SchemeHandlerFactory = new FolderSchemeHandlerFactory(rootFolder: @"", defaultPage: "index.html") });
            Cef.Initialize(settings);
            gapiMap.LoadHtml(File.ReadAllText(@"index.html"));
            gmapMap.Overlays.Add(objects);
        }
        void InitGmap()//Gmap
        {
            GMaps.Instance.Mode = AccessMode.CacheOnly;
            gmapMap.MapProvider = GoogleSatelliteMapProvider.Instance;
            gmapMap.CacheLocation = mapCacheFolder;
            gmapMap.Position = new PointLatLng(38.3965143, 33.7282682);//Aksaray Hisar Atış Alanı Koordinatları
            gmapMap.MinZoom = 13;
            gmapMap.MaxZoom = 20;
            gmapMap.Zoom = 13;
        }
        void ResetData()
        {
            try
            {
                label_errorCode.Text = "11111";
                label_currentDate.Text = "0";
                label_currentTime.Text = "0";
                label_containerPressure.Text = "0";
                label_payloadPressure.Text = "0";
                label_containerAltitude.Text = "0";
                label_payloadAltitude.Text = "0";
                label_AltitudeDiff.Text = "0";
                label_payloadVelocity.Text = "0";
                label_payloadTemperature.Text = "0";
                label_payloadBataryVoltage.Text = "0";
                label_payloadGPSLatitude.Text = "0";
                label_payloadGPSLongitude.Text = "0";
                label_payloadGPSAltitude.Text = "0";
                label_payloadPitch.Text = "0";
                label_payloadRoll.Text = "0";
                label_payloadYaw.Text = "0";
                label_carrierTemperature.Text = "0";
                label_carrierVoltage.Text = "0";
                label_carrierGPSLatitude.Text = "0";
                label_carrierGPSLongitude.Text = "0";
                errorBit1.BackColor = label_errorCode.Text[0] == '0' ? Color.Lime : Color.Red;
                errorBit2.BackColor = label_errorCode.Text[1] == '0' ? Color.Lime : Color.Red;
                errorBit3.BackColor = label_errorCode.Text[2] == '0' ? Color.Lime : Color.Red;
                errorBit4.BackColor = label_errorCode.Text[3] == '0' ? Color.Lime : Color.Red;
                errorBit5.BackColor = label_errorCode.Text[4] == '0' ? Color.Lime : Color.Red;
                resetWait = 5;
            }
            catch (Exception) { MessageBox.Show("ResetData"); }
            try
            {
                if (button_telemetryCOMPortOpenClose.BackColor == Color.Green)
                {
                    port.Close();
                    port.Open();
                }
            }
            catch (Exception) { }
        }
        private void AddTelemetryTable()
        {
            try { dataGridView_telemetryDataTable.Rows.Add(cache); dataGridView_telemetryDataTable.FirstDisplayedScrollingRowIndex = dataGridView_telemetryDataTable.RowCount - 1; }
            catch (Exception) { MessageBox.Show("AddTelemetryTable"); }
        }
        void Deploy()
        {
            try
            {
                var data = new byte[] { 0x22, 0x22, 0x1e, (byte)'G' };
                for (int i = 0; i < 5; i++)
                {
                    port.Write(data, 0, data.Length);
                    Thread.Sleep(50);
                }
            }
            catch (Exception) { MessageBox.Show("Deploy"); }
        }
        public void SerialPortProgram()
        {
            try
            {
                port.Open();
            }
            catch (Exception) { MessageBox.Show("SerialPortProgram"); }
        }
        void KillSimulations()
        {
            try
            {
                foreach (var process in Process.GetProcessesByName(_3DSimExePath.Split('/').Last().Split('.')[0]))
                    process.Kill();
            }
            catch (Exception) { MessageBox.Show("KillSimulations"); }
        }
        void ToggleUI(bool toggle)
        {
            try
            {
                Type[] types = { typeof(TextBox), typeof(Button), typeof(ComboBox) };
                foreach (Type type in types)
                    foreach (var item in GetAll(this, type))
                        item.Enabled = toggle;
            }
            catch (Exception) { MessageBox.Show("ToggleUI"); }
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            try
            {
                var controls = control.Controls.Cast<Control>();
                return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                          .Concat(controls)
                                          .Where(c => c.GetType() == type);
            }
            catch (Exception) { MessageBox.Show("GetAll"); return null; }
        }
        void TakeScreenShotOfChart(Chart chart)
        {
            try
            {
                Size oldSize = chart.Size;
                chart.Size = new Size(1920, 1080);
                chart.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Charts\" + chart.Series[0].ToString() + ".png", ChartImageFormat.Png);
                chart.Size = oldSize;
            }
            catch (Exception) { MessageBox.Show("TakeScreenShotOfChart"); }
        }
        void SaveFlightTxt()
        {
            try
            {
                File.AppendAllText("log.txt", log);
            }
            catch (Exception) { MessageBox.Show("SaveFlightTxt"); }
        }
        void SaveFlightCSV()
        {
            try
            {
                var csv = new StringBuilder();
                csv.AppendLine("<PAKETNUMARASI>;<UYDUSTATÜSÜ>;<HATAKODU>;<GÖNDERMESAATİ>;<BASINÇ1>;<BASINÇ2>;<YÜKSEKLİK1>;<YÜKSEKLİK2>;<İRTİFAFARKI>;<İNİŞHIZI>;<SICAKLIK>;<PİLGERİLİMİ>;<GPS1LATITUDE>;<GPS1LONGITUDE>;<GPS1ALTITUDE>;<PITCH>;<ROLL>;<YAW>;<TAKIMNO>;");
                foreach (var log in logs)
                    csv.AppendLine(log);
                File.WriteAllText("logs.csv", csv.ToString());
            }
            catch (Exception) { MessageBox.Show("SaveFlight"); }
        }
        void ListComPorts()
        {
            try
            {
                comboBox_COMPortTelemetry.Items.Clear();
                foreach (var port in SerialPort.GetPortNames())
                    comboBox_COMPortTelemetry.Items.Add(port);
            }
            catch (Exception) { MessageBox.Show("ListComPorts"); }
        }
        void Upload()
        {
            try
            { 
                string url = "ftp://" + textbox_ftpAddress.Text + "/" + textBox_videoPathToSend.Text.Split('\\').Last();
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                label_fileSendingStatus.Text = "Gönderiliyor";
                using (Stream fileStream = File.OpenRead(textBox_videoPathToSend.Text))
                using (Stream ftpStream = request.GetRequestStream())
                {
                    progressBar_sendVideo.Invoke(
                    (MethodInvoker)delegate
                    {
                        progressBar_sendVideo.Maximum = (int)fileStream.Length;
                    });
                    byte[] buffer = new byte[10240];
                    int read;
                    while ((read = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ftpStream.Write(buffer, 0, read);
                        progressBar_sendVideo.Invoke(
                        (MethodInvoker)delegate
                        {
                            progressBar_sendVideo.Value = (int)fileStream.Position;
                            if (progressBar_sendVideo.Value == progressBar_sendVideo.Maximum)
                                label_fileSendingStatus.Text = "Gönderildi!";
                        });
                    }
                }
                while (progressBar_sendVideo.Value != progressBar_sendVideo.Maximum) { }
                for (int i = 0; i < 10; i++)
                    if (isValidConnection(textbox_ftpAddress.Text, ftpUserName, ftpPassword))
                    { 
                        GetVideoFileName();
                        if(ftpFile== textBox_videoPathToSend.Text.Split('\\').Last()) 
                            label_fileSendingStatus.Text = "Doğrulandı!"; 
                    }
            }
            catch (Exception) { MessageBox.Show("Upload"); }
        } 
        bool isValidConnection(string url, string user, string password)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + url);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(user, password);
                request.GetResponse();
            }
            catch (WebException err) { MessageBox.Show(err.Message); return false; }
            return true;

        }
        void ListenUDP()
        {
            try
            {
                UdpClient udpClient = new UdpClient(41);
                while (waitVideoTransfer)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    if (returnData == "video1")
                    {
                        raspberryIP = RemoteIpEndPoint.Address.ToString();
                        if (!isStation) new Thread(new ThreadStart(DownloadVideo)).Start();
                        waitVideoTransfer = false;
                    }
                    else if (returnData == "ip")
                    {
                        raspberryIP = RemoteIpEndPoint.Address.ToString();
                        textbox_ftpAddress.Text = raspberryIP;
                        label14.BackColor = Color.Lime;
                        if (isStation)
                            waitVideoTransfer = false;
                    }
                }
            }
            catch (Exception) { }
        }
        void SendUDP()
        {
            try { new UdpClient().Send(Encoding.ASCII.GetBytes("x"), Encoding.ASCII.GetBytes("x").Length, raspberryIP, 41); waitVideoTransfer = false; } catch { }
            Thread.Sleep(100);
        }
        void KillUDPPorts()
        {
            string[] ports = new string[2] { "11000", "41" };
            foreach (string port in ports)
            {
                p.StartInfo.Arguments = "/c netstat -ano | findstr :" + port;
                p.Start();
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                try
                {
                    string command = "/c taskkill /pid " + output.Replace(" ", "").Split('*')[2] + " /F";
                    RunCMD(command);
                }
                catch (Exception) { }
                try
                {
                    string command = "/c taskkill /f /im " + output.Replace(" ", "").Split('*')[2];
                    RunCMD(command);
                }
                catch (Exception) { }
            }
        }
        void RunCMD(string cmd)
        {
            p.StartInfo.Arguments = cmd;
            p.Start();
            p.WaitForExit();
        }
        void GetVideoFileName()
        {
            raspberryIP = textbox_ftpAddress.Text;
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + raspberryIP + "/");
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string names = reader.ReadToEnd();
                reader.Close();
                response.Close();
                string[] files = names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var file in files)
                    if (file.Contains(".avi"))
                        ftpFile = file;
            }
            catch (Exception) { MessageBox.Show("GetVideoFileName"); }
        }
        void DownloadVideo()
        {
            try
            {
                new Thread(new ThreadStart(GetVideoFileName)).Start();
                Thread.Sleep(3000);
                if (ftpFile != "")
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + raspberryIP + "/" + ftpFile);
                    request.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    using (Stream ftpStream = request.GetResponse().GetResponseStream())
                    using (Stream fileStream = File.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ftpFile)))
                    {
                        byte[] buffer = new byte[10240];
                        int read;
                        while ((read = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileStream.Write(buffer, 0, read);
                            bytes = fileStream.Position.ToString();
                            downloadStatus_label.Text = bytes + " Downloaded";
                        }
                    }
                    downloadStatus_label.Text = "Download Completed!";
                    new Thread(new ThreadStart(SendUDP)).Start();
                }
            }
            catch (Exception) { MessageBox.Show("DownloadVideo_Click"); }
        }
        //My Functions

        //My Events
        public void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception) { MessageBox.Show("Port_DataReceived"); }
        }
        void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (button_recordStartStop.Text == "Stop Record")
                {
                    videoBitmap = (System.Drawing.Bitmap)eventArgs.Frame.Clone();
                    videoWriter.WriteVideoFrame(videoBitmap);
                    pictureBox_camera.Image = videoBitmap;
                }
                else
                {
                    videoBitmap = (System.Drawing.Bitmap)eventArgs.Frame.Clone();
                    pictureBox_camera.Image = videoBitmap;
                }
            }
            catch (Exception) { MessageBox.Show("Cam_NewFrame"); }
        }
        //My Events
        //Form Events
        void Form1_Load(object sender, EventArgs e)
        {
            if (textbox_ftpAddress.Text == "") textbox_ftpAddress.Text = "192.168.0.100"; 
            if (MessageBox.Show("Bu istasyon video alıcı istasyonu mu?", "TAISAT", MessageBoxButtons.YesNo) == DialogResult.Yes)
                isStation = false;
            else
                isStation = true;
            try { Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Charts"); }
            catch (Exception) { }
            try
            {
                if (isStation)
                {
                    if (gapi) { gmapMap.Enabled = false; gmapMap.Visible = false; gmapMap.Size = new Size(0, 0); gapiMap.Dock = DockStyle.Fill; }
                    else if (gmap) { gapiMap.Enabled = false; gapiMap.Visible = false; gapiMap.Size = new Size(0, 0); gmapMap.Dock = DockStyle.Fill; }
                    InitGmap();
                    groupBox4.Enabled = false;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "cmd";
                    new Thread(new ThreadStart(KillUDPPorts)).Start();
                    Thread.Sleep(1000);
                    new Thread(new ThreadStart(ListenUDP)).Start();
                    if (!dataCheck.Enabled) dataCheck.Start();
                    dataGridView_telemetryDataTable.Columns.Add("PAKET NUMARASI", "PAKET NUMARASI");
                    dataGridView_telemetryDataTable.Columns.Add("UYDU STATÜSÜ", "UYDU STATÜSÜ");
                    dataGridView_telemetryDataTable.Columns.Add("HATA KODU", "HATA KODU");
                    dataGridView_telemetryDataTable.Columns.Add("GÖNDERME SAATİ", "GÖNDERME SAATİ");
                    dataGridView_telemetryDataTable.Columns.Add("BASINÇ1", "BASINÇ1");
                    dataGridView_telemetryDataTable.Columns.Add("BASINÇ2", "BASINÇ2");
                    dataGridView_telemetryDataTable.Columns.Add("YÜKSEKLİK1", "YÜKSEKLİK1");
                    dataGridView_telemetryDataTable.Columns.Add("YÜKSEKLİK2", "YÜKSEKLİK2");
                    dataGridView_telemetryDataTable.Columns.Add("İRTİFA FARKI", "İRTİFA FARKI");
                    dataGridView_telemetryDataTable.Columns.Add("İNİŞ HIZI", "İNİŞ HIZI");
                    dataGridView_telemetryDataTable.Columns.Add("SICAKLIK", "SICAKLIK");
                    dataGridView_telemetryDataTable.Columns.Add("PİL GERİLİMİ", "PİL GERİLİMİ");
                    dataGridView_telemetryDataTable.Columns.Add("GPS1 LATITUDE", "GPS1 LATITUDE");
                    dataGridView_telemetryDataTable.Columns.Add("GPS1 LONGITUDE", "GPS1 LONGITUDE");
                    dataGridView_telemetryDataTable.Columns.Add("GPS1 ALTITUDE", "GPS1 ALTITUDE");
                    dataGridView_telemetryDataTable.Columns.Add("PITCH", "PITCH");
                    dataGridView_telemetryDataTable.Columns.Add("ROLL", "ROLL");
                    dataGridView_telemetryDataTable.Columns.Add("YAW", "YAW");
                    dataGridView_telemetryDataTable.Columns.Add("TAKIM NO", "TAKIM NO");
                    KillSimulations();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = _3DSimExePath;
                    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    simApplication = Process.Start(startInfo);
                    simApplication.WaitForInputIdle();
                    MoveWindow(simApplication.MainWindowHandle, 0, 0, _3DSimPanel.Width, _3DSimPanel.Height, true);
                    windowFixer.Start();
                    if (resolution == 480) { width = 640; height = 480; }
                    if (resolution == 720) { width = 1280; height = 720; }
                    if (resolution == 1080) { width = 1920; height = 1080; }
                    statusLabels = new Label[8] { label_status00, label_status01, label_status02, label_status03, label_status04, label_status05, label_status06, label_status07 };
                    fCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    foreach (FilterInfo item in fCollection)
                    {
                        comboBox_chooseCamera.Items.Add(item.Name);
                        cam = new VideoCaptureDevice();
                    }
                    ListComPorts();
                    comboBox_baudRateTelemetry.SelectedIndex = (comboBox_baudRateTelemetry.Items.Count - 1);
                    gapiMap.LoadHtml(File.ReadAllText(@"index.html"));
                }
                else
                {
                    ToggleUI(false);
                    label14.Enabled = true;
                    textbox_ftpAddress.Enabled = true;
                    new Thread(new ThreadStart(ListenUDP)).Start();
                }
            }
            catch (Exception ex) { MessageBox.Show("Form1_Load"+ex.Message); }
        }
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                KillSimulations();
                KillUDPPorts();
                if (cam.IsRunning)
                { cam.Stop(); videoWriter.Close(); }
            }
            catch (Exception) { MessageBox.Show("Form1_FormClosing"); }
        }
        void comboBox_COMPortTelemetry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                port = new SerialPort(comboBox_COMPortTelemetry.SelectedItem.ToString(), Int32.Parse(comboBox_baudRateTelemetry.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
                port.DataReceived += Port_DataReceived;
            }
            catch (Exception) { MessageBox.Show("comboBox_COMPortTelemetry_SelectedIndexChanged"); }
        }
        void button_refreshCOMPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (button_telemetryCOMPortOpenClose.BackColor == Color.Lime) ListComPorts();
                else
                {
                    port.Close();
                    port.Open();
                }
            }
            catch (Exception) { MessageBox.Show("button_refreshCOMPort_Click"); }
        }
        void button_cameraOpenClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (button_cameraOpenClose.Text == "Open Camera")
                {
                    cam = new VideoCaptureDevice(fCollection[comboBox_chooseCamera.SelectedIndex].MonikerString);
                    cam.NewFrame += Cam_NewFrame;
                    cam.Start();
                    button_cameraOpenClose.Text = "Close Camera";
                    button_cameraOpenClose.BackColor = Color.Red;
                }
                else if (button_cameraOpenClose.Text == "Close Camera")
                {
                    if (cam.IsRunning == true)
                    {
                        cam.Stop();
                        videoWriter.Close();
                        finishTime = DateTime.Now.TimeOfDay;
                        timer_videoRecordTime.Stop();
                        button_recordStartStop.Text = "Start Record";
                        recordInformationLed.BackColor = Color.Transparent;
                        pictureBox_camera.Image = null;
                    }
                    label_videoRecordTime.Text = "00:00:00";
                    button_cameraOpenClose.Text = "Open Camera";
                    button_cameraOpenClose.BackColor = Color.Lime;
                }
            }
            catch (Exception) { MessageBox.Show("button_cameraOpenClose_Click"); }
        }
        void button_recordStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (button_recordStartStop.Text == "Start Record" && cam.IsRunning && videorecordpath != null)
                {
                    string filePath = "" + videorecordpath + "\\" + "videoTaisat_" + DateTime.Now.ToString().Replace(':', '.').Replace(' ', '_') + ".avi";
                    videoWriter.Open(@filePath, width, height, 30, Accord.Video.FFMPEG.VideoCodec.MPEG4, 5000000);
                    startTime = DateTime.Now.TimeOfDay;
                    timer_videoRecordTime.Start();
                    button_recordStartStop.Text = "Stop Record";
                }
                else if (button_recordStartStop.Text == "Stop Record")
                {
                    videoWriter.Close();
                    finishTime = DateTime.Now.TimeOfDay;
                    timer_videoRecordTime.Stop();
                    button_recordStartStop.Text = "Start Record";
                    recordInformationLed.BackColor = Color.Transparent;
                }
                else
                    MessageBox.Show("You have to open the camera and select a folder to start record!");
            }
            catch (Exception) { MessageBox.Show("button_recordStartStop_Click"); }
        }
        void timer_videoRecordTime_Tick(object sender, EventArgs e)
        {
            try
            {
                currentTime = DateTime.Now.TimeOfDay;
                elapsedTime = currentTime.Subtract(startTime);
                label_videoRecordTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
                if (recordInformationLed.BackColor == Color.Transparent)
                    recordInformationLed.BackColor = Color.Red;
                else if (recordInformationLed.BackColor == Color.Red)
                    recordInformationLed.BackColor = Color.Transparent;
            }
            catch (Exception) { MessageBox.Show("timer_videoRecordTime_Tick"); }
        }
        void button_browseVideoFolderToSave_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog browser = new FolderBrowserDialog();
                if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    videorecordpath = browser.SelectedPath;
                    string[] str = videorecordpath.Split('\\');
                    textBox_videoFolderToSave.Text = "..\\" + str[str.Length - 1];
                }
            }
            catch (Exception) { MessageBox.Show("button_browseVideoFolderToSave_Click"); }
        }
        void windowFixer_TimerTick(object sender, EventArgs e)
        {
            try
            {
                MoveWindow(simApplication.MainWindowHandle, 0, 0, _3DSimPanel.Width, _3DSimPanel.Height, true);
                SetParent(simApplication.MainWindowHandle, _3DSimPanel.Handle);
                MakeExternalWindowBorderless(simApplication.MainWindowHandle);
                count--;
                if (count == 0)
                { windowFixer.Stop(); ToggleUI(true); }
                else
                    ToggleUI(false);
            }
            catch (Exception) { MessageBox.Show("windowFixer_TimerTick"); }
        }
        void payloadPressure_Chart_Click(object sender, EventArgs e)
        {
            try { TakeScreenShotOfChart(payloadPressure_Chart); }
            catch (Exception) { MessageBox.Show("payloadPressure_Chart_Click"); }
        }
        void carrierPressure_Chart_Click(object sender, EventArgs e)
        {
            try { TakeScreenShotOfChart(carrierPressure_Chart); }
            catch (Exception) { MessageBox.Show("carrierPressure_Chart_Click"); }
        }
        void batterVoltage_Chart_Click(object sender, EventArgs e)
        {
            try { TakeScreenShotOfChart(batterVoltage_Chart); }
            catch (Exception) { MessageBox.Show("batterVoltage_Chart_Click"); }
        }
        void payloadAltitude_Chart_Click(object sender, EventArgs e)
        {
            try { TakeScreenShotOfChart(payloadAltitude_Chart); }
            catch (Exception) { MessageBox.Show("payloadAltitude_Chart_Click"); }
        }
        void carrierAltitude_Chart_Click(object sender, EventArgs e)
        {
            try { TakeScreenShotOfChart(carrierAltitude_Chart); }
            catch (Exception) { MessageBox.Show("carrierAltitude_Chart_Click"); }
        }
        void velocity_Chart_Click(object sender, EventArgs e)
        {
            try { TakeScreenShotOfChart(velocity_Chart); }
            catch (Exception) { MessageBox.Show("velocity_Chart_Click"); }
        }
        void payloadGPSAltitude_Chart_Click(object sender, EventArgs e)
        {
            try { TakeScreenShotOfChart(payloadGPSAltitude_Chart); }
            catch (Exception) { MessageBox.Show("payloadGPSAltitude_Chart_Click"); }
        }
        void differenceAltitude_Chart_Click(object sender, EventArgs e)
        {
            try { TakeScreenShotOfChart(differenceAltitude_Chart); }
            catch (Exception) { MessageBox.Show("differenceAltitude_Chart_Click"); }
        }
        void temperature_Chart_Click(object sender, EventArgs e)
        {
            try { TakeScreenShotOfChart(temperature_Chart); }
            catch (Exception) { MessageBox.Show("temperature_Chart_Click"); }
        }
        void button_MANUAL_DEPLOY_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(new ThreadStart(Deploy)).Start();
                new Thread(new ThreadStart(Deploy)).Start();
                new Thread(new ThreadStart(Deploy)).Start();
                new Thread(new ThreadStart(Deploy)).Start();
                new Thread(new ThreadStart(Deploy)).Start();
            }
            catch (Exception) { MessageBox.Show("button_MANUAL_DEPLOY_Click"); }
        }
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                buffer += port.ReadExisting();//Buffer okuma(parça parça gelirse ekle) 
                if (buffer[buffer.Length - 1] == '\n' && buffer.Split(',').Length == 24)//Bufferın tamamı okunduysa veriyi işle
                {
                    serialMonitorListBox.Items.Add(buffer);//Buffer loglama
                    serialMonitorListBox.TopIndex = serialMonitorListBox.Items.Count - 1;//En sonuncu logu göstermek için listeyi otomatik aşağıya kaydırma
                    string rawTelemetry = buffer;
                    string[] telemetryData = buffer.Split(',');
                    string telemetry = "";
                    telemetry += telemetryData[0] + ";";
                    telemetry += telemetryData[1] + ";";
                    telemetry += telemetryData[2] + ";";
                    telemetry += telemetryData[3] + "," + telemetryData[4] + ";";
                    telemetry += telemetryData[5] + ";";
                    telemetry += telemetryData[6] + ";";
                    telemetry += telemetryData[7] + ";";
                    telemetry += telemetryData[8] + ";";
                    telemetry += telemetryData[9] + ";";
                    telemetry += telemetryData[10] + ";";
                    telemetry += telemetryData[11] + ";";
                    telemetry += telemetryData[13] + ";";
                    telemetry += telemetryData[12] + ";";
                    telemetry += telemetryData[14] + ";";
                    telemetry += telemetryData[15] + ";";
                    telemetry += telemetryData[16] + ";";
                    telemetry += telemetryData[17] + ";";
                    telemetry += telemetryData[18] + ";";
                    telemetry += telemetryData[19] + ";";
                    logs.Add(telemetry);
                    telemetry = string.Empty;
                    /* Array.Clear(telemetryData, 0, telemetryData.Length);*/
                    buffer = buffer.Replace("<", "").Replace(">", "");
                    telemetryData = buffer.Split(',');
                    //Data Gelmesini bekle
                    if (telemetryData.Length > 19)//Telemetry To Labels
                    {
                        try
                        {
                            label_packageNo.Text = telemetryData[0];
                            label_uyduStatus.Text = telemetryData[1];
                            label_errorCode.Text = telemetryData[2];
                            label_currentDate.Text = telemetryData[3].Replace("/", ".");
                            label_currentTime.Text = telemetryData[4].Replace("/", ":");
                            label_containerPressure.Text = telemetryData[6];
                            label_payloadPressure.Text = telemetryData[5];
                            label_containerAltitude.Text = telemetryData[8];
                            label_payloadAltitude.Text = telemetryData[7];
                            label_AltitudeDiff.Text = telemetryData[9];
                            label_payloadVelocity.Text = telemetryData[10];
                            label_payloadTemperature.Text = telemetryData[11];
                            label_payloadBataryVoltage.Text = telemetryData[12];
                            label_payloadGPSLatitude.Text = telemetryData[13];
                            label_payloadGPSLongitude.Text = telemetryData[14];
                            label_payloadGPSAltitude.Text = telemetryData[15];
                            label_payloadPitch.Text = telemetryData[16];
                            label_payloadRoll.Text = telemetryData[17];
                            label_payloadYaw.Text = telemetryData[18];
                            label_teamID.Text = telemetryData[19];
                            label_carrierTemperature.Text = telemetryData[20];
                            label_carrierVoltage.Text = telemetryData[21];
                            label_carrierGPSLatitude.Text = telemetryData[22];
                            label_carrierGPSLongitude.Text = telemetryData[23];
                            //Telemetry To Labels  
                            string[] telemetryTableDatas = {
                        telemetryData[0],
                        telemetryData[1],
                        telemetryData[2],
                        (telemetryData[3]+telemetryData[4]),
                        telemetryData[5],
                        telemetryData[6],
                        telemetryData[7],
                        telemetryData[8],
                        telemetryData[9],
                        telemetryData[10],
                        telemetryData[11],
                        telemetryData[12],
                        telemetryData[13],
                        telemetryData[14],
                        telemetryData[15],
                        telemetryData[16],
                        telemetryData[17],
                        telemetryData[18],
                        telemetryData[19]
                    };
                            cache = telemetryTableDatas;
                            new Thread(new ThreadStart(AddTelemetryTable)).Start();
                            //Saving Data
                            log =
                                "---------------------------------------------------" + Environment.NewLine +
                                label_packageNo.Text + " numaralı " + label_currentTime.Text + "--" + DateTime.Now.ToString("HH:mm:ss") + " saatinde gelen veriler" + Environment.NewLine +
                                "Paket Numarasi:" + label_packageNo.Text + Environment.NewLine +
                                "Uydu Statusu:" + label_uyduStatus.Text + Environment.NewLine +
                                "Hata Kodu:" + label_errorCode.Text + Environment.NewLine +
                                "Gonderme Saati:" + label_currentDate.Text + " - " + label_currentTime.Text + Environment.NewLine +
                                "Basinc1:" + label_containerPressure.Text + Environment.NewLine +
                                "Basinc2:" + label_payloadPressure.Text + Environment.NewLine +
                                "Yukseklik1:" + label_containerAltitude.Text + Environment.NewLine +
                                "Yukseklik2:" + label_payloadAltitude.Text + Environment.NewLine +
                                "İrtifa Farki:" + label_AltitudeDiff.Text + Environment.NewLine +
                                "İnis Hizi:" + label_payloadVelocity.Text + Environment.NewLine +
                                "Sicaklik:" + label_payloadTemperature.Text + Environment.NewLine +
                                "Pil Gerilimi:" + label_payloadBataryVoltage.Text + Environment.NewLine +
                                "Gps Latitude:" + label_payloadGPSLatitude.Text + Environment.NewLine +
                                "Gps Longitude:" + label_payloadGPSLongitude.Text + Environment.NewLine +
                                "Gps Altitude:" + label_payloadGPSAltitude.Text + Environment.NewLine +
                                "Pitch:" + label_payloadPitch.Text + Environment.NewLine +
                                "Roll:" + label_payloadRoll.Text + Environment.NewLine +
                                "Yaw:" + label_payloadYaw.Text + Environment.NewLine +
                                "Takim No:" + label_teamID.Text + Environment.NewLine +
                                "Sıcaklık Carrier:" + label_carrierTemperature.Text + Environment.NewLine +
                                "Pil Gerilimi Carrier:" + label_carrierVoltage.Text + Environment.NewLine +
                                "Gps Latitude Carrier:" + label_carrierGPSLatitude.Text + Environment.NewLine +
                                "Gps Longitude Carrier:" + label_carrierGPSLongitude.Text + Environment.NewLine +
                                "Raw Data:"+ rawTelemetry+Environment.NewLine+
                                "---------------------------------------------------" + Environment.NewLine;
                            new Thread(new ThreadStart(SaveFlightTxt)).Start();
                            //Saving Data
                            //Sending Gyro To Model Simulation 
                            string gyroData = label_payloadPitch.Text + "," + label_payloadYaw.Text + "," + label_payloadRoll.Text;
                            try { new UdpClient().Send(Encoding.ASCII.GetBytes(gyroData), Encoding.ASCII.GetBytes(gyroData).Length, "127.0.0.1", 11000); } catch { }
                            //Sending Gyro To Model Simulation 
                            //Uydu Status
                            switch (Int16.Parse(label_uyduStatus.Text))
                            {
                                case 0: statusLabels[0].BackColor = Color.Lime; break;
                                case 1: statusLabels[1].BackColor = Color.Lime; break;
                                case 2: statusLabels[2].BackColor = Color.Lime; break;
                                case 3:
                                    statusLabels[3].BackColor = Color.Lime;
                                    try
                                    {
                                        if (!seperation)
                                        {
                                            seperation = true;
                                            new UdpClient().Send(Encoding.ASCII.GetBytes("separation"), Encoding.ASCII.GetBytes("separation").Length, "127.0.0.1", 11000);
                                        }
                                    }
                                    catch { }
                                    break;
                                case 4: statusLabels[4].BackColor = Color.Lime; break;
                                case 5: statusLabels[5].BackColor = Color.Lime; break;
                                case 6: statusLabels[6].BackColor = Color.Lime; break;
                                case 7: statusLabels[7].BackColor = Color.Lime; break;
                            }
                            //Uydu Status
                            //Charts
                            payloadGPSAltitude_Chart.Series["P_GPSAltitude"].IsValueShownAsLabel = true;
                            temperature_Chart.Series["Temperature"].IsValueShownAsLabel = true;
                            batterVoltage_Chart.Series["B_Voltage"].IsValueShownAsLabel = true;
                            velocity_Chart.Series["Velocity"].IsValueShownAsLabel = true;
                            differenceAltitude_Chart.Series["D_Altitude"].IsValueShownAsLabel = true;
                            payloadAltitude_Chart.Series["P_Altitude"].IsValueShownAsLabel = true;
                            carrierAltitude_Chart.Series["C_Altitude"].IsValueShownAsLabel = true;
                            payloadPressure_Chart.Series["P_Pressure"].IsValueShownAsLabel = true;
                            carrierPressure_Chart.Series["C_Pressure"].IsValueShownAsLabel = true;
                            payloadGPSAltitude_Chart.Series["P_GPSAltitude"].Points.AddXY(label_currentTime.Text, label_payloadGPSAltitude.Text);
                            temperature_Chart.Series["Temperature"].Points.AddXY(label_currentTime.Text, label_payloadTemperature.Text);
                            batterVoltage_Chart.Series["B_Voltage"].Points.AddXY(label_currentTime.Text, label_payloadBataryVoltage.Text);
                            velocity_Chart.Series["Velocity"].Points.AddXY(label_currentTime.Text, label_payloadVelocity.Text);
                            differenceAltitude_Chart.Series["D_Altitude"].Points.AddXY(label_currentTime.Text, label_AltitudeDiff.Text);
                            payloadAltitude_Chart.Series["P_Altitude"].Points.AddXY(label_currentTime.Text, label_payloadAltitude.Text);
                            carrierAltitude_Chart.Series["C_Altitude"].Points.AddXY(label_currentTime.Text, label_containerAltitude.Text);
                            payloadPressure_Chart.Series["P_Pressure"].Points.AddXY(label_currentTime.Text, label_payloadPressure.Text);
                            carrierPressure_Chart.Series["C_Pressure"].Points.AddXY(label_currentTime.Text, label_containerPressure.Text);
                            //Charts
                            //Error Code 
                            errorBit1.BackColor = label_errorCode.Text[0] == '0' ? Color.Lime : Color.Red;
                            errorBit2.BackColor = label_errorCode.Text[1] == '0' ? Color.Lime : Color.Red;
                            errorBit3.BackColor = label_errorCode.Text[2] == '0' ? Color.Lime : Color.Red;
                            errorBit4.BackColor = label_errorCode.Text[3] == '0' ? Color.Lime : Color.Red;
                            errorBit5.BackColor = label_errorCode.Text[4] == '0' ? Color.Lime : Color.Red;
                            //Error Code
                            //GPS To Map 
                            gapiMap.EvaluateScriptAsync("delLastMark();");
                            gapiMap.EvaluateScriptAsync("setmark(" + label_payloadGPSLatitude.Text + "," + label_payloadGPSLongitude.Text + "," + label_carrierGPSLatitude.Text + "," + label_carrierGPSLongitude.Text + ");");
                            //GPS To Map
                        }
                        catch (Exception) { MessageBox.Show("Telemetry"); }
                    }
                    buffer = string.Empty;//Buffer Temizleme (tam veri gelip işlendiyse)
                }
                else
                {
                    if (buffer.Contains("\n")) textBox_logs.Text += buffer + Environment.NewLine;
                    if (buffer.Length > bufferSize) buffer = string.Empty;
                }
            }
            catch (Exception)
            { MessageBox.Show("backgroundWorker1_DoWork"); }
        }
        void button_browseVideoFileToSend_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar_sendVideo.Value = 0;
                int size = -1;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    string file = openFileDialog1.FileName;
                    textBox_videoPathToSend.Text = file;
                    try
                    {
                        string text = File.ReadAllText(file);
                        size = text.Length;
                    }
                    catch (IOException err) { MessageBox.Show(err.Message); }
                }
            }
            catch (Exception)
            { MessageBox.Show("button_browseVideoFileToSend_Click"); }
        }
        void button_sendVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbox_ftpAddress.Text != "" && textBox_videoPathToSend.Text != "")
                    Task.Run(() => Upload());
                else MessageBox.Show("FTP adresini veya gönderilecek olan dosyayı boş bırakmayınız!");
            }
            catch (Exception) { MessageBox.Show("button_sendVideo_Click"); }
        }
        private void TAISAT_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (!maximized)
                {
                    WindowState = FormWindowState.Maximized;
                    MinimumSize = this.Size;
                    MaximumSize = this.Size;
                    maximized = true;
                }
            }
            catch (Exception) { MessageBox.Show("TAISAT_MouseEnter"); }
        }
        private void mapSwitchButton_Click(object sender, EventArgs e)
        {
            if (mapSwitchButton.Text == "Disconnect")
            {
                gapi = false;
                gmap = true;
                mapSwitchButton.Text = "Connect";
                mapSwitchButton.BackColor = Color.BlueViolet;
            }
            else if (mapSwitchButton.Text == "Connect")
            {
                gapi = true;
                gmap = false;
                mapSwitchButton.Text = "Disconnect";
                mapSwitchButton.BackColor = Color.Lime;
            }
            if (gapi)
            {
                gmapMap.Enabled = false;
                gmapMap.Visible = false;
                gmapMap.Dock = DockStyle.None;
                gmapMap.Size = new Size(0, 0);
                gapiMap.Enabled = true;
                gapiMap.Visible = true;
                gapiMap.Dock = DockStyle.Fill;
            }
            else if (gmap)
            {
                gapiMap.Enabled = false;
                gapiMap.Visible = false;
                gapiMap.Dock = DockStyle.None;
                gapiMap.Size = new Size(0, 0);
                gmapMap.Enabled = true;
                gmapMap.Visible = true;
                gmapMap.Dock = DockStyle.Fill;
            }
        }
        void textbox_ftpAddress_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    MessageBox.Show(isValidConnection(textbox_ftpAddress.Text, ftpUserName, ftpPassword) ? "FTP Connection Established" : "FTP Connection Error!");
            }
            catch (Exception) { MessageBox.Show("textbox_ftpAddress_KeyDown"); }
        }
        private void dataCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                data = serialMonitorListBox.Items.Count;
                if (data == _data) { resetWait--; if (resetWait == 0) { ResetData(); } }
                else { _data = data; resetWait = 5; }
            }
            catch (Exception) { MessageBox.Show("dataCheck_Tick"); }
        }
        void button_telemetryCOMPortOpenClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (button_telemetryCOMPortOpenClose.BackColor != Color.Green)
                {
                    SerialPortProgram();
                    button_telemetryCOMPortOpenClose.BackColor = Color.Green;
                }
                else
                {
                    SaveFlightCSV();
                    serialMonitorListBox.Items.Clear();
                    port.Close();
                    button_telemetryCOMPortOpenClose.BackColor = Color.Lime;
                    MessageBox.Show("Uçuş Tamamlandı!", "TAISAT MARM-99 Uçuş Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("button_telemetryCOMPortOpenClose_Click"); }
        }
        //Form Events
    }
}
