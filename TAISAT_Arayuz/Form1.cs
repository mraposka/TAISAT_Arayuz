﻿using System;
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

namespace TAISAT_Arayuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Label[] statusLabels;//0-7 Arası Uydu Statusu Belirten labellar 

        //Video Kaydı Değişkenleri
        int width, height;
        int resolution; 
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
        public void InitBrowser()
        {
            var settings = new CefSettings();
            settings.RegisterScheme(new CefCustomScheme {SchemeName = "localfolder",  SchemeHandlerFactory = new FolderSchemeHandlerFactory(rootFolder: @"", defaultPage: "index.html")}); 
            Cef.Initialize(settings);  
            chromiumWebBrowser1.LoadHtml(File.ReadAllText(@"index.html")); 
        }

        public void SerialPortProgram()
        {
            port.DataReceived += Port_DataReceived;
            port.Open();
            Console.ReadLine();
        } 
        public void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            buffer += port.ReadExisting();//Buffer okuma(parça parça gelirse ekle)
            if (buffer.Contains("\n"))//Bufferın tamamı okunduysa veriyi işle
            {
                serialMonitorListBox.Items.Add(buffer);//Buffer loglama
                serialMonitorListBox.TopIndex = serialMonitorListBox.Items.Count - 1;//En sonuncu logu göstermek için listeyi otomatik aşağıya kaydırma
                string[] telemetryData = buffer.Split(',');
                // 0 <paket numarasi>,
                // 1 <uydu statusu>,
                // 2 <hata kodu>,
                // 3 <gonderme saati>,(2 parça geliyor  GÜN/AY/YIL,SAAT/DAKİKA/SANİYE)
                // 4 <basinc1>,
                // 5 <basinc2>,//Carrier
                // 6 <yukseklik1>,
                // 7 <yukseklik2>,//Carrier
                // 8 <irtifa farki>,
                // 9 <inis hizi>,
                // 10 <sicaklik>,
                // 11 <pil gerilimi>,
                // 12 <gps latitude>,
                // 13 <gps longitude>,
                // 14 <gps altitude>,
                // 15 <pitch>,
                // 16 <roll>,
                // 17 <yaw>,
                // 18 <takim no>,

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
                    //Telemetry To Labels 
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
                    payloadGPSAltitude_Chart.Series["P_GPSAltitude"].Points.AddY(label_payloadGPSAltitude.Text);
                    temperature_Chart.Series["Temperature"].Points.AddY(label_payloadTemperature.Text);
                    batterVoltage_Chart.Series["B_Voltage"].Points.AddY(label_payloadBataryVoltage.Text);
                    velocity_Chart.Series["Velocity"].Points.AddY(label_payloadVelocity.Text);
                    differenceAltitude_Chart.Series["D_Altitude"].Points.AddY(label_AltitudeDiff.Text);
                    payloadAltitude_Chart.Series["P_Altitude"].Points.AddY(label_payloadAltitude.Text);
                    carrierAltitude_Chart.Series["C_Altitude"].Points.AddY(label_containerAltitude.Text);
                    payloadPressure_Chart.Series["P_Pressure"].Points.AddY(label_payloadPressure.Text);
                    carrierPressure_Chart.Series["C_Pressure"].Points.AddY(label_containerPressure.Text);
                    //Charts
                    //Error Code
                    errorBit1.BackColor = label_hataKod.Text[0] == 0 ? Color.Lime : Color.Red;
                    errorBit2.BackColor = label_hataKod.Text[1] == 0 ? Color.Lime : Color.Red;
                    errorBit3.BackColor = label_hataKod.Text[2] == 0 ? Color.Lime : Color.Red;
                    errorBit4.BackColor = label_hataKod.Text[3] == 0 ? Color.Lime : Color.Red;
                    errorBit5.BackColor = label_hataKod.Text[4] == 0 ? Color.Lime : Color.Red;
                    //Error Code
                    //GPS To Map 
                    chromiumWebBrowser1.EvaluateScriptAsync("setmark(" + label_payloadGPSLatitude.Text + "," + label_payloadGPSLongitude.Text + ");");
                    //GPS To Map
                }
                buffer = string.Empty;//Buffer Temizleme (tam veri gelip işlendiyse)
            } 
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
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
                SaveFlight();
            }
        } 
        private void SaveFlight()
        {
            //Save everything
        } 
        private void button_refreshCOMPort_Click(object sender, EventArgs e)
        {
            ListComPorts();
        }
        void ListComPorts()
        { 
            foreach (var port in SerialPort.GetPortNames())
                comboBox_COMPortTelemetry.Items.Add(port); 
        } 
        private void comboBox_COMPortTelemetry_SelectedIndexChanged(object sender, EventArgs e)
        {
            port = new SerialPort(comboBox_COMPortTelemetry.SelectedItem.ToString(), Int32.Parse(comboBox_baudRateTelemetry.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
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
            catch (Exception error)
            {
                textBox_logs.AppendText(error.Message + Environment.NewLine);
            }
        }

        private void button_recordStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (button_recordStartStop.Text == "Start Record" && cam.IsRunning && videorecordpath != null)
                {  
                    string filePath = "" + videorecordpath + "\\" + "videoTaisat_" + DateTime.Now.ToString().Replace(':', '.').Replace(' ', '_') + ".avi";
                    videoWriter.Open(filePath, width, height, 30, Accord.Video.FFMPEG.VideoCodec.MPEG4, 5000000);
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
            catch (Exception error)
            {
                textBox_logs.AppendText(error.Message + Environment.NewLine);
            }
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam.IsRunning == true)
            {
                cam.Stop();
                videoWriter.Close();
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

        private void button_MANUAL_DEPLOY_Click(object sender, EventArgs e)
        {
            //TEST
            if (label_uyduStatus.Text == "") { label_uyduStatus.Text = "0"; }
            else { label_uyduStatus.Text = (Int16.Parse(label_uyduStatus.Text) + 1).ToString(); }
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
            //TEST
            /*MANUAL DEPLOY KOMUTU
            int currentStatus = Int16.Parse(label_uyduStatus.Text);
            //MANUAL DEPLOY KOMUTU (CURRENT STATUSUN 1 SONRASINI AKTİFLEŞTİRCEK)
            currentStatus++;
            label_uyduStatus.Text=currentStatus.ToString();
            //MANUAL DEPLOY KOMUTU */
        }
    }
}
