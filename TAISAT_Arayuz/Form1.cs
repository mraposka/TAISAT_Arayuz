using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using TAISAT_Arayuz.Properties;

namespace TAISAT_Arayuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }
        public void InitBrowser()
        {
            var settings = new CefSettings();
            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "localfolder",
                SchemeHandlerFactory = new FolderSchemeHandlerFactory(
                    rootFolder: @"",
                    defaultPage: "index.html" // default
                )
            });

            Cef.Initialize(settings);

            string html = File.ReadAllText(@"index.html"); 
            chromiumWebBrowser1.LoadHtml(html);  

        }
        SerialPort port;
        string buffer = string.Empty;
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
            buffer += port.ReadExisting(); 
            if (buffer.Contains("\n"))
            {
                serialMonitorListBox.Items.Add(buffer);
                serialMonitorListBox.TopIndex = serialMonitorListBox.Items.Count - 1;
                string[] telemetryData = buffer.Split(',');
                //1 Payload 2 Container
                // 0 <paket numarasi>,
                // 1 <uydu statusu>,
                // 2 <hata kodu>,
                // 3 <gonderme saati>,(2 parça geliyor)
                // 4 <basinc1>,
                // 5 <basinc2>,
                // 6 <yukseklik1>,
                // 7 <yukseklik2>,
                // 8 <irtifa farki>,
                // 9 <inis hizi>,
                // 10 <sicaklik>,
                // 11 <pil gerilimi>,
                // 12 <gps latitude1>,
                // 13 <gps longitude1>,
                // 14 <gps altitude>,
                // 15 <pitch>,
                // 16 <roll>,
                // 17 <yaw>,
                // 18 <takim no>,

                //Data Gelmesini bekle
                if (telemetryData.Length > 19)
                {
                    label_packageNo.Text = telemetryData[0];
                    label_uyduStatus.Text = telemetryData[1];
                    label_hataKod.Text = telemetryData[2];
                    label_currentDate.Text = telemetryData[3].Replace("/", ".");
                    label_currentTime.Text = telemetryData[4].Replace("/",":");
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
                   // MessageBox.Show("setmark(" + label_payloadGPSLatitude.Text + "," + label_payloadGPSLongitude.Text + ")");
                    chromiumWebBrowser1.EvaluateScriptAsync("setmark(" + label_payloadGPSLatitude.Text + "," + label_payloadGPSLongitude.Text + ");"); 
                } 
                buffer = string.Empty;
            }
            
        } 
        private void Form1_Load(object sender, EventArgs e)
        { 
            ListComPorts();
            comboBox_baudRateTelemetry.SelectedIndex=(comboBox_baudRateTelemetry.Items.Count - 1);
            string html = File.ReadAllText(@"index.html"); 
            chromiumWebBrowser1.LoadHtml(html);
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
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                comboBox_COMPortTelemetry.Items.Add(port);
            }
        }

        private void comboBox_COMPortTelemetry_SelectedIndexChanged(object sender, EventArgs e)
        {
            port = new SerialPort(comboBox_COMPortTelemetry.SelectedItem.ToString(), Int32.Parse(comboBox_baudRateTelemetry.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
        } 
    }
}
