using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using TAISAT_Arayuz.Properties;
using AForge.Video;
using AForge.Video.DirectShow;
using Accord.Video.FFMPEG;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Diagnostics;
using static System.Windows.Forms.AxHost;
using CefSharp.DevTools.Browser;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.Runtime.InteropServices.ComTypes;

namespace TAISAT_Arayuz
{
    public partial class TAISAT : Form
    {
        public TAISAT()
        {
            InitializeComponent();
        }
        //3D Simulation Değişkenleri
        [DllImport("user32.dll")] static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", SetLastError = true)] internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        string _3DSimExePath = @"C:/Users/Administrator/Desktop/3D Sim/New Unity Project.exe";
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
        const uint MF_BYPOSITION = 0x400;
        const uint MF_REMOVE = 0x1000;
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
        //3D Simulation Değişkenleri
        //FTP Değişkenleri
        string ftpUserName = "pi";
        string ftpPassword = "raspberry";
        //FTP Değişkenleri
        Label[] statusLabels;//0-7 Arası Uydu Statusu Belirten labellar 

        //Video Kaydı Değişkenleri
        int width, height;
        int resolution = 720;
        string videorecordpath = @"";
        FilterInfoCollection fCollection;
        VideoCaptureDevice cam;
        VideoFileWriter videoWriter = new VideoFileWriter();
        Bitmap videoBitmap;
        TimeSpan currentTime;
        TimeSpan startTime;
        TimeSpan finishTime;
        TimeSpan elapsedTime;
        //Video Kaydı Değişkenleri

        //Port Okuma Değişkenleri
        SerialPort port;
        string buffer = string.Empty;
        //Port Okuma Değişkenleri

