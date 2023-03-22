namespace TAISAT_Arayuz
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabPage_serialMonitor;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_logs = new System.Windows.Forms.TextBox();
            this.text_Logs = new System.Windows.Forms.Label();
            this.serialMonitorListBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_refreshCOMPortV = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox_baudRateVideoTransfer = new System.Windows.Forms.ComboBox();
            this.comboBox_COMPortVideoTransfer = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_refreshCOMPort = new System.Windows.Forms.Button();
            this.button_telemetryCOMPortOpenClose = new System.Windows.Forms.Button();
            this.comboBox_baudRateTelemetry = new System.Windows.Forms.ComboBox();
            this.comboBox_COMPortTelemetry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.label_status07 = new System.Windows.Forms.Label();
            this.label_status05 = new System.Windows.Forms.Label();
            this.label_status06 = new System.Windows.Forms.Label();
            this.label_status04 = new System.Windows.Forms.Label();
            this.label_status03 = new System.Windows.Forms.Label();
            this.label_status02 = new System.Windows.Forms.Label();
            this.label_status01 = new System.Windows.Forms.Label();
            this.label_status00 = new System.Windows.Forms.Label();
            this.groupBox_saveDatasConfig = new System.Windows.Forms.GroupBox();
            this.label_sdCardFileSize = new System.Windows.Forms.Label();
            this.label_localFileSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_saveData = new System.Windows.Forms.Button();
            this.button_browseSdCardFolder = new System.Windows.Forms.Button();
            this.textBox_sdCardFolderPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_browseLocalFolder = new System.Windows.Forms.Button();
            this.textBox_localFolderPath = new System.Windows.Forms.TextBox();
            this.label_teamID = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel_views2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_charts = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.recordInformationLed = new System.Windows.Forms.Panel();
            this.label_videoRecordTime = new System.Windows.Forms.Label();
            this.button_browseVideoFolderToSave = new System.Windows.Forms.Button();
            this.textBox_videoFolderToSave = new System.Windows.Forms.TextBox();
            this.comboBox_chooseCamera = new System.Windows.Forms.ComboBox();
            this.progressBar_sendVideo = new System.Windows.Forms.ProgressBar();
            this.button_browseVideoFileToSend = new System.Windows.Forms.Button();
            this.textBox_videoPathToSend = new System.Windows.Forms.TextBox();
            this.button_sendVideo = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.button_recordStartStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_mainInformation = new System.Windows.Forms.TableLayoutPanel();
            this.label_uyduStatus = new System.Windows.Forms.Label();
            this.label_hataKod = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label_packageNo = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.button_cameraOpenClose = new System.Windows.Forms.Button();
            this.pictureBox_camera = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_camera = new System.Windows.Forms.Panel();
            this.panel_views1 = new System.Windows.Forms.Panel();
            this.panel_views4 = new System.Windows.Forms.Panel();
            this.label_payloadYaw = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label0 = new System.Windows.Forms.Label();
            this.label_AltitudeDiff = new System.Windows.Forms.Label();
            this.label_payloadRoll = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label_payloadPitch = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label_payloadBataryVoltage = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label_payloadTemperature = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label_payloadVelocity = new System.Windows.Forms.Label();
            this.label_payloadGPSLongitude = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_payloadGPSLatitude = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_payloadGPSAltitude = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_payloadAltitude = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label_payloadPressure = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_containerAltitude = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_containerPressure = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_errorBits = new System.Windows.Forms.TableLayoutPanel();
            this.errorBit5 = new System.Windows.Forms.Label();
            this.errorBit4 = new System.Windows.Forms.Label();
            this.errorBit3 = new System.Windows.Forms.Label();
            this.errorBit2 = new System.Windows.Forms.Label();
            this.errorBit1 = new System.Windows.Forms.Label();
            this.label_errors = new System.Windows.Forms.Label();
            this.button_MANUAL_DEPLOY = new System.Windows.Forms.Button();
            this.tableLayoutPanel_dateTime = new System.Windows.Forms.TableLayoutPanel();
            this.label_currentTime = new System.Windows.Forms.Label();
            this.label_currentDate = new System.Windows.Forms.Label();
            this.timer_videoRecordTime = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_telemetryData = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_telemetryTable = new System.Windows.Forms.TabPage();
            this.dataGridView_telemetryDataTable = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_views = new System.Windows.Forms.TableLayoutPanel();
            this.panel_views3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            tabPage_serialMonitor = new System.Windows.Forms.TabPage();
            tabPage_serialMonitor.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_status.SuspendLayout();
            this.groupBox_saveDatasConfig.SuspendLayout();
            this.panel_views2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel_mainInformation.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel_camera.SuspendLayout();
            this.panel_views1.SuspendLayout();
            this.panel_views4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel_errorBits.SuspendLayout();
            this.tableLayoutPanel_dateTime.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_telemetryTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_telemetryDataTable)).BeginInit();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel_views.SuspendLayout();
            this.panel_views3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_serialMonitor
            // 
            tabPage_serialMonitor.Controls.Add(this.tableLayoutPanel7);
            tabPage_serialMonitor.Location = new System.Drawing.Point(4, 22);
            tabPage_serialMonitor.Name = "tabPage_serialMonitor";
            tabPage_serialMonitor.Padding = new System.Windows.Forms.Padding(3);
            tabPage_serialMonitor.Size = new System.Drawing.Size(1397, 165);
            tabPage_serialMonitor.TabIndex = 1;
            tabPage_serialMonitor.Text = "Serial Monitor";
            tabPage_serialMonitor.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel13, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.serialMonitorListBox, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1391, 159);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.textBox_logs, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.text_Logs, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(976, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(412, 153);
            this.tableLayoutPanel13.TabIndex = 1;
            // 
            // textBox_logs
            // 
            this.textBox_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_logs.Location = new System.Drawing.Point(3, 23);
            this.textBox_logs.Multiline = true;
            this.textBox_logs.Name = "textBox_logs";
            this.textBox_logs.ReadOnly = true;
            this.textBox_logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_logs.Size = new System.Drawing.Size(406, 127);
            this.textBox_logs.TabIndex = 1;
            // 
            // text_Logs
            // 
            this.text_Logs.AutoSize = true;
            this.text_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_Logs.Location = new System.Drawing.Point(3, 0);
            this.text_Logs.Name = "text_Logs";
            this.text_Logs.Size = new System.Drawing.Size(406, 20);
            this.text_Logs.TabIndex = 2;
            this.text_Logs.Text = "Logs";
            this.text_Logs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialMonitorListBox
            // 
            this.serialMonitorListBox.FormattingEnabled = true;
            this.serialMonitorListBox.Location = new System.Drawing.Point(3, 3);
            this.serialMonitorListBox.Name = "serialMonitorListBox";
            this.serialMonitorListBox.Size = new System.Drawing.Size(967, 147);
            this.serialMonitorListBox.TabIndex = 7;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button_refreshCOMPortV
            // 
            this.button_refreshCOMPortV.BackColor = System.Drawing.Color.Transparent;
            this.button_refreshCOMPortV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_refreshCOMPortV.BackgroundImage")));
            this.button_refreshCOMPortV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_refreshCOMPortV.FlatAppearance.BorderSize = 0;
            this.button_refreshCOMPortV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refreshCOMPortV.Location = new System.Drawing.Point(0, 80);
            this.button_refreshCOMPortV.Name = "button_refreshCOMPortV";
            this.button_refreshCOMPortV.Size = new System.Drawing.Size(25, 25);
            this.button_refreshCOMPortV.TabIndex = 6;
            this.button_refreshCOMPortV.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.Lime;
            this.button9.Location = new System.Drawing.Point(99, 67);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 38);
            this.button9.TabIndex = 4;
            this.button9.Text = "Open COM Port";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // comboBox_baudRateVideoTransfer
            // 
            this.comboBox_baudRateVideoTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_baudRateVideoTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRateVideoTransfer.FormattingEnabled = true;
            this.comboBox_baudRateVideoTransfer.Location = new System.Drawing.Point(99, 40);
            this.comboBox_baudRateVideoTransfer.Name = "comboBox_baudRateVideoTransfer";
            this.comboBox_baudRateVideoTransfer.Size = new System.Drawing.Size(101, 21);
            this.comboBox_baudRateVideoTransfer.TabIndex = 3;
            // 
            // comboBox_COMPortVideoTransfer
            // 
            this.comboBox_COMPortVideoTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_COMPortVideoTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COMPortVideoTransfer.FormattingEnabled = true;
            this.comboBox_COMPortVideoTransfer.Location = new System.Drawing.Point(99, 13);
            this.comboBox_COMPortVideoTransfer.Name = "comboBox_COMPortVideoTransfer";
            this.comboBox_COMPortVideoTransfer.Size = new System.Drawing.Size(101, 21);
            this.comboBox_COMPortVideoTransfer.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(0, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 20);
            this.label23.TabIndex = 1;
            this.label23.Text = "Baud Rate";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(0, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "COMPort";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.button_refreshCOMPortV);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.comboBox_baudRateVideoTransfer);
            this.groupBox4.Controls.Add(this.comboBox_COMPortVideoTransfer);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Location = new System.Drawing.Point(491, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 117);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Video Transfer Config";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button_refreshCOMPort);
            this.groupBox3.Controls.Add(this.button_telemetryCOMPortOpenClose);
            this.groupBox3.Controls.Add(this.comboBox_baudRateTelemetry);
            this.groupBox3.Controls.Add(this.comboBox_COMPortTelemetry);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(491, -3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 116);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Telemetry Config";
            // 
            // button_refreshCOMPort
            // 
            this.button_refreshCOMPort.BackColor = System.Drawing.Color.Transparent;
            this.button_refreshCOMPort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_refreshCOMPort.BackgroundImage")));
            this.button_refreshCOMPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_refreshCOMPort.FlatAppearance.BorderSize = 0;
            this.button_refreshCOMPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refreshCOMPort.Location = new System.Drawing.Point(4, 73);
            this.button_refreshCOMPort.Name = "button_refreshCOMPort";
            this.button_refreshCOMPort.Size = new System.Drawing.Size(25, 25);
            this.button_refreshCOMPort.TabIndex = 5;
            this.button_refreshCOMPort.UseVisualStyleBackColor = false;
            this.button_refreshCOMPort.Click += new System.EventHandler(this.button_refreshCOMPort_Click);
            // 
            // button_telemetryCOMPortOpenClose
            // 
            this.button_telemetryCOMPortOpenClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_telemetryCOMPortOpenClose.BackColor = System.Drawing.Color.Lime;
            this.button_telemetryCOMPortOpenClose.Location = new System.Drawing.Point(99, 67);
            this.button_telemetryCOMPortOpenClose.Name = "button_telemetryCOMPortOpenClose";
            this.button_telemetryCOMPortOpenClose.Size = new System.Drawing.Size(101, 37);
            this.button_telemetryCOMPortOpenClose.TabIndex = 4;
            this.button_telemetryCOMPortOpenClose.Text = "Open COM Port";
            this.button_telemetryCOMPortOpenClose.UseVisualStyleBackColor = false;
            this.button_telemetryCOMPortOpenClose.Click += new System.EventHandler(this.button_telemetryCOMPortOpenClose_Click);
            // 
            // comboBox_baudRateTelemetry
            // 
            this.comboBox_baudRateTelemetry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_baudRateTelemetry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRateTelemetry.FormattingEnabled = true;
            this.comboBox_baudRateTelemetry.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_baudRateTelemetry.Location = new System.Drawing.Point(99, 40);
            this.comboBox_baudRateTelemetry.Name = "comboBox_baudRateTelemetry";
            this.comboBox_baudRateTelemetry.Size = new System.Drawing.Size(101, 21);
            this.comboBox_baudRateTelemetry.TabIndex = 3;
            // 
            // comboBox_COMPortTelemetry
            // 
            this.comboBox_COMPortTelemetry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_COMPortTelemetry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COMPortTelemetry.DropDownWidth = 150;
            this.comboBox_COMPortTelemetry.FormattingEnabled = true;
            this.comboBox_COMPortTelemetry.Location = new System.Drawing.Point(99, 13);
            this.comboBox_COMPortTelemetry.Name = "comboBox_COMPortTelemetry";
            this.comboBox_COMPortTelemetry.Size = new System.Drawing.Size(101, 21);
            this.comboBox_COMPortTelemetry.TabIndex = 2;
            this.comboBox_COMPortTelemetry.SelectedIndexChanged += new System.EventHandler(this.comboBox_COMPortTelemetry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "COMPort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select local folder to save.";
            // 
            // groupBox_status
            // 
            this.groupBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_status.Controls.Add(this.label_status07);
            this.groupBox_status.Controls.Add(this.label_status05);
            this.groupBox_status.Controls.Add(this.label_status06);
            this.groupBox_status.Controls.Add(this.label_status04);
            this.groupBox_status.Controls.Add(this.label_status03);
            this.groupBox_status.Controls.Add(this.label_status02);
            this.groupBox_status.Controls.Add(this.label_status01);
            this.groupBox_status.Controls.Add(this.label_status00);
            this.groupBox_status.Location = new System.Drawing.Point(-3, -3);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(315, 242);
            this.groupBox_status.TabIndex = 26;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "Status";
            // 
            // label_status07
            // 
            this.label_status07.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_status07.Location = new System.Drawing.Point(0, 215);
            this.label_status07.Name = "label_status07";
            this.label_status07.Size = new System.Drawing.Size(302, 15);
            this.label_status07.TabIndex = 7;
            this.label_status07.Text = "7- Paket Video Gönderildi";
            this.label_status07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_status05
            // 
            this.label_status05.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status05.AutoEllipsis = true;
            this.label_status05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_status05.Location = new System.Drawing.Point(0, 159);
            this.label_status05.Name = "label_status05";
            this.label_status05.Size = new System.Drawing.Size(302, 15);
            this.label_status05.TabIndex = 6;
            this.label_status05.Text = "5- Kurtarma (Görev Yükü Yere Teması)";
            this.label_status05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_status06
            // 
            this.label_status06.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_status06.Location = new System.Drawing.Point(0, 187);
            this.label_status06.Name = "label_status06";
            this.label_status06.Size = new System.Drawing.Size(302, 15);
            this.label_status06.TabIndex = 5;
            this.label_status06.Text = "6- Paket Video Alındı";
            this.label_status06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_status04
            // 
            this.label_status04.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_status04.Location = new System.Drawing.Point(0, 131);
            this.label_status04.Name = "label_status04";
            this.label_status04.Size = new System.Drawing.Size(302, 15);
            this.label_status04.TabIndex = 4;
            this.label_status04.Text = "4- Görev Yükü İniş";
            this.label_status04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_status03
            // 
            this.label_status03.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status03.BackColor = System.Drawing.Color.Red;
            this.label_status03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_status03.Location = new System.Drawing.Point(0, 103);
            this.label_status03.Name = "label_status03";
            this.label_status03.Size = new System.Drawing.Size(302, 15);
            this.label_status03.TabIndex = 3;
            this.label_status03.Text = "3- Ayrılma";
            this.label_status03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_status02
            // 
            this.label_status02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status02.BackColor = System.Drawing.Color.Lime;
            this.label_status02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_status02.Location = new System.Drawing.Point(0, 75);
            this.label_status02.Name = "label_status02";
            this.label_status02.Size = new System.Drawing.Size(302, 15);
            this.label_status02.TabIndex = 2;
            this.label_status02.Text = "2- Model Uydu İniş";
            this.label_status02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_status01
            // 
            this.label_status01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status01.BackColor = System.Drawing.Color.Lime;
            this.label_status01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_status01.Location = new System.Drawing.Point(0, 47);
            this.label_status01.Name = "label_status01";
            this.label_status01.Size = new System.Drawing.Size(302, 15);
            this.label_status01.TabIndex = 1;
            this.label_status01.Text = "1- Yükselme";
            this.label_status01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_status00
            // 
            this.label_status00.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status00.BackColor = System.Drawing.Color.Lime;
            this.label_status00.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_status00.Location = new System.Drawing.Point(0, 19);
            this.label_status00.Name = "label_status00";
            this.label_status00.Size = new System.Drawing.Size(302, 15);
            this.label_status00.TabIndex = 0;
            this.label_status00.Text = "0- Uçuşa Hazır";
            this.label_status00.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_saveDatasConfig
            // 
            this.groupBox_saveDatasConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_saveDatasConfig.Controls.Add(this.label_sdCardFileSize);
            this.groupBox_saveDatasConfig.Controls.Add(this.label_localFileSize);
            this.groupBox_saveDatasConfig.Controls.Add(this.label6);
            this.groupBox_saveDatasConfig.Controls.Add(this.label5);
            this.groupBox_saveDatasConfig.Controls.Add(this.button_saveData);
            this.groupBox_saveDatasConfig.Controls.Add(this.button_browseSdCardFolder);
            this.groupBox_saveDatasConfig.Controls.Add(this.textBox_sdCardFolderPath);
            this.groupBox_saveDatasConfig.Controls.Add(this.label4);
            this.groupBox_saveDatasConfig.Controls.Add(this.button_browseLocalFolder);
            this.groupBox_saveDatasConfig.Controls.Add(this.textBox_localFolderPath);
            this.groupBox_saveDatasConfig.Controls.Add(this.label3);
            this.groupBox_saveDatasConfig.Location = new System.Drawing.Point(317, -3);
            this.groupBox_saveDatasConfig.Name = "groupBox_saveDatasConfig";
            this.groupBox_saveDatasConfig.Size = new System.Drawing.Size(168, 242);
            this.groupBox_saveDatasConfig.TabIndex = 25;
            this.groupBox_saveDatasConfig.TabStop = false;
            this.groupBox_saveDatasConfig.Text = "Save Data";
            // 
            // label_sdCardFileSize
            // 
            this.label_sdCardFileSize.AutoSize = true;
            this.label_sdCardFileSize.Location = new System.Drawing.Point(104, 168);
            this.label_sdCardFileSize.Name = "label_sdCardFileSize";
            this.label_sdCardFileSize.Size = new System.Drawing.Size(51, 13);
            this.label_sdCardFileSize.TabIndex = 10;
            this.label_sdCardFileSize.Text = "1024byte";
            this.label_sdCardFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_localFileSize
            // 
            this.label_localFileSize.AutoSize = true;
            this.label_localFileSize.Location = new System.Drawing.Point(105, 145);
            this.label_localFileSize.Name = "label_localFileSize";
            this.label_localFileSize.Size = new System.Drawing.Size(51, 13);
            this.label_localFileSize.TabIndex = 9;
            this.label_localFileSize.Text = "1024byte";
            this.label_localFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "SD Card file size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Local file size:";
            // 
            // button_saveData
            // 
            this.button_saveData.BackColor = System.Drawing.Color.Lime;
            this.button_saveData.Location = new System.Drawing.Point(0, 192);
            this.button_saveData.Name = "button_saveData";
            this.button_saveData.Size = new System.Drawing.Size(155, 38);
            this.button_saveData.TabIndex = 6;
            this.button_saveData.Text = "Save Data";
            this.button_saveData.UseVisualStyleBackColor = false;
            // 
            // button_browseSdCardFolder
            // 
            this.button_browseSdCardFolder.Location = new System.Drawing.Point(128, 89);
            this.button_browseSdCardFolder.Name = "button_browseSdCardFolder";
            this.button_browseSdCardFolder.Size = new System.Drawing.Size(28, 20);
            this.button_browseSdCardFolder.TabIndex = 5;
            this.button_browseSdCardFolder.Text = "...";
            this.button_browseSdCardFolder.UseVisualStyleBackColor = true;
            // 
            // textBox_sdCardFolderPath
            // 
            this.textBox_sdCardFolderPath.Location = new System.Drawing.Point(0, 90);
            this.textBox_sdCardFolderPath.Name = "textBox_sdCardFolderPath";
            this.textBox_sdCardFolderPath.ReadOnly = true;
            this.textBox_sdCardFolderPath.Size = new System.Drawing.Size(121, 20);
            this.textBox_sdCardFolderPath.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select SD Card folder to save.";
            // 
            // button_browseLocalFolder
            // 
            this.button_browseLocalFolder.Location = new System.Drawing.Point(128, 38);
            this.button_browseLocalFolder.Name = "button_browseLocalFolder";
            this.button_browseLocalFolder.Size = new System.Drawing.Size(28, 20);
            this.button_browseLocalFolder.TabIndex = 2;
            this.button_browseLocalFolder.Text = "...";
            this.button_browseLocalFolder.UseVisualStyleBackColor = true;
            // 
            // textBox_localFolderPath
            // 
            this.textBox_localFolderPath.Location = new System.Drawing.Point(1, 38);
            this.textBox_localFolderPath.Name = "textBox_localFolderPath";
            this.textBox_localFolderPath.ReadOnly = true;
            this.textBox_localFolderPath.Size = new System.Drawing.Size(121, 20);
            this.textBox_localFolderPath.TabIndex = 1;
            // 
            // label_teamID
            // 
            this.label_teamID.AutoSize = true;
            this.label_teamID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_teamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_teamID.Location = new System.Drawing.Point(3, 38);
            this.label_teamID.Margin = new System.Windows.Forms.Padding(3);
            this.label_teamID.Name = "label_teamID";
            this.label_teamID.Size = new System.Drawing.Size(139, 29);
            this.label_teamID.TabIndex = 4;
            this.label_teamID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(3, 3);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "Team ID";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_views2
            // 
            this.panel_views2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_views2.Controls.Add(this.tableLayoutPanel_charts);
            this.panel_views2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_views2.Location = new System.Drawing.Point(588, 0);
            this.panel_views2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 6);
            this.panel_views2.Name = "panel_views2";
            this.panel_views2.Size = new System.Drawing.Size(714, 369);
            this.panel_views2.TabIndex = 32;
            // 
            // tableLayoutPanel_charts
            // 
            this.tableLayoutPanel_charts.ColumnCount = 3;
            this.tableLayoutPanel_charts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_charts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_charts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_charts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_charts.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_charts.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_charts.Name = "tableLayoutPanel_charts";
            this.tableLayoutPanel_charts.RowCount = 2;
            this.tableLayoutPanel_charts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_charts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_charts.Size = new System.Drawing.Size(712, 367);
            this.tableLayoutPanel_charts.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(148, 3);
            this.label26.Margin = new System.Windows.Forms.Padding(3);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(139, 29);
            this.label26.TabIndex = 1;
            this.label26.Text = "Package No";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordInformationLed
            // 
            this.recordInformationLed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recordInformationLed.BackColor = System.Drawing.Color.Transparent;
            this.recordInformationLed.Location = new System.Drawing.Point(71, 143);
            this.recordInformationLed.Name = "recordInformationLed";
            this.recordInformationLed.Size = new System.Drawing.Size(13, 13);
            this.recordInformationLed.TabIndex = 15;
            // 
            // label_videoRecordTime
            // 
            this.label_videoRecordTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_videoRecordTime.AutoSize = true;
            this.label_videoRecordTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_videoRecordTime.Location = new System.Drawing.Point(86, 143);
            this.label_videoRecordTime.Name = "label_videoRecordTime";
            this.label_videoRecordTime.Size = new System.Drawing.Size(49, 13);
            this.label_videoRecordTime.TabIndex = 14;
            this.label_videoRecordTime.Text = "00:00:00";
            this.label_videoRecordTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_browseVideoFolderToSave
            // 
            this.button_browseVideoFolderToSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browseVideoFolderToSave.Location = new System.Drawing.Point(112, 79);
            this.button_browseVideoFolderToSave.Name = "button_browseVideoFolderToSave";
            this.button_browseVideoFolderToSave.Size = new System.Drawing.Size(23, 23);
            this.button_browseVideoFolderToSave.TabIndex = 13;
            this.button_browseVideoFolderToSave.Text = "..";
            this.button_browseVideoFolderToSave.UseVisualStyleBackColor = true;
            // 
            // textBox_videoFolderToSave
            // 
            this.textBox_videoFolderToSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_videoFolderToSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_videoFolderToSave.Location = new System.Drawing.Point(-2, 81);
            this.textBox_videoFolderToSave.Name = "textBox_videoFolderToSave";
            this.textBox_videoFolderToSave.ReadOnly = true;
            this.textBox_videoFolderToSave.Size = new System.Drawing.Size(111, 20);
            this.textBox_videoFolderToSave.TabIndex = 12;
            // 
            // comboBox_chooseCamera
            // 
            this.comboBox_chooseCamera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_chooseCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chooseCamera.FormattingEnabled = true;
            this.comboBox_chooseCamera.Location = new System.Drawing.Point(-3, 15);
            this.comboBox_chooseCamera.Name = "comboBox_chooseCamera";
            this.comboBox_chooseCamera.Size = new System.Drawing.Size(138, 21);
            this.comboBox_chooseCamera.TabIndex = 11;
            // 
            // progressBar_sendVideo
            // 
            this.progressBar_sendVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_sendVideo.Location = new System.Drawing.Point(-2, 228);
            this.progressBar_sendVideo.Name = "progressBar_sendVideo";
            this.progressBar_sendVideo.Size = new System.Drawing.Size(137, 10);
            this.progressBar_sendVideo.Step = 1;
            this.progressBar_sendVideo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_sendVideo.TabIndex = 0;
            this.progressBar_sendVideo.Tag = "";
            // 
            // button_browseVideoFileToSend
            // 
            this.button_browseVideoFileToSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browseVideoFileToSend.Location = new System.Drawing.Point(112, 202);
            this.button_browseVideoFileToSend.Name = "button_browseVideoFileToSend";
            this.button_browseVideoFileToSend.Size = new System.Drawing.Size(23, 23);
            this.button_browseVideoFileToSend.TabIndex = 10;
            this.button_browseVideoFileToSend.Text = "..";
            this.button_browseVideoFileToSend.UseVisualStyleBackColor = true;
            // 
            // textBox_videoPathToSend
            // 
            this.textBox_videoPathToSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_videoPathToSend.Location = new System.Drawing.Point(-2, 204);
            this.textBox_videoPathToSend.Name = "textBox_videoPathToSend";
            this.textBox_videoPathToSend.ReadOnly = true;
            this.textBox_videoPathToSend.Size = new System.Drawing.Size(111, 20);
            this.textBox_videoPathToSend.TabIndex = 9;
            // 
            // button_sendVideo
            // 
            this.button_sendVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sendVideo.BackColor = System.Drawing.Color.Transparent;
            this.button_sendVideo.Location = new System.Drawing.Point(-3, 240);
            this.button_sendVideo.Name = "button_sendVideo";
            this.button_sendVideo.Size = new System.Drawing.Size(138, 34);
            this.button_sendVideo.TabIndex = 8;
            this.button_sendVideo.Text = "Send Video";
            this.button_sendVideo.UseVisualStyleBackColor = false;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(-3, 188);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(76, 13);
            this.label34.TabIndex = 6;
            this.label34.Text = "Video Transfer";
            this.label34.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_recordStartStop
            // 
            this.button_recordStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_recordStartStop.BackColor = System.Drawing.Color.Transparent;
            this.button_recordStartStop.Location = new System.Drawing.Point(-2, 107);
            this.button_recordStartStop.Name = "button_recordStartStop";
            this.button_recordStartStop.Size = new System.Drawing.Size(138, 34);
            this.button_recordStartStop.TabIndex = 2;
            this.button_recordStartStop.Text = "Start Record";
            this.button_recordStartStop.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(-3, -2);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(43, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Camera";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(293, 3);
            this.label28.Margin = new System.Windows.Forms.Padding(3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(139, 29);
            this.label28.TabIndex = 6;
            this.label28.Text = "Status";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_mainInformation
            // 
            this.tableLayoutPanel_mainInformation.ColumnCount = 4;
            this.tableLayoutPanel_mainInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_mainInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_mainInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_mainInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_mainInformation.Controls.Add(this.label_uyduStatus, 2, 1);
            this.tableLayoutPanel_mainInformation.Controls.Add(this.label_hataKod, 3, 1);
            this.tableLayoutPanel_mainInformation.Controls.Add(this.label32, 3, 0);
            this.tableLayoutPanel_mainInformation.Controls.Add(this.label28, 2, 0);
            this.tableLayoutPanel_mainInformation.Controls.Add(this.label_packageNo, 1, 1);
            this.tableLayoutPanel_mainInformation.Controls.Add(this.label_teamID, 0, 1);
            this.tableLayoutPanel_mainInformation.Controls.Add(this.label26, 1, 0);
            this.tableLayoutPanel_mainInformation.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel_mainInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_mainInformation.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_mainInformation.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_mainInformation.Name = "tableLayoutPanel_mainInformation";
            this.tableLayoutPanel_mainInformation.RowCount = 2;
            this.tableLayoutPanel_mainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_mainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_mainInformation.Size = new System.Drawing.Size(580, 70);
            this.tableLayoutPanel_mainInformation.TabIndex = 20;
            // 
            // label_uyduStatus
            // 
            this.label_uyduStatus.AutoSize = true;
            this.label_uyduStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_uyduStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_uyduStatus.Location = new System.Drawing.Point(293, 38);
            this.label_uyduStatus.Margin = new System.Windows.Forms.Padding(3);
            this.label_uyduStatus.Name = "label_uyduStatus";
            this.label_uyduStatus.Size = new System.Drawing.Size(139, 29);
            this.label_uyduStatus.TabIndex = 10;
            this.label_uyduStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_hataKod
            // 
            this.label_hataKod.AutoSize = true;
            this.label_hataKod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_hataKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hataKod.Location = new System.Drawing.Point(438, 38);
            this.label_hataKod.Margin = new System.Windows.Forms.Padding(3);
            this.label_hataKod.Name = "label_hataKod";
            this.label_hataKod.Size = new System.Drawing.Size(139, 29);
            this.label_hataKod.TabIndex = 9;
            this.label_hataKod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(438, 3);
            this.label32.Margin = new System.Windows.Forms.Padding(3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(139, 29);
            this.label32.TabIndex = 8;
            this.label32.Text = "Hata Kodu";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_packageNo
            // 
            this.label_packageNo.AutoSize = true;
            this.label_packageNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_packageNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_packageNo.Location = new System.Drawing.Point(148, 38);
            this.label_packageNo.Margin = new System.Windows.Forms.Padding(3);
            this.label_packageNo.Name = "label_packageNo";
            this.label_packageNo.Size = new System.Drawing.Size(139, 29);
            this.label_packageNo.TabIndex = 5;
            this.label_packageNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_header
            // 
            this.panel_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_header.Controls.Add(this.tableLayoutPanel_mainInformation);
            this.panel_header.Location = new System.Drawing.Point(-6, -6);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(582, 72);
            this.panel_header.TabIndex = 29;
            // 
            // button_cameraOpenClose
            // 
            this.button_cameraOpenClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cameraOpenClose.BackColor = System.Drawing.Color.Lime;
            this.button_cameraOpenClose.Location = new System.Drawing.Point(-3, 41);
            this.button_cameraOpenClose.Name = "button_cameraOpenClose";
            this.button_cameraOpenClose.Size = new System.Drawing.Size(138, 34);
            this.button_cameraOpenClose.TabIndex = 0;
            this.button_cameraOpenClose.Text = "Open Camera";
            this.button_cameraOpenClose.UseVisualStyleBackColor = false;
            // 
            // pictureBox_camera
            // 
            this.pictureBox_camera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_camera.BackColor = System.Drawing.Color.Black;
            this.pictureBox_camera.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox_camera.Name = "pictureBox_camera";
            this.pictureBox_camera.Size = new System.Drawing.Size(423, 283);
            this.pictureBox_camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_camera.TabIndex = 17;
            this.pictureBox_camera.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.recordInformationLed);
            this.panel5.Controls.Add(this.label_videoRecordTime);
            this.panel5.Controls.Add(this.button_browseVideoFolderToSave);
            this.panel5.Controls.Add(this.textBox_videoFolderToSave);
            this.panel5.Controls.Add(this.comboBox_chooseCamera);
            this.panel5.Controls.Add(this.progressBar_sendVideo);
            this.panel5.Controls.Add(this.button_browseVideoFileToSend);
            this.panel5.Controls.Add(this.textBox_videoPathToSend);
            this.panel5.Controls.Add(this.button_sendVideo);
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.button_recordStartStop);
            this.panel5.Controls.Add(this.label33);
            this.panel5.Controls.Add(this.button_cameraOpenClose);
            this.panel5.Location = new System.Drawing.Point(426, -3);
            this.panel5.MinimumSize = new System.Drawing.Size(145, 250);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(145, 284);
            this.panel5.TabIndex = 16;
            // 
            // panel_camera
            // 
            this.panel_camera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_camera.Controls.Add(this.pictureBox_camera);
            this.panel_camera.Controls.Add(this.panel5);
            this.panel_camera.Location = new System.Drawing.Point(-6, 72);
            this.panel_camera.Margin = new System.Windows.Forms.Padding(0);
            this.panel_camera.MinimumSize = new System.Drawing.Size(481, 257);
            this.panel_camera.Name = "panel_camera";
            this.panel_camera.Size = new System.Drawing.Size(582, 291);
            this.panel_camera.TabIndex = 28;
            // 
            // panel_views1
            // 
            this.panel_views1.Controls.Add(this.panel_camera);
            this.panel_views1.Controls.Add(this.panel_header);
            this.panel_views1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_views1.Location = new System.Drawing.Point(0, 0);
            this.panel_views1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.panel_views1.Name = "panel_views1";
            this.panel_views1.Size = new System.Drawing.Size(582, 372);
            this.panel_views1.TabIndex = 0;
            // 
            // panel_views4
            // 
            this.panel_views4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_views4.Controls.Add(this.groupBox_status);
            this.panel_views4.Controls.Add(this.groupBox_saveDatasConfig);
            this.panel_views4.Controls.Add(this.groupBox3);
            this.panel_views4.Controls.Add(this.groupBox4);
            this.panel_views4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_views4.Location = new System.Drawing.Point(588, 375);
            this.panel_views4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel_views4.Name = "panel_views4";
            this.panel_views4.Size = new System.Drawing.Size(714, 250);
            this.panel_views4.TabIndex = 33;
            // 
            // label_payloadYaw
            // 
            this.label_payloadYaw.AutoEllipsis = true;
            this.label_payloadYaw.AutoSize = true;
            this.label_payloadYaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadYaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadYaw.Location = new System.Drawing.Point(117, 303);
            this.label_payloadYaw.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadYaw.Name = "label_payloadYaw";
            this.label_payloadYaw.Size = new System.Drawing.Size(70, 24);
            this.label_payloadYaw.TabIndex = 21;
            this.label_payloadYaw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.AutoEllipsis = true;
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(3, 303);
            this.label31.Margin = new System.Windows.Forms.Padding(3);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(108, 24);
            this.label31.TabIndex = 20;
            this.label31.Text = "Yaw(°)";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.label0, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.label_AltitudeDiff, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadYaw, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.label31, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadRoll, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.label29, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadPitch, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label27, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadBataryVoltage, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label22, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadTemperature, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadVelocity, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadGPSLongitude, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadGPSLatitude, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadGPSAltitude, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadAltitude, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_payloadPressure, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label24, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 126);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 361);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label0
            // 
            this.label0.AutoEllipsis = true;
            this.label0.AutoSize = true;
            this.label0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label0.Location = new System.Drawing.Point(3, 333);
            this.label0.Margin = new System.Windows.Forms.Padding(3);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(108, 25);
            this.label0.TabIndex = 23;
            this.label0.Text = "Diff";
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_AltitudeDiff
            // 
            this.label_AltitudeDiff.AutoEllipsis = true;
            this.label_AltitudeDiff.AutoSize = true;
            this.label_AltitudeDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_AltitudeDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_AltitudeDiff.Location = new System.Drawing.Point(117, 333);
            this.label_AltitudeDiff.Margin = new System.Windows.Forms.Padding(3);
            this.label_AltitudeDiff.Name = "label_AltitudeDiff";
            this.label_AltitudeDiff.Size = new System.Drawing.Size(70, 25);
            this.label_AltitudeDiff.TabIndex = 22;
            this.label_AltitudeDiff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payloadRoll
            // 
            this.label_payloadRoll.AutoEllipsis = true;
            this.label_payloadRoll.AutoSize = true;
            this.label_payloadRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadRoll.Location = new System.Drawing.Point(117, 273);
            this.label_payloadRoll.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadRoll.Name = "label_payloadRoll";
            this.label_payloadRoll.Size = new System.Drawing.Size(70, 24);
            this.label_payloadRoll.TabIndex = 19;
            this.label_payloadRoll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoEllipsis = true;
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(3, 273);
            this.label29.Margin = new System.Windows.Forms.Padding(3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(108, 24);
            this.label29.TabIndex = 18;
            this.label29.Text = "Roll(°)";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payloadPitch
            // 
            this.label_payloadPitch.AutoEllipsis = true;
            this.label_payloadPitch.AutoSize = true;
            this.label_payloadPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadPitch.Location = new System.Drawing.Point(117, 243);
            this.label_payloadPitch.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadPitch.Name = "label_payloadPitch";
            this.label_payloadPitch.Size = new System.Drawing.Size(70, 24);
            this.label_payloadPitch.TabIndex = 17;
            this.label_payloadPitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.AutoEllipsis = true;
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(3, 243);
            this.label27.Margin = new System.Windows.Forms.Padding(3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(108, 24);
            this.label27.TabIndex = 16;
            this.label27.Text = "Pitch(°)";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payloadBataryVoltage
            // 
            this.label_payloadBataryVoltage.AutoEllipsis = true;
            this.label_payloadBataryVoltage.AutoSize = true;
            this.label_payloadBataryVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadBataryVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadBataryVoltage.Location = new System.Drawing.Point(117, 213);
            this.label_payloadBataryVoltage.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadBataryVoltage.Name = "label_payloadBataryVoltage";
            this.label_payloadBataryVoltage.Size = new System.Drawing.Size(70, 24);
            this.label_payloadBataryVoltage.TabIndex = 15;
            this.label_payloadBataryVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoEllipsis = true;
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(3, 213);
            this.label22.Margin = new System.Windows.Forms.Padding(3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 24);
            this.label22.TabIndex = 14;
            this.label22.Text = "B. Voltage(V)";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payloadTemperature
            // 
            this.label_payloadTemperature.AutoEllipsis = true;
            this.label_payloadTemperature.AutoSize = true;
            this.label_payloadTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadTemperature.Location = new System.Drawing.Point(117, 183);
            this.label_payloadTemperature.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadTemperature.Name = "label_payloadTemperature";
            this.label_payloadTemperature.Size = new System.Drawing.Size(70, 24);
            this.label_payloadTemperature.TabIndex = 13;
            this.label_payloadTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoEllipsis = true;
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(3, 183);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 24);
            this.label18.TabIndex = 12;
            this.label18.Text = "Temperature(C°)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payloadVelocity
            // 
            this.label_payloadVelocity.AutoEllipsis = true;
            this.label_payloadVelocity.AutoSize = true;
            this.label_payloadVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadVelocity.Location = new System.Drawing.Point(117, 153);
            this.label_payloadVelocity.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadVelocity.Name = "label_payloadVelocity";
            this.label_payloadVelocity.Size = new System.Drawing.Size(70, 24);
            this.label_payloadVelocity.TabIndex = 11;
            this.label_payloadVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payloadGPSLongitude
            // 
            this.label_payloadGPSLongitude.AutoEllipsis = true;
            this.label_payloadGPSLongitude.AutoSize = true;
            this.label_payloadGPSLongitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadGPSLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadGPSLongitude.Location = new System.Drawing.Point(117, 123);
            this.label_payloadGPSLongitude.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadGPSLongitude.Name = "label_payloadGPSLongitude";
            this.label_payloadGPSLongitude.Size = new System.Drawing.Size(70, 24);
            this.label_payloadGPSLongitude.TabIndex = 9;
            this.label_payloadGPSLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(3, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "GPS Longitude";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payloadGPSLatitude
            // 
            this.label_payloadGPSLatitude.AutoEllipsis = true;
            this.label_payloadGPSLatitude.AutoSize = true;
            this.label_payloadGPSLatitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadGPSLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadGPSLatitude.Location = new System.Drawing.Point(117, 93);
            this.label_payloadGPSLatitude.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadGPSLatitude.Name = "label_payloadGPSLatitude";
            this.label_payloadGPSLatitude.Size = new System.Drawing.Size(70, 24);
            this.label_payloadGPSLatitude.TabIndex = 7;
            this.label_payloadGPSLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoEllipsis = true;
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(3, 93);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 24);
            this.label17.TabIndex = 6;
            this.label17.Text = "GPS Latitude";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payloadGPSAltitude
            // 
            this.label_payloadGPSAltitude.AutoEllipsis = true;
            this.label_payloadGPSAltitude.AutoSize = true;
            this.label_payloadGPSAltitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadGPSAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadGPSAltitude.Location = new System.Drawing.Point(117, 63);
            this.label_payloadGPSAltitude.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadGPSAltitude.Name = "label_payloadGPSAltitude";
            this.label_payloadGPSAltitude.Size = new System.Drawing.Size(70, 24);
            this.label_payloadGPSAltitude.TabIndex = 5;
            this.label_payloadGPSAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoEllipsis = true;
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(3, 63);
            this.label19.Margin = new System.Windows.Forms.Padding(3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 24);
            this.label19.TabIndex = 4;
            this.label19.Text = "GPS Altitude(m)";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payloadAltitude
            // 
            this.label_payloadAltitude.AutoEllipsis = true;
            this.label_payloadAltitude.AutoSize = true;
            this.label_payloadAltitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadAltitude.Location = new System.Drawing.Point(117, 33);
            this.label_payloadAltitude.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadAltitude.Name = "label_payloadAltitude";
            this.label_payloadAltitude.Size = new System.Drawing.Size(70, 24);
            this.label_payloadAltitude.TabIndex = 3;
            this.label_payloadAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoEllipsis = true;
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(3, 33);
            this.label21.Margin = new System.Windows.Forms.Padding(3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 24);
            this.label21.TabIndex = 2;
            this.label21.Text = "Altitude(m)";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payloadPressure
            // 
            this.label_payloadPressure.AutoEllipsis = true;
            this.label_payloadPressure.AutoSize = true;
            this.label_payloadPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_payloadPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payloadPressure.Location = new System.Drawing.Point(117, 3);
            this.label_payloadPressure.Margin = new System.Windows.Forms.Padding(3);
            this.label_payloadPressure.Name = "label_payloadPressure";
            this.label_payloadPressure.Size = new System.Drawing.Size(70, 24);
            this.label_payloadPressure.TabIndex = 1;
            this.label_payloadPressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoEllipsis = true;
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(3, 3);
            this.label24.Margin = new System.Windows.Forms.Padding(3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 24);
            this.label24.TabIndex = 0;
            this.label24.Text = "Pressure(Pa)";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "V. Velocity(m/s)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-3, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 561);
            this.panel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(59, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Payload";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label_containerAltitude, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_containerPressure, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(190, 67);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_containerAltitude
            // 
            this.label_containerAltitude.AutoEllipsis = true;
            this.label_containerAltitude.AutoSize = true;
            this.label_containerAltitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_containerAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_containerAltitude.Location = new System.Drawing.Point(117, 33);
            this.label_containerAltitude.Margin = new System.Windows.Forms.Padding(3);
            this.label_containerAltitude.Name = "label_containerAltitude";
            this.label_containerAltitude.Size = new System.Drawing.Size(70, 31);
            this.label_containerAltitude.TabIndex = 3;
            this.label_containerAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "Altitude(m)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_containerPressure
            // 
            this.label_containerPressure.AutoEllipsis = true;
            this.label_containerPressure.AutoSize = true;
            this.label_containerPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_containerPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_containerPressure.Location = new System.Drawing.Point(117, 3);
            this.label_containerPressure.Margin = new System.Windows.Forms.Padding(3);
            this.label_containerPressure.Name = "label_containerPressure";
            this.label_containerPressure.Size = new System.Drawing.Size(70, 24);
            this.label_containerPressure.TabIndex = 1;
            this.label_containerPressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Pressure(Pa)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(43, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Container";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.tableLayoutPanel_errorBits);
            this.panel2.Controls.Add(this.label_errors);
            this.panel2.Controls.Add(this.button_MANUAL_DEPLOY);
            this.panel2.Controls.Add(this.tableLayoutPanel_dateTime);
            this.panel2.Location = new System.Drawing.Point(6, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 746);
            this.panel2.TabIndex = 18;
            // 
            // tableLayoutPanel_errorBits
            // 
            this.tableLayoutPanel_errorBits.ColumnCount = 5;
            this.tableLayoutPanel_errorBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_errorBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_errorBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_errorBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_errorBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_errorBits.Controls.Add(this.errorBit5, 4, 0);
            this.tableLayoutPanel_errorBits.Controls.Add(this.errorBit4, 3, 0);
            this.tableLayoutPanel_errorBits.Controls.Add(this.errorBit3, 2, 0);
            this.tableLayoutPanel_errorBits.Controls.Add(this.errorBit2, 1, 0);
            this.tableLayoutPanel_errorBits.Controls.Add(this.errorBit1, 0, 0);
            this.tableLayoutPanel_errorBits.Location = new System.Drawing.Point(-3, 141);
            this.tableLayoutPanel_errorBits.Name = "tableLayoutPanel_errorBits";
            this.tableLayoutPanel_errorBits.RowCount = 1;
            this.tableLayoutPanel_errorBits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_errorBits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel_errorBits.Size = new System.Drawing.Size(217, 29);
            this.tableLayoutPanel_errorBits.TabIndex = 3;
            // 
            // errorBit5
            // 
            this.errorBit5.AutoSize = true;
            this.errorBit5.BackColor = System.Drawing.Color.Lime;
            this.errorBit5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorBit5.Location = new System.Drawing.Point(175, 3);
            this.errorBit5.Margin = new System.Windows.Forms.Padding(3);
            this.errorBit5.Name = "errorBit5";
            this.errorBit5.Size = new System.Drawing.Size(39, 23);
            this.errorBit5.TabIndex = 4;
            this.errorBit5.Text = "5";
            this.errorBit5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorBit4
            // 
            this.errorBit4.AutoSize = true;
            this.errorBit4.BackColor = System.Drawing.Color.Red;
            this.errorBit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorBit4.Location = new System.Drawing.Point(132, 3);
            this.errorBit4.Margin = new System.Windows.Forms.Padding(3);
            this.errorBit4.Name = "errorBit4";
            this.errorBit4.Size = new System.Drawing.Size(37, 23);
            this.errorBit4.TabIndex = 3;
            this.errorBit4.Text = "4";
            this.errorBit4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorBit3
            // 
            this.errorBit3.AutoSize = true;
            this.errorBit3.BackColor = System.Drawing.Color.Lime;
            this.errorBit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorBit3.Location = new System.Drawing.Point(89, 3);
            this.errorBit3.Margin = new System.Windows.Forms.Padding(3);
            this.errorBit3.Name = "errorBit3";
            this.errorBit3.Size = new System.Drawing.Size(37, 23);
            this.errorBit3.TabIndex = 2;
            this.errorBit3.Text = "3";
            this.errorBit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorBit2
            // 
            this.errorBit2.AutoSize = true;
            this.errorBit2.BackColor = System.Drawing.Color.Lime;
            this.errorBit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorBit2.Location = new System.Drawing.Point(46, 3);
            this.errorBit2.Margin = new System.Windows.Forms.Padding(3);
            this.errorBit2.Name = "errorBit2";
            this.errorBit2.Size = new System.Drawing.Size(37, 23);
            this.errorBit2.TabIndex = 1;
            this.errorBit2.Text = "2";
            this.errorBit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorBit1
            // 
            this.errorBit1.AutoSize = true;
            this.errorBit1.BackColor = System.Drawing.Color.Red;
            this.errorBit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorBit1.Location = new System.Drawing.Point(3, 3);
            this.errorBit1.Margin = new System.Windows.Forms.Padding(3);
            this.errorBit1.Name = "errorBit1";
            this.errorBit1.Size = new System.Drawing.Size(37, 23);
            this.errorBit1.TabIndex = 0;
            this.errorBit1.Text = "1";
            this.errorBit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_errors
            // 
            this.label_errors.AutoSize = true;
            this.label_errors.Location = new System.Drawing.Point(-2, 73);
            this.label_errors.Name = "label_errors";
            this.label_errors.Size = new System.Drawing.Size(208, 65);
            this.label_errors.TabIndex = 2;
            this.label_errors.Text = resources.GetString("label_errors.Text");
            // 
            // button_MANUAL_DEPLOY
            // 
            this.button_MANUAL_DEPLOY.BackColor = System.Drawing.Color.Red;
            this.button_MANUAL_DEPLOY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MANUAL_DEPLOY.Location = new System.Drawing.Point(125, -3);
            this.button_MANUAL_DEPLOY.Name = "button_MANUAL_DEPLOY";
            this.button_MANUAL_DEPLOY.Size = new System.Drawing.Size(89, 69);
            this.button_MANUAL_DEPLOY.TabIndex = 1;
            this.button_MANUAL_DEPLOY.Text = "MANUAL\r\nDEPLOY";
            this.button_MANUAL_DEPLOY.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel_dateTime
            // 
            this.tableLayoutPanel_dateTime.ColumnCount = 1;
            this.tableLayoutPanel_dateTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dateTime.Controls.Add(this.label_currentTime, 0, 1);
            this.tableLayoutPanel_dateTime.Controls.Add(this.label_currentDate, 0, 0);
            this.tableLayoutPanel_dateTime.Location = new System.Drawing.Point(-3, -3);
            this.tableLayoutPanel_dateTime.Name = "tableLayoutPanel_dateTime";
            this.tableLayoutPanel_dateTime.RowCount = 2;
            this.tableLayoutPanel_dateTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dateTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dateTime.Size = new System.Drawing.Size(125, 69);
            this.tableLayoutPanel_dateTime.TabIndex = 0;
            // 
            // label_currentTime
            // 
            this.label_currentTime.AutoSize = true;
            this.label_currentTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_currentTime.Location = new System.Drawing.Point(3, 34);
            this.label_currentTime.Name = "label_currentTime";
            this.label_currentTime.Size = new System.Drawing.Size(119, 35);
            this.label_currentTime.TabIndex = 1;
            this.label_currentTime.Text = "15:04:23";
            this.label_currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_currentDate
            // 
            this.label_currentDate.AutoSize = true;
            this.label_currentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_currentDate.Location = new System.Drawing.Point(3, 0);
            this.label_currentDate.Name = "label_currentDate";
            this.label_currentDate.Size = new System.Drawing.Size(119, 34);
            this.label_currentDate.TabIndex = 0;
            this.label_currentDate.Text = "22.01.2023";
            this.label_currentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_videoRecordTime
            // 
            this.timer_videoRecordTime.Interval = 1000;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_telemetryTable);
            this.tabControl1.Controls.Add(tabPage_serialMonitor);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1304, 191);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage_telemetryTable
            // 
            this.tabPage_telemetryTable.Controls.Add(this.dataGridView_telemetryDataTable);
            this.tabPage_telemetryTable.Location = new System.Drawing.Point(4, 22);
            this.tabPage_telemetryTable.Name = "tabPage_telemetryTable";
            this.tabPage_telemetryTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_telemetryTable.Size = new System.Drawing.Size(1296, 165);
            this.tabPage_telemetryTable.TabIndex = 0;
            this.tabPage_telemetryTable.Text = "Telemetry Table";
            this.tabPage_telemetryTable.UseVisualStyleBackColor = true;
            // 
            // dataGridView_telemetryDataTable
            // 
            this.dataGridView_telemetryDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_telemetryDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_telemetryDataTable.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_telemetryDataTable.Name = "dataGridView_telemetryDataTable";
            this.dataGridView_telemetryDataTable.Size = new System.Drawing.Size(1290, 159);
            this.dataGridView_telemetryDataTable.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.tabControl1);
            this.panel7.Location = new System.Drawing.Point(237, 637);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1306, 193);
            this.panel7.TabIndex = 19;
            // 
            // tableLayoutPanel_views
            // 
            this.tableLayoutPanel_views.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_views.ColumnCount = 2;
            this.tableLayoutPanel_views.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_views.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel_views.Controls.Add(this.panel_views4, 1, 1);
            this.tableLayoutPanel_views.Controls.Add(this.panel_views3, 0, 1);
            this.tableLayoutPanel_views.Controls.Add(this.panel_views1, 0, 0);
            this.tableLayoutPanel_views.Controls.Add(this.panel_views2, 1, 0);
            this.tableLayoutPanel_views.Location = new System.Drawing.Point(237, 6);
            this.tableLayoutPanel_views.Name = "tableLayoutPanel_views";
            this.tableLayoutPanel_views.RowCount = 2;
            this.tableLayoutPanel_views.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_views.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel_views.Size = new System.Drawing.Size(1302, 625);
            this.tableLayoutPanel_views.TabIndex = 20;
            // 
            // panel_views3
            // 
            this.panel_views3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_views3.Controls.Add(this.tableLayoutPanel9);
            this.panel_views3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_views3.Location = new System.Drawing.Point(0, 375);
            this.panel_views3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel_views3.Name = "panel_views3";
            this.panel_views3.Size = new System.Drawing.Size(582, 250);
            this.panel_views3.TabIndex = 31;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.chromiumWebBrowser1, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(-3, -3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(580, 242);
            this.tableLayoutPanel9.TabIndex = 18;
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(4, 4);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(572, 234);
            this.chromiumWebBrowser1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.tableLayoutPanel_views);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabPage_serialMonitor.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_saveDatasConfig.ResumeLayout(false);
            this.groupBox_saveDatasConfig.PerformLayout();
            this.panel_views2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel_mainInformation.ResumeLayout(false);
            this.tableLayoutPanel_mainInformation.PerformLayout();
            this.panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_camera.ResumeLayout(false);
            this.panel_views1.ResumeLayout(false);
            this.panel_views4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel_errorBits.ResumeLayout(false);
            this.tableLayoutPanel_errorBits.PerformLayout();
            this.tableLayoutPanel_dateTime.ResumeLayout(false);
            this.tableLayoutPanel_dateTime.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_telemetryTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_telemetryDataTable)).EndInit();
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel_views.ResumeLayout(false);
            this.panel_views3.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_refreshCOMPortV;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox_baudRateVideoTransfer;
        private System.Windows.Forms.ComboBox comboBox_COMPortVideoTransfer;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_refreshCOMPort;
        private System.Windows.Forms.Button button_telemetryCOMPortOpenClose;
        private System.Windows.Forms.ComboBox comboBox_baudRateTelemetry;
        private System.Windows.Forms.ComboBox comboBox_COMPortTelemetry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_status;
        private System.Windows.Forms.Label label_status07;
        private System.Windows.Forms.Label label_status05;
        private System.Windows.Forms.Label label_status06;
        private System.Windows.Forms.Label label_status04;
        private System.Windows.Forms.Label label_status03;
        private System.Windows.Forms.Label label_status02;
        private System.Windows.Forms.Label label_status01;
        private System.Windows.Forms.Label label_status00;
        private System.Windows.Forms.GroupBox groupBox_saveDatasConfig;
        private System.Windows.Forms.Label label_sdCardFileSize;
        private System.Windows.Forms.Label label_localFileSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_saveData;
        private System.Windows.Forms.Button button_browseSdCardFolder;
        private System.Windows.Forms.TextBox textBox_sdCardFolderPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_browseLocalFolder;
        private System.Windows.Forms.TextBox textBox_localFolderPath;
        private System.Windows.Forms.Label label_teamID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel_views2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_charts;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel recordInformationLed;
        private System.Windows.Forms.Label label_videoRecordTime;
        private System.Windows.Forms.Button button_browseVideoFolderToSave;
        private System.Windows.Forms.TextBox textBox_videoFolderToSave;
        private System.Windows.Forms.ComboBox comboBox_chooseCamera;
        private System.Windows.Forms.ProgressBar progressBar_sendVideo;
        private System.Windows.Forms.Button button_browseVideoFileToSend;
        private System.Windows.Forms.TextBox textBox_videoPathToSend;
        private System.Windows.Forms.Button button_sendVideo;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button button_recordStartStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_mainInformation;
        private System.Windows.Forms.Label label_packageNo;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button button_cameraOpenClose;
        private System.Windows.Forms.PictureBox pictureBox_camera;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_camera;
        private System.Windows.Forms.Panel panel_views1;
        private System.Windows.Forms.Panel panel_views4;
        private System.Windows.Forms.Label label_payloadYaw;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_payloadRoll;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label_payloadPitch;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label_payloadBataryVoltage;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label_payloadTemperature;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_payloadVelocity;
        private System.Windows.Forms.Label label_payloadGPSLongitude;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_payloadGPSLatitude;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_payloadGPSAltitude;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_payloadAltitude;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_payloadPressure;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_errorBits;
        private System.Windows.Forms.Label errorBit5;
        private System.Windows.Forms.Label errorBit4;
        private System.Windows.Forms.Label errorBit3;
        private System.Windows.Forms.Label errorBit2;
        private System.Windows.Forms.Label errorBit1;
        private System.Windows.Forms.Label label_errors;
        private System.Windows.Forms.Button button_MANUAL_DEPLOY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_dateTime;
        private System.Windows.Forms.Label label_currentTime;
        private System.Windows.Forms.Label label_currentDate;
        private System.Windows.Forms.Timer timer_videoRecordTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker_telemetryData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TextBox textBox_logs;
        private System.Windows.Forms.Label text_Logs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_telemetryTable;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_views;
        private System.Windows.Forms.ListBox serialMonitorListBox;
        private System.Windows.Forms.DataGridView dataGridView_telemetryDataTable;
        private System.Windows.Forms.Label label_uyduStatus;
        private System.Windows.Forms.Label label_hataKod;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label_containerAltitude;
        private System.Windows.Forms.Label label_containerPressure;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label_AltitudeDiff;
        private System.Windows.Forms.Panel panel_views3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
    }
}