        //My Functions
        public void InitBrowser()
        {
            var settings = new CefSettings();
            settings.RegisterScheme(new CefCustomScheme { SchemeName = "localfolder", SchemeHandlerFactory = new FolderSchemeHandlerFactory(rootFolder: @"", defaultPage: "index.html") });
            Cef.Initialize(settings);
            chromiumWebBrowser1.LoadHtml(File.ReadAllText(@"index.html"));
        }
        public void SerialPortProgram()
        {
            port.DataReceived += Port_DataReceived;
            port.Open();
            Console.ReadLine();
        }
        void KillSimulations()
        {
            foreach (var process in Process.GetProcessesByName(_3DSimExePath.Split('/').Last().Split('.')[0]))
            {
                process.Kill();
            }
        }
        private void ToggleUI(bool toggle)
        {
            Type[] types = { typeof(TextBox), typeof(Button), typeof(ComboBox) };
            foreach (Type type in types)
                foreach (var item in GetAll(this, type))
                    item.Enabled = toggle;
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        void takeScreenShotOfChart(Chart chart)
        {
            Size oldSize = chart.Size;
            chart.Size = new Size(1920, 1080);
            chart.SaveImage(chart.Series[0].ToString() + ".png", ChartImageFormat.Png);
            chart.Size = oldSize;
        }
        private void SaveFlight(string log)
        {
            //Save everything
        }
        void ListComPorts()
        {
            comboBox_COMPortTelemetry.Items.Clear();
            foreach (var port in SerialPort.GetPortNames())
                comboBox_COMPortTelemetry.Items.Add(port);
        }
        private void Upload()
        { 
            string url = "ftp://" + textbox_ftpAddress.Text + "/allfiles/" + textBox_videoPathToSend.Text.Split('\\').Last();
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
                        if (progressBar_sendVideo.Value == progressBar_sendVideo.Maximum) label_fileSendingStatus.Text = "Gönderildi!";
                    });
                }
            } 
        }
        private bool isValidConnection(string url, string user, string password)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://"+url);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(user, password);
                request.GetResponse();
            }
            catch (WebException err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
            return true;
        }
        //My Functions

        //My Events
        public void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (button_recordStartStop.Text == "Stop Record")
                {
                    videoBitmap = (Bitmap)eventArgs.Frame.Clone();
                    videoWriter.WriteVideoFrame(videoBitmap);
                    pictureBox_camera.Image = videoBitmap;
                }
                else
                {
                    videoBitmap = (Bitmap)eventArgs.Frame.Clone();
                    pictureBox_camera.Image = videoBitmap;
                }
            }
            catch (Exception error) { textBox_logs.AppendText(error.Message + Environment.NewLine); }
        }
        //My Events

        //Form Events
        private void Form1_Load(object sender, EventArgs e)
        {
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
            chromiumWebBrowser1.LoadHtml(File.ReadAllText(@"index.html"));
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (cam.IsRunning == true)
                {
                    cam.Stop();
                    videoWriter.Close();
                    KillSimulations();
                }
            }
            catch { }

        }
        private void comboBox_COMPortTelemetry_SelectedIndexChanged(object sender, EventArgs e)
        {
            port = new SerialPort(comboBox_COMPortTelemetry.SelectedItem.ToString(), Int32.Parse(comboBox_baudRateTelemetry.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
        }
        private void button_refreshCOMPort_Click(object sender, EventArgs e)
        {
            ListComPorts();
        }
        private void button_cameraOpenClose_Click(object sender, EventArgs e)
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
        private void button_recordStartStop_Click(object sender, EventArgs e)
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
                {
                    MessageBox.Show("You have to open the camera and select a folder to start record!");
                }
            }
            catch (Exception error) { textBox_logs.AppendText(error.Message + Environment.NewLine); }
        }
        private void timer_videoRecordTime_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.TimeOfDay;
            elapsedTime = currentTime.Subtract(startTime);
            label_videoRecordTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
            if (recordInformationLed.BackColor == Color.Transparent)
            {
                recordInformationLed.BackColor = Color.Red;
            }
            else if (recordInformationLed.BackColor == Color.Red)
            {
                recordInformationLed.BackColor = Color.Transparent;
            }
        }
        private void button_browseVideoFolderToSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                videorecordpath = browser.SelectedPath;
                string[] str = videorecordpath.Split('\\');
                textBox_videoFolderToSave.Text = "..\\" + str[str.Length - 1];
            }
        }
        private void windowFixer_TimerTick(object sender, EventArgs e)
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
        private void payloadPressure_Chart_Click(object sender, EventArgs e)
        {
            takeScreenShotOfChart(payloadPressure_Chart);
        }
        private void carrierPressure_Chart_Click(object sender, EventArgs e)
        {
            takeScreenShotOfChart(carrierPressure_Chart);
        }

        private void batterVoltage_Chart_Click(object sender, EventArgs e)
        {
            takeScreenShotOfChart(batterVoltage_Chart);
        }
        private void payloadAltitude_Chart_Click(object sender, EventArgs e)
        {
            takeScreenShotOfChart(payloadAltitude_Chart);
        }
        private void carrierAltitude_Chart_Click(object sender, EventArgs e)
        {
            takeScreenShotOfChart(carrierAltitude_Chart);
        }
        private void velocity_Chart_Click(object sender, EventArgs e)
        {
            takeScreenShotOfChart(velocity_Chart);
        }
        private void payloadGPSAltitude_Chart_Click(object sender, EventArgs e)
        {
            takeScreenShotOfChart(payloadGPSAltitude_Chart);
        }
        private void differenceAltitude_Chart_Click(object sender, EventArgs e)
        {
            takeScreenShotOfChart(differenceAltitude_Chart);
        }
        private void temperature_Chart_Click(object sender, EventArgs e)
        {
            takeScreenShotOfChart(temperature_Chart);
        }
        private void button_MANUAL_DEPLOY_Click(object sender, EventArgs e)
        {
            payloadPressure_Chart.Size = new Size(1920, 1080);
            MessageBox.Show(payloadPressure_Chart.Size.Width.ToString());
            /*MANUAL DEPLOY KOMUTU
            int currentStatus = Int16.Parse(label_uyduStatus.Text);
            //MANUAL DEPLOY KOMUTU (CURRENT STATUSUN 1 SONRASINI AKTİFLEŞTİRCEK)
            currentStatus++;
            label_uyduStatus.Text=currentStatus.ToString();
            //MANUAL DEPLOY KOMUTU */
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            buffer += port.ReadExisting();//Buffer okuma(parça parça gelirse ekle)
            if (buffer.Contains("\n"))//Bufferın tamamı okunduysa veriyi işle
            {

                serialMonitorListBox.Items.Add(buffer);//Buffer loglama
                serialMonitorListBox.TopIndex = serialMonitorListBox.Items.Count - 1;//En sonuncu logu göstermek için listeyi otomatik aşağıya kaydırma
                buffer = buffer.Replace("<", "").Replace(">", "");
                string[] telemetryData = buffer.Split(',');
                // 0 <paket numarasi>,
                // 1 <uydu statusu>,
                // 2 <hata kodu>,
                // 3 <gonderme saati>,(2 parça geliyor  GÜN/AY/YIL,SAAT/DAKİKA/SANİYE) TARİH
                // 4 <gonderme saati>,(2 parça geliyor  GÜN/AY/YIL,SAAT/DAKİKA/SANİYE) SAAT
                // 5 <basinc1>,
                // 6 <basinc2>,//Carrier
                // 7 <yukseklik1>,
                // 8 <yukseklik2>,//Carrier
                // 9 <irtifa farki>,
                // 10 <inis hizi>,
                // 11 <sicaklik>,
                // 12 <pil gerilimi>,
                // 13 <gps latitude>,
                // 14 <gps longitude>,
                // 15 <gps altitude>,
                // 16 <pitch>,
                // 17 <roll>,
                // 18 <yaw>,
                // 19 <takim no>, 
                // 20 <sıcaklık> //carrier 
                // 21 <pil gerilimi> //carrier
                // 22 <gps latitude> /carrier
                // 23 <gps longitude> //carrier
                //Data Gelmesini bekle
                if (telemetryData.Length > 19)
                {
                    //Telemetry To Labels
                    label_packageNo.Text = telemetryData[0];
                    label_uyduStatus.Text = telemetryData[1];
                    label_hataKod.Text = telemetryData[2];
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
                    string log = label_packageNo.Text + " numaralı " + label_currentTime.Text + " saatinde gelen veriler" + Environment.NewLine +
                        "Paket Numarasi:" + label_packageNo.Text + Environment.NewLine +
                        "Uydu Statusu:" + label_uyduStatus.Text + Environment.NewLine +
                        "Hata Kodu:" + label_hataKod.Text + Environment.NewLine +
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
                        "---------------------------------------------------" + Environment.NewLine;
                    //Sending Gyro To Model Simulation
                    //Pitch:X Yaw:Y Roll:Z
                    string gyroData = label_payloadPitch.Text + "," + label_payloadYaw.Text + "," + label_payloadRoll.Text;
                    try { new UdpClient().Send(Encoding.ASCII.GetBytes(gyroData), Encoding.ASCII.GetBytes(gyroData).Length, "127.0.0.1", 11000); } catch { }
                    //Sending Gyro To Model Simulation

                    //Uydu Status
                    switch (Int16.Parse(label_uyduStatus.Text))
                    {
                        case 0:
                            statusLabels[0].BackColor = Color.Lime;
                            break;
                        case 1:
                            statusLabels[1].BackColor = Color.Lime;
                            break;
                        case 2:
                            statusLabels[2].BackColor = Color.Lime;
                            break;
                        case 3:
                            statusLabels[3].BackColor = Color.Lime;
                            break;
                        case 4:
                            statusLabels[4].BackColor = Color.Lime;
                            break;
                        case 5:
                            statusLabels[5].BackColor = Color.Lime;
                            break;
                        case 6:
                            statusLabels[6].BackColor = Color.Lime;
                            break;
                        case 7:
                            statusLabels[7].BackColor = Color.Lime;
                            break;
                    }
                    //Uydu Status
                    //Charts
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
                    errorBit1.BackColor = label_hataKod.Text[0] == '0' ? Color.Lime : Color.Red;
                    errorBit2.BackColor = label_hataKod.Text[1] == '0' ? Color.Lime : Color.Red;
                    errorBit3.BackColor = label_hataKod.Text[2] == '0' ? Color.Lime : Color.Red;
                    errorBit4.BackColor = label_hataKod.Text[3] == '0' ? Color.Lime : Color.Red;
                    errorBit5.BackColor = label_hataKod.Text[4] == '0' ? Color.Lime : Color.Red;
                    //Error Code
                    //GPS To Map 
                    chromiumWebBrowser1.EvaluateScriptAsync("delLastMark();");
                    chromiumWebBrowser1.EvaluateScriptAsync("setmark(" + label_payloadGPSLatitude.Text + "," + label_payloadGPSLongitude.Text + "," + label_carrierGPSLatitude.Text + "," + label_carrierGPSLongitude.Text + ");");
                    //GPS To Map
                }
                buffer = string.Empty;//Buffer Temizleme (tam veri gelip işlendiyse)
            }
        }
        private void button_browseVideoFileToSend_Click(object sender, EventArgs e)
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
                catch (IOException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
        private void button_sendVideo_Click(object sender, EventArgs e)
        {
            if (textbox_ftpAddress.Text != ""&&textBox_videoPathToSend.Text!="")
            {
                Task.Run(() => Upload());
            }
            else { MessageBox.Show("FTP adresini veya gönderilecek olan dosyayı boş bırakmayınız!"); }
        }
        private void textbox_ftpAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(isValidConnection(textbox_ftpAddress.Text, ftpUserName, ftpPassword)?"FTP Connection Established":"FTP Connection Error!");
            }
        }

        private void button_telemetryCOMPortOpenClose_Click(object sender, EventArgs e)
        {
            if (button_telemetryCOMPortOpenClose.BackColor != Color.Green)
            {
                SerialPortProgram();
                button_telemetryCOMPortOpenClose.BackColor = Color.Green;
            }
            else
            {
                serialMonitorListBox.Items.Clear();
                port.Close();
                port.Dispose();
                button_telemetryCOMPortOpenClose.BackColor = Color.Lime;
                MessageBox.Show("Uçuş Tamamlandı!");
            }
        }
        //Form Events
    }
}
