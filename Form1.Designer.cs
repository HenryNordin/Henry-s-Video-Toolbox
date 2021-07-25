namespace ffmpegUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileselectBTN = new System.Windows.Forms.Button();
            this.fileTBX = new System.Windows.Forms.TextBox();
            this.resolutionCB1 = new System.Windows.Forms.ComboBox();
            this.resolutionLBL = new System.Windows.Forms.Label();
            this.ResCheckB = new System.Windows.Forms.CheckBox();
            this.AspectRatioCheckB = new System.Windows.Forms.CheckBox();
            this.AspectRatioLBL = new System.Windows.Forms.Label();
            this.AspectRatioCB1 = new System.Windows.Forms.ComboBox();
            this.DeinterlaceCheckB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deinterlaceCB1 = new System.Windows.Forms.ComboBox();
            this.FPSCheckB = new System.Windows.Forms.CheckBox();
            this.FPSLBL = new System.Windows.Forms.Label();
            this.FPSCB1 = new System.Windows.Forms.ComboBox();
            this.crfCheckB = new System.Windows.Forms.CheckBox();
            this.crfLBL = new System.Windows.Forms.Label();
            this.crfCB1 = new System.Windows.Forms.ComboBox();
            this.PresetCheckB = new System.Windows.Forms.CheckBox();
            this.PresetLBL = new System.Windows.Forms.Label();
            this.PresetCB1 = new System.Windows.Forms.ComboBox();
            this.MaxrateLBL = new System.Windows.Forms.Label();
            this.MaxrateCB1 = new System.Windows.Forms.ComboBox();
            this.BufsizeLBL = new System.Windows.Forms.Label();
            this.BufSizeCB1 = new System.Windows.Forms.ComboBox();
            this.BufsizeCheckB = new System.Windows.Forms.CheckBox();
            this.MaxrateCheckB = new System.Windows.Forms.CheckBox();
            this.ProfileCheckB = new System.Windows.Forms.CheckBox();
            this.ProfileLBL = new System.Windows.Forms.Label();
            this.ProfileCB1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VencodCB1 = new System.Windows.Forms.ComboBox();
            this.PresetSelectCB1 = new System.Windows.Forms.ComboBox();
            this.BtnChoosePreset = new System.Windows.Forms.Button();
            this.FileEXTCB1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FileNameOutputTBX = new System.Windows.Forms.TextBox();
            this.DestinationBTN = new System.Windows.Forms.Button();
            this.OutputNameTBX = new System.Windows.Forms.TextBox();
            this.btnDEBUG = new System.Windows.Forms.Button();
            this.LevelCheckB = new System.Windows.Forms.CheckBox();
            this.LevelLBL = new System.Windows.Forms.Label();
            this.LevelCB1 = new System.Windows.Forms.ComboBox();
            this.AudioBitrateCheckB = new System.Windows.Forms.CheckBox();
            this.AudioBitrateLBL = new System.Windows.Forms.Label();
            this.AudioBitrateCB1 = new System.Windows.Forms.ComboBox();
            this.AudioKbps = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CropCheckB = new System.Windows.Forms.CheckBox();
            this.lblCrop = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CropXSizeTBX = new System.Windows.Forms.TextBox();
            this.CropYSizeTBX = new System.Windows.Forms.TextBox();
            this.CropXLocationTBX = new System.Windows.Forms.TextBox();
            this.CropYLocationTBX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VideoKbps = new System.Windows.Forms.Label();
            this.VideoBitrateCheckB = new System.Windows.Forms.CheckBox();
            this.VideoBitrateLBL = new System.Windows.Forms.Label();
            this.VideoBitrateCB1 = new System.Windows.Forms.ComboBox();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnLOAD = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.FinterpolateCheckB = new System.Windows.Forms.CheckBox();
            this.FinterpolateLBL = new System.Windows.Forms.Label();
            this.FinterpolateCB1 = new System.Windows.Forms.ComboBox();
            this.quickLBL = new System.Windows.Forms.Label();
            this.VideoProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnRUN = new System.Windows.Forms.Button();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.OUTPUTTBX = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblFullTime = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.btnExportPreset = new System.Windows.Forms.Button();
            this.btnDeletePreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileselectBTN
            // 
            this.fileselectBTN.Location = new System.Drawing.Point(412, 14);
            this.fileselectBTN.Margin = new System.Windows.Forms.Padding(4);
            this.fileselectBTN.Name = "fileselectBTN";
            this.fileselectBTN.Size = new System.Drawing.Size(91, 25);
            this.fileselectBTN.TabIndex = 0;
            this.fileselectBTN.Text = "Select file";
            this.fileselectBTN.UseVisualStyleBackColor = true;
            this.fileselectBTN.Click += new System.EventHandler(this.fileselectBTN_Click);
            // 
            // fileTBX
            // 
            this.fileTBX.AllowDrop = true;
            this.fileTBX.Location = new System.Drawing.Point(16, 15);
            this.fileTBX.Margin = new System.Windows.Forms.Padding(4);
            this.fileTBX.Name = "fileTBX";
            this.fileTBX.Size = new System.Drawing.Size(395, 22);
            this.fileTBX.TabIndex = 1;
            this.fileTBX.Text = "C:\\";
            this.fileTBX.TextChanged += new System.EventHandler(this.fileTBX_TextChanged);
            this.fileTBX.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileTBX_DragDrop);
            this.fileTBX.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileTBX_DragEnter);
            // 
            // resolutionCB1
            // 
            this.resolutionCB1.FormattingEnabled = true;
            this.resolutionCB1.Location = new System.Drawing.Point(527, 115);
            this.resolutionCB1.Margin = new System.Windows.Forms.Padding(4);
            this.resolutionCB1.Name = "resolutionCB1";
            this.resolutionCB1.Size = new System.Drawing.Size(108, 24);
            this.resolutionCB1.TabIndex = 3;
            this.resolutionCB1.SelectedIndexChanged += new System.EventHandler(this.resolutionCB1_SelectedIndexChanged);
            // 
            // resolutionLBL
            // 
            this.resolutionLBL.AutoSize = true;
            this.resolutionLBL.Location = new System.Drawing.Point(498, 96);
            this.resolutionLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resolutionLBL.Name = "resolutionLBL";
            this.resolutionLBL.Size = new System.Drawing.Size(75, 17);
            this.resolutionLBL.TabIndex = 4;
            this.resolutionLBL.Text = "Resolution";
            // 
            // ResCheckB
            // 
            this.ResCheckB.AutoSize = true;
            this.ResCheckB.Location = new System.Drawing.Point(502, 118);
            this.ResCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.ResCheckB.Name = "ResCheckB";
            this.ResCheckB.Size = new System.Drawing.Size(18, 17);
            this.ResCheckB.TabIndex = 5;
            this.ResCheckB.UseVisualStyleBackColor = true;
            this.ResCheckB.CheckedChanged += new System.EventHandler(this.ResCheckB_CheckedChanged);
            // 
            // AspectRatioCheckB
            // 
            this.AspectRatioCheckB.AutoSize = true;
            this.AspectRatioCheckB.Location = new System.Drawing.Point(502, 171);
            this.AspectRatioCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.AspectRatioCheckB.Name = "AspectRatioCheckB";
            this.AspectRatioCheckB.Size = new System.Drawing.Size(18, 17);
            this.AspectRatioCheckB.TabIndex = 8;
            this.AspectRatioCheckB.UseVisualStyleBackColor = true;
            this.AspectRatioCheckB.CheckedChanged += new System.EventHandler(this.AspectRatioCheckB_CheckedChanged);
            // 
            // AspectRatioLBL
            // 
            this.AspectRatioLBL.AutoSize = true;
            this.AspectRatioLBL.Location = new System.Drawing.Point(498, 149);
            this.AspectRatioLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AspectRatioLBL.Name = "AspectRatioLBL";
            this.AspectRatioLBL.Size = new System.Drawing.Size(88, 17);
            this.AspectRatioLBL.TabIndex = 7;
            this.AspectRatioLBL.Text = "Aspect Ratio";
            // 
            // AspectRatioCB1
            // 
            this.AspectRatioCB1.FormattingEnabled = true;
            this.AspectRatioCB1.Items.AddRange(new object[] {
            "4:3",
            "16:9",
            "16:10"});
            this.AspectRatioCB1.Location = new System.Drawing.Point(527, 167);
            this.AspectRatioCB1.Margin = new System.Windows.Forms.Padding(4);
            this.AspectRatioCB1.Name = "AspectRatioCB1";
            this.AspectRatioCB1.Size = new System.Drawing.Size(108, 24);
            this.AspectRatioCB1.TabIndex = 6;
            // 
            // DeinterlaceCheckB
            // 
            this.DeinterlaceCheckB.AutoSize = true;
            this.DeinterlaceCheckB.Location = new System.Drawing.Point(659, 118);
            this.DeinterlaceCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.DeinterlaceCheckB.Name = "DeinterlaceCheckB";
            this.DeinterlaceCheckB.Size = new System.Drawing.Size(18, 17);
            this.DeinterlaceCheckB.TabIndex = 11;
            this.DeinterlaceCheckB.UseVisualStyleBackColor = true;
            this.DeinterlaceCheckB.CheckedChanged += new System.EventHandler(this.DeinterlaceCheckB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Deinterlace";
            // 
            // deinterlaceCB1
            // 
            this.deinterlaceCB1.FormattingEnabled = true;
            this.deinterlaceCB1.Items.AddRange(new object[] {
            "yadif",
            "yadif=1",
            "bwdif",
            "bwdif=1"});
            this.deinterlaceCB1.Location = new System.Drawing.Point(685, 115);
            this.deinterlaceCB1.Margin = new System.Windows.Forms.Padding(4);
            this.deinterlaceCB1.Name = "deinterlaceCB1";
            this.deinterlaceCB1.Size = new System.Drawing.Size(108, 24);
            this.deinterlaceCB1.TabIndex = 9;
            this.deinterlaceCB1.TabStop = false;
            // 
            // FPSCheckB
            // 
            this.FPSCheckB.AutoSize = true;
            this.FPSCheckB.Location = new System.Drawing.Point(659, 171);
            this.FPSCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.FPSCheckB.Name = "FPSCheckB";
            this.FPSCheckB.Size = new System.Drawing.Size(18, 17);
            this.FPSCheckB.TabIndex = 14;
            this.FPSCheckB.UseVisualStyleBackColor = true;
            this.FPSCheckB.CheckedChanged += new System.EventHandler(this.FPSCheckB_CheckedChanged);
            // 
            // FPSLBL
            // 
            this.FPSLBL.AutoSize = true;
            this.FPSLBL.Location = new System.Drawing.Point(655, 149);
            this.FPSLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FPSLBL.Name = "FPSLBL";
            this.FPSLBL.Size = new System.Drawing.Size(73, 17);
            this.FPSLBL.TabIndex = 13;
            this.FPSLBL.Text = "Framerate";
            // 
            // FPSCB1
            // 
            this.FPSCB1.FormattingEnabled = true;
            this.FPSCB1.Items.AddRange(new object[] {
            "25",
            "30",
            "50",
            "60"});
            this.FPSCB1.Location = new System.Drawing.Point(685, 167);
            this.FPSCB1.Margin = new System.Windows.Forms.Padding(4);
            this.FPSCB1.Name = "FPSCB1";
            this.FPSCB1.Size = new System.Drawing.Size(108, 24);
            this.FPSCB1.TabIndex = 12;
            // 
            // crfCheckB
            // 
            this.crfCheckB.AutoSize = true;
            this.crfCheckB.Location = new System.Drawing.Point(21, 117);
            this.crfCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.crfCheckB.Name = "crfCheckB";
            this.crfCheckB.Size = new System.Drawing.Size(18, 17);
            this.crfCheckB.TabIndex = 17;
            this.crfCheckB.UseVisualStyleBackColor = true;
            this.crfCheckB.CheckedChanged += new System.EventHandler(this.crfCheckB_CheckedChanged);
            // 
            // crfLBL
            // 
            this.crfLBL.AutoSize = true;
            this.crfLBL.Location = new System.Drawing.Point(17, 95);
            this.crfLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crfLBL.Name = "crfLBL";
            this.crfLBL.Size = new System.Drawing.Size(24, 17);
            this.crfLBL.TabIndex = 16;
            this.crfLBL.Text = "crf";
            // 
            // crfCB1
            // 
            this.crfCB1.FormattingEnabled = true;
            this.crfCB1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.crfCB1.Location = new System.Drawing.Point(47, 113);
            this.crfCB1.Margin = new System.Windows.Forms.Padding(4);
            this.crfCB1.Name = "crfCB1";
            this.crfCB1.Size = new System.Drawing.Size(60, 24);
            this.crfCB1.TabIndex = 15;
            // 
            // PresetCheckB
            // 
            this.PresetCheckB.AutoSize = true;
            this.PresetCheckB.Location = new System.Drawing.Point(16, 406);
            this.PresetCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.PresetCheckB.Name = "PresetCheckB";
            this.PresetCheckB.Size = new System.Drawing.Size(18, 17);
            this.PresetCheckB.TabIndex = 20;
            this.PresetCheckB.UseVisualStyleBackColor = true;
            this.PresetCheckB.CheckedChanged += new System.EventHandler(this.PresetCheckB_CheckedChanged);
            // 
            // PresetLBL
            // 
            this.PresetLBL.AutoSize = true;
            this.PresetLBL.Location = new System.Drawing.Point(12, 383);
            this.PresetLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PresetLBL.Name = "PresetLBL";
            this.PresetLBL.Size = new System.Drawing.Size(49, 17);
            this.PresetLBL.TabIndex = 19;
            this.PresetLBL.Text = "Preset";
            // 
            // PresetCB1
            // 
            this.PresetCB1.FormattingEnabled = true;
            this.PresetCB1.Items.AddRange(new object[] {
            "placebo",
            "veryslow",
            "slower",
            "slow",
            "medium",
            "fast",
            "faster",
            "veryfast",
            "superfast",
            "ultrafast"});
            this.PresetCB1.Location = new System.Drawing.Point(42, 402);
            this.PresetCB1.Margin = new System.Windows.Forms.Padding(4);
            this.PresetCB1.Name = "PresetCB1";
            this.PresetCB1.Size = new System.Drawing.Size(87, 24);
            this.PresetCB1.TabIndex = 18;
            this.PresetCB1.Text = "superfast";
            // 
            // MaxrateLBL
            // 
            this.MaxrateLBL.AutoSize = true;
            this.MaxrateLBL.Location = new System.Drawing.Point(17, 145);
            this.MaxrateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxrateLBL.Name = "MaxrateLBL";
            this.MaxrateLBL.Size = new System.Drawing.Size(58, 17);
            this.MaxrateLBL.TabIndex = 22;
            this.MaxrateLBL.Text = "Maxrate";
            // 
            // MaxrateCB1
            // 
            this.MaxrateCB1.FormattingEnabled = true;
            this.MaxrateCB1.Items.AddRange(new object[] {
            "10M",
            "15M",
            "20M"});
            this.MaxrateCB1.Location = new System.Drawing.Point(47, 164);
            this.MaxrateCB1.Margin = new System.Windows.Forms.Padding(4);
            this.MaxrateCB1.Name = "MaxrateCB1";
            this.MaxrateCB1.Size = new System.Drawing.Size(60, 24);
            this.MaxrateCB1.TabIndex = 21;
            // 
            // BufsizeLBL
            // 
            this.BufsizeLBL.AutoSize = true;
            this.BufsizeLBL.Location = new System.Drawing.Point(17, 197);
            this.BufsizeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BufsizeLBL.Name = "BufsizeLBL";
            this.BufsizeLBL.Size = new System.Drawing.Size(56, 17);
            this.BufsizeLBL.TabIndex = 24;
            this.BufsizeLBL.Text = "BufSize";
            // 
            // BufSizeCB1
            // 
            this.BufSizeCB1.FormattingEnabled = true;
            this.BufSizeCB1.Items.AddRange(new object[] {
            "10M",
            "15M",
            "20M"});
            this.BufSizeCB1.Location = new System.Drawing.Point(47, 215);
            this.BufSizeCB1.Margin = new System.Windows.Forms.Padding(4);
            this.BufSizeCB1.Name = "BufSizeCB1";
            this.BufSizeCB1.Size = new System.Drawing.Size(60, 24);
            this.BufSizeCB1.TabIndex = 23;
            // 
            // BufsizeCheckB
            // 
            this.BufsizeCheckB.AutoSize = true;
            this.BufsizeCheckB.Location = new System.Drawing.Point(21, 219);
            this.BufsizeCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.BufsizeCheckB.Name = "BufsizeCheckB";
            this.BufsizeCheckB.Size = new System.Drawing.Size(18, 17);
            this.BufsizeCheckB.TabIndex = 25;
            this.BufsizeCheckB.UseVisualStyleBackColor = true;
            this.BufsizeCheckB.CheckedChanged += new System.EventHandler(this.BufsizeCheckB_CheckedChanged);
            // 
            // MaxrateCheckB
            // 
            this.MaxrateCheckB.AutoSize = true;
            this.MaxrateCheckB.Location = new System.Drawing.Point(21, 167);
            this.MaxrateCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.MaxrateCheckB.Name = "MaxrateCheckB";
            this.MaxrateCheckB.Size = new System.Drawing.Size(18, 17);
            this.MaxrateCheckB.TabIndex = 26;
            this.MaxrateCheckB.UseVisualStyleBackColor = true;
            this.MaxrateCheckB.CheckedChanged += new System.EventHandler(this.MaxrateCheckB_CheckedChanged);
            // 
            // ProfileCheckB
            // 
            this.ProfileCheckB.AutoSize = true;
            this.ProfileCheckB.Location = new System.Drawing.Point(139, 406);
            this.ProfileCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileCheckB.Name = "ProfileCheckB";
            this.ProfileCheckB.Size = new System.Drawing.Size(18, 17);
            this.ProfileCheckB.TabIndex = 29;
            this.ProfileCheckB.UseVisualStyleBackColor = true;
            this.ProfileCheckB.CheckedChanged += new System.EventHandler(this.ProfileCheckB_CheckedChanged);
            // 
            // ProfileLBL
            // 
            this.ProfileLBL.AutoSize = true;
            this.ProfileLBL.Location = new System.Drawing.Point(135, 383);
            this.ProfileLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProfileLBL.Name = "ProfileLBL";
            this.ProfileLBL.Size = new System.Drawing.Size(48, 17);
            this.ProfileLBL.TabIndex = 28;
            this.ProfileLBL.Text = "Profile";
            // 
            // ProfileCB1
            // 
            this.ProfileCB1.FormattingEnabled = true;
            this.ProfileCB1.Items.AddRange(new object[] {
            "high",
            "main",
            "baseline"});
            this.ProfileCB1.Location = new System.Drawing.Point(164, 402);
            this.ProfileCB1.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileCB1.Name = "ProfileCB1";
            this.ProfileCB1.Size = new System.Drawing.Size(58, 24);
            this.ProfileCB1.TabIndex = 27;
            this.ProfileCB1.Text = "high";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Video Encoder";
            // 
            // VencodCB1
            // 
            this.VencodCB1.FormattingEnabled = true;
            this.VencodCB1.Items.AddRange(new object[] {
            "libx264",
            "libx265"});
            this.VencodCB1.Location = new System.Drawing.Point(388, 167);
            this.VencodCB1.Margin = new System.Windows.Forms.Padding(4);
            this.VencodCB1.Name = "VencodCB1";
            this.VencodCB1.Size = new System.Drawing.Size(80, 24);
            this.VencodCB1.TabIndex = 31;
            this.VencodCB1.Text = "libx264";
            // 
            // PresetSelectCB1
            // 
            this.PresetSelectCB1.FormattingEnabled = true;
            this.PresetSelectCB1.Location = new System.Drawing.Point(513, 13);
            this.PresetSelectCB1.Margin = new System.Windows.Forms.Padding(4);
            this.PresetSelectCB1.Name = "PresetSelectCB1";
            this.PresetSelectCB1.Size = new System.Drawing.Size(276, 24);
            this.PresetSelectCB1.TabIndex = 38;
            this.PresetSelectCB1.DropDown += new System.EventHandler(this.PresetSelectCB1_DropDown);
            // 
            // BtnChoosePreset
            // 
            this.BtnChoosePreset.Location = new System.Drawing.Point(704, 45);
            this.BtnChoosePreset.Margin = new System.Windows.Forms.Padding(4);
            this.BtnChoosePreset.Name = "BtnChoosePreset";
            this.BtnChoosePreset.Size = new System.Drawing.Size(85, 28);
            this.BtnChoosePreset.TabIndex = 39;
            this.BtnChoosePreset.Text = "Use preset";
            this.BtnChoosePreset.UseVisualStyleBackColor = true;
            this.BtnChoosePreset.Click += new System.EventHandler(this.BtnChoosePreset_Click);
            // 
            // FileEXTCB1
            // 
            this.FileEXTCB1.FormattingEnabled = true;
            this.FileEXTCB1.Items.AddRange(new object[] {
            ".mp4",
            ".mp3",
            ".mov",
            ".wmv",
            ".flv",
            ".avi",
            ".avchd",
            ".webm",
            ".mkv"});
            this.FileEXTCB1.Location = new System.Drawing.Point(688, 300);
            this.FileEXTCB1.Margin = new System.Windows.Forms.Padding(4);
            this.FileEXTCB1.Name = "FileEXTCB1";
            this.FileEXTCB1.Size = new System.Drawing.Size(105, 24);
            this.FileEXTCB1.TabIndex = 35;
            this.FileEXTCB1.Text = ".mp4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "File name";
            // 
            // FileNameOutputTBX
            // 
            this.FileNameOutputTBX.Location = new System.Drawing.Point(516, 301);
            this.FileNameOutputTBX.Margin = new System.Windows.Forms.Padding(4);
            this.FileNameOutputTBX.Name = "FileNameOutputTBX";
            this.FileNameOutputTBX.Size = new System.Drawing.Size(165, 22);
            this.FileNameOutputTBX.TabIndex = 34;
            this.FileNameOutputTBX.Text = "Export";
            // 
            // DestinationBTN
            // 
            this.DestinationBTN.Location = new System.Drawing.Point(688, 268);
            this.DestinationBTN.Margin = new System.Windows.Forms.Padding(4);
            this.DestinationBTN.Name = "DestinationBTN";
            this.DestinationBTN.Size = new System.Drawing.Size(107, 25);
            this.DestinationBTN.TabIndex = 33;
            this.DestinationBTN.Text = "Save location";
            this.DestinationBTN.UseVisualStyleBackColor = true;
            this.DestinationBTN.Click += new System.EventHandler(this.DestinationBTN_Click);
            // 
            // OutputNameTBX
            // 
            this.OutputNameTBX.Location = new System.Drawing.Point(428, 269);
            this.OutputNameTBX.Margin = new System.Windows.Forms.Padding(4);
            this.OutputNameTBX.Name = "OutputNameTBX";
            this.OutputNameTBX.Size = new System.Drawing.Size(253, 22);
            this.OutputNameTBX.TabIndex = 30;
            this.OutputNameTBX.Text = "C:\\";
            // 
            // btnDEBUG
            // 
            this.btnDEBUG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEBUG.Location = new System.Drawing.Point(824, 329);
            this.btnDEBUG.Margin = new System.Windows.Forms.Padding(4);
            this.btnDEBUG.Name = "btnDEBUG";
            this.btnDEBUG.Size = new System.Drawing.Size(70, 50);
            this.btnDEBUG.TabIndex = 2;
            this.btnDEBUG.Text = "OLD";
            this.btnDEBUG.UseVisualStyleBackColor = true;
            this.btnDEBUG.Click += new System.EventHandler(this.btnDEBUG_Click);
            // 
            // LevelCheckB
            // 
            this.LevelCheckB.AutoSize = true;
            this.LevelCheckB.Location = new System.Drawing.Point(230, 406);
            this.LevelCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.LevelCheckB.Name = "LevelCheckB";
            this.LevelCheckB.Size = new System.Drawing.Size(18, 17);
            this.LevelCheckB.TabIndex = 43;
            this.LevelCheckB.UseVisualStyleBackColor = true;
            this.LevelCheckB.CheckedChanged += new System.EventHandler(this.LevelCheckB_CheckedChanged);
            // 
            // LevelLBL
            // 
            this.LevelLBL.AutoSize = true;
            this.LevelLBL.Location = new System.Drawing.Point(226, 383);
            this.LevelLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelLBL.Name = "LevelLBL";
            this.LevelLBL.Size = new System.Drawing.Size(42, 17);
            this.LevelLBL.TabIndex = 42;
            this.LevelLBL.Text = "Level";
            // 
            // LevelCB1
            // 
            this.LevelCB1.FormattingEnabled = true;
            this.LevelCB1.Items.AddRange(new object[] {
            "5.1",
            "5",
            "4.2",
            "4.1",
            "4",
            "3.2",
            "3.1",
            "3",
            "2.2",
            "2.1",
            "2",
            "1.3",
            "1.2",
            "1.1",
            "1b",
            "1"});
            this.LevelCB1.Location = new System.Drawing.Point(255, 402);
            this.LevelCB1.Margin = new System.Windows.Forms.Padding(4);
            this.LevelCB1.Name = "LevelCB1";
            this.LevelCB1.Size = new System.Drawing.Size(63, 24);
            this.LevelCB1.TabIndex = 41;
            this.LevelCB1.Text = "4.2";
            // 
            // AudioBitrateCheckB
            // 
            this.AudioBitrateCheckB.AutoSize = true;
            this.AudioBitrateCheckB.Location = new System.Drawing.Point(259, 119);
            this.AudioBitrateCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.AudioBitrateCheckB.Name = "AudioBitrateCheckB";
            this.AudioBitrateCheckB.Size = new System.Drawing.Size(18, 17);
            this.AudioBitrateCheckB.TabIndex = 46;
            this.AudioBitrateCheckB.UseVisualStyleBackColor = true;
            this.AudioBitrateCheckB.CheckedChanged += new System.EventHandler(this.AudioBitrateCheckB_CheckedChanged);
            // 
            // AudioBitrateLBL
            // 
            this.AudioBitrateLBL.AutoSize = true;
            this.AudioBitrateLBL.Location = new System.Drawing.Point(255, 97);
            this.AudioBitrateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AudioBitrateLBL.Name = "AudioBitrateLBL";
            this.AudioBitrateLBL.Size = new System.Drawing.Size(88, 17);
            this.AudioBitrateLBL.TabIndex = 45;
            this.AudioBitrateLBL.Text = "Audio bitrate";
            // 
            // AudioBitrateCB1
            // 
            this.AudioBitrateCB1.FormattingEnabled = true;
            this.AudioBitrateCB1.Items.AddRange(new object[] {
            "64",
            "96",
            "112",
            "128",
            "160",
            "192",
            "256",
            "320"});
            this.AudioBitrateCB1.Location = new System.Drawing.Point(284, 115);
            this.AudioBitrateCB1.Margin = new System.Windows.Forms.Padding(4);
            this.AudioBitrateCB1.Name = "AudioBitrateCB1";
            this.AudioBitrateCB1.Size = new System.Drawing.Size(55, 24);
            this.AudioBitrateCB1.TabIndex = 44;
            this.AudioBitrateCB1.Text = "128";
            // 
            // AudioKbps
            // 
            this.AudioKbps.AutoSize = true;
            this.AudioKbps.Location = new System.Drawing.Point(341, 119);
            this.AudioKbps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AudioKbps.Name = "AudioKbps";
            this.AudioKbps.Size = new System.Drawing.Size(38, 17);
            this.AudioKbps.TabIndex = 47;
            this.AudioKbps.Text = "kbps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Audio Encoder";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "mp3"});
            this.comboBox1.Location = new System.Drawing.Point(388, 115);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 24);
            this.comboBox1.TabIndex = 48;
            // 
            // CropCheckB
            // 
            this.CropCheckB.AutoSize = true;
            this.CropCheckB.Location = new System.Drawing.Point(17, 302);
            this.CropCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.CropCheckB.Name = "CropCheckB";
            this.CropCheckB.Size = new System.Drawing.Size(18, 17);
            this.CropCheckB.TabIndex = 52;
            this.CropCheckB.UseVisualStyleBackColor = true;
            this.CropCheckB.CheckedChanged += new System.EventHandler(this.CropCheckB_CheckedChanged);
            // 
            // lblCrop
            // 
            this.lblCrop.AutoSize = true;
            this.lblCrop.Location = new System.Drawing.Point(13, 279);
            this.lblCrop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrop.Name = "lblCrop";
            this.lblCrop.Size = new System.Drawing.Size(38, 17);
            this.lblCrop.TabIndex = 51;
            this.lblCrop.Text = "Crop";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.comboBox2.Location = new System.Drawing.Point(917, 197);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 24);
            this.comboBox2.TabIndex = 50;
            // 
            // CropXSizeTBX
            // 
            this.CropXSizeTBX.Location = new System.Drawing.Point(85, 297);
            this.CropXSizeTBX.Margin = new System.Windows.Forms.Padding(4);
            this.CropXSizeTBX.Name = "CropXSizeTBX";
            this.CropXSizeTBX.Size = new System.Drawing.Size(65, 22);
            this.CropXSizeTBX.TabIndex = 53;
            // 
            // CropYSizeTBX
            // 
            this.CropYSizeTBX.Location = new System.Drawing.Point(85, 329);
            this.CropYSizeTBX.Margin = new System.Windows.Forms.Padding(4);
            this.CropYSizeTBX.Name = "CropYSizeTBX";
            this.CropYSizeTBX.Size = new System.Drawing.Size(65, 22);
            this.CropYSizeTBX.TabIndex = 54;
            // 
            // CropXLocationTBX
            // 
            this.CropXLocationTBX.Location = new System.Drawing.Point(225, 297);
            this.CropXLocationTBX.Margin = new System.Windows.Forms.Padding(4);
            this.CropXLocationTBX.Name = "CropXLocationTBX";
            this.CropXLocationTBX.Size = new System.Drawing.Size(63, 22);
            this.CropXLocationTBX.TabIndex = 55;
            // 
            // CropYLocationTBX
            // 
            this.CropYLocationTBX.Location = new System.Drawing.Point(225, 329);
            this.CropYLocationTBX.Margin = new System.Windows.Forms.Padding(4);
            this.CropYLocationTBX.Name = "CropYLocationTBX";
            this.CropYLocationTBX.Size = new System.Drawing.Size(63, 22);
            this.CropYLocationTBX.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "X size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Y size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 329);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Y position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 302);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "X position";
            // 
            // VideoKbps
            // 
            this.VideoKbps.AutoSize = true;
            this.VideoKbps.Location = new System.Drawing.Point(341, 172);
            this.VideoKbps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VideoKbps.Name = "VideoKbps";
            this.VideoKbps.Size = new System.Drawing.Size(42, 17);
            this.VideoKbps.TabIndex = 64;
            this.VideoKbps.Text = "mbps";
            // 
            // VideoBitrateCheckB
            // 
            this.VideoBitrateCheckB.AutoSize = true;
            this.VideoBitrateCheckB.Location = new System.Drawing.Point(259, 172);
            this.VideoBitrateCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.VideoBitrateCheckB.Name = "VideoBitrateCheckB";
            this.VideoBitrateCheckB.Size = new System.Drawing.Size(18, 17);
            this.VideoBitrateCheckB.TabIndex = 63;
            this.VideoBitrateCheckB.UseVisualStyleBackColor = true;
            this.VideoBitrateCheckB.CheckedChanged += new System.EventHandler(this.VideoBitrateCheckB_CheckedChanged);
            // 
            // VideoBitrateLBL
            // 
            this.VideoBitrateLBL.AutoSize = true;
            this.VideoBitrateLBL.Location = new System.Drawing.Point(255, 150);
            this.VideoBitrateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VideoBitrateLBL.Name = "VideoBitrateLBL";
            this.VideoBitrateLBL.Size = new System.Drawing.Size(88, 17);
            this.VideoBitrateLBL.TabIndex = 62;
            this.VideoBitrateLBL.Text = "Video bitrate";
            // 
            // VideoBitrateCB1
            // 
            this.VideoBitrateCB1.FormattingEnabled = true;
            this.VideoBitrateCB1.Items.AddRange(new object[] {
            "1",
            "1,5",
            "2,5",
            "4",
            "5",
            "7,5",
            "8",
            "12",
            "16",
            "24",
            "35",
            "45",
            "53",
            "68"});
            this.VideoBitrateCB1.Location = new System.Drawing.Point(284, 168);
            this.VideoBitrateCB1.Margin = new System.Windows.Forms.Padding(4);
            this.VideoBitrateCB1.Name = "VideoBitrateCB1";
            this.VideoBitrateCB1.Size = new System.Drawing.Size(55, 24);
            this.VideoBitrateCB1.TabIndex = 61;
            this.VideoBitrateCB1.Text = "5";
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(66, 50);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(55, 23);
            this.btnSAVE.TabIndex = 67;
            this.btnSAVE.Text = "Save";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnLOAD
            // 
            this.btnLOAD.Location = new System.Drawing.Point(120, 50);
            this.btnLOAD.Name = "btnLOAD";
            this.btnLOAD.Size = new System.Drawing.Size(55, 23);
            this.btnLOAD.TabIndex = 68;
            this.btnLOAD.Text = "Load";
            this.btnLOAD.UseVisualStyleBackColor = true;
            this.btnLOAD.Click += new System.EventHandler(this.btnLOAD_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(174, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 23);
            this.btnClear.TabIndex = 69;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FinterpolateCheckB
            // 
            this.FinterpolateCheckB.AutoSize = true;
            this.FinterpolateCheckB.Location = new System.Drawing.Point(660, 214);
            this.FinterpolateCheckB.Margin = new System.Windows.Forms.Padding(4);
            this.FinterpolateCheckB.Name = "FinterpolateCheckB";
            this.FinterpolateCheckB.Size = new System.Drawing.Size(18, 17);
            this.FinterpolateCheckB.TabIndex = 72;
            this.FinterpolateCheckB.UseVisualStyleBackColor = true;
            this.FinterpolateCheckB.CheckedChanged += new System.EventHandler(this.FinterpolateCheckB_CheckedChanged);
            // 
            // FinterpolateLBL
            // 
            this.FinterpolateLBL.AutoSize = true;
            this.FinterpolateLBL.Location = new System.Drawing.Point(656, 192);
            this.FinterpolateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinterpolateLBL.Name = "FinterpolateLBL";
            this.FinterpolateLBL.Size = new System.Drawing.Size(130, 17);
            this.FinterpolateLBL.TabIndex = 71;
            this.FinterpolateLBL.Text = "Frame Interpolation";
            // 
            // FinterpolateCB1
            // 
            this.FinterpolateCB1.FormattingEnabled = true;
            this.FinterpolateCB1.Location = new System.Drawing.Point(685, 211);
            this.FinterpolateCB1.Margin = new System.Windows.Forms.Padding(4);
            this.FinterpolateCB1.Name = "FinterpolateCB1";
            this.FinterpolateCB1.Size = new System.Drawing.Size(108, 24);
            this.FinterpolateCB1.TabIndex = 70;
            // 
            // quickLBL
            // 
            this.quickLBL.AutoSize = true;
            this.quickLBL.Location = new System.Drawing.Point(16, 53);
            this.quickLBL.Name = "quickLBL";
            this.quickLBL.Size = new System.Drawing.Size(48, 17);
            this.quickLBL.TabIndex = 73;
            this.quickLBL.Text = "Quick:";
            // 
            // VideoProgressBar
            // 
            this.VideoProgressBar.Enabled = false;
            this.VideoProgressBar.Location = new System.Drawing.Point(428, 406);
            this.VideoProgressBar.Name = "VideoProgressBar";
            this.VideoProgressBar.Size = new System.Drawing.Size(369, 40);
            this.VideoProgressBar.TabIndex = 0;
            // 
            // btnRUN
            // 
            this.btnRUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUN.Location = new System.Drawing.Point(428, 329);
            this.btnRUN.Name = "btnRUN";
            this.btnRUN.Size = new System.Drawing.Size(303, 50);
            this.btnRUN.TabIndex = 74;
            this.btnRUN.Text = "Export Video";
            this.btnRUN.UseVisualStyleBackColor = true;
            this.btnRUN.Click += new System.EventHandler(this.btnRUN_Click);
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // OUTPUTTBX
            // 
            this.OUTPUTTBX.BackColor = System.Drawing.SystemColors.Control;
            this.OUTPUTTBX.Location = new System.Drawing.Point(12, 448);
            this.OUTPUTTBX.Multiline = true;
            this.OUTPUTTBX.Name = "OUTPUTTBX";
            this.OUTPUTTBX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OUTPUTTBX.Size = new System.Drawing.Size(785, 193);
            this.OUTPUTTBX.TabIndex = 75;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Crimson;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancel.Location = new System.Drawing.Point(737, 329);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(60, 50);
            this.Cancel.TabIndex = 76;
            this.Cancel.Text = "X";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(824, 402);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 83);
            this.textBox1.TabIndex = 77;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(437, 386);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(86, 17);
            this.lblCurrentTime.TabIndex = 78;
            this.lblCurrentTime.Text = "CurrentTime";
            // 
            // lblFullTime
            // 
            this.lblFullTime.AutoSize = true;
            this.lblFullTime.Location = new System.Drawing.Point(722, 386);
            this.lblFullTime.Name = "lblFullTime";
            this.lblFullTime.Size = new System.Drawing.Size(61, 17);
            this.lblFullTime.TabIndex = 79;
            this.lblFullTime.Text = "FullTime";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(589, 386);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(20, 17);
            this.lblPercent.TabIndex = 80;
            this.lblPercent.Text = "%";
            // 
            // btnExportPreset
            // 
            this.btnExportPreset.Location = new System.Drawing.Point(513, 45);
            this.btnExportPreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportPreset.Name = "btnExportPreset";
            this.btnExportPreset.Size = new System.Drawing.Size(92, 28);
            this.btnExportPreset.TabIndex = 81;
            this.btnExportPreset.Text = "Save preset";
            this.btnExportPreset.UseVisualStyleBackColor = true;
            this.btnExportPreset.Click += new System.EventHandler(this.btnExportPreset_Click);
            // 
            // btnDeletePreset
            // 
            this.btnDeletePreset.Location = new System.Drawing.Point(604, 45);
            this.btnDeletePreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePreset.Name = "btnDeletePreset";
            this.btnDeletePreset.Size = new System.Drawing.Size(101, 28);
            this.btnDeletePreset.TabIndex = 82;
            this.btnDeletePreset.Text = "Delete preset";
            this.btnDeletePreset.UseVisualStyleBackColor = true;
            this.btnDeletePreset.Click += new System.EventHandler(this.btnDeletePreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 653);
            this.Controls.Add(this.btnDeletePreset);
            this.Controls.Add(this.btnExportPreset);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblFullTime);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OUTPUTTBX);
            this.Controls.Add(this.btnRUN);
            this.Controls.Add(this.VideoProgressBar);
            this.Controls.Add(this.quickLBL);
            this.Controls.Add(this.FinterpolateCheckB);
            this.Controls.Add(this.FinterpolateLBL);
            this.Controls.Add(this.FinterpolateCB1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLOAD);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.VideoKbps);
            this.Controls.Add(this.VideoBitrateCheckB);
            this.Controls.Add(this.VideoBitrateLBL);
            this.Controls.Add(this.VideoBitrateCB1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CropYLocationTBX);
            this.Controls.Add(this.CropXLocationTBX);
            this.Controls.Add(this.CropYSizeTBX);
            this.Controls.Add(this.CropXSizeTBX);
            this.Controls.Add(this.CropCheckB);
            this.Controls.Add(this.lblCrop);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AudioKbps);
            this.Controls.Add(this.AudioBitrateCheckB);
            this.Controls.Add(this.AudioBitrateLBL);
            this.Controls.Add(this.AudioBitrateCB1);
            this.Controls.Add(this.LevelCheckB);
            this.Controls.Add(this.LevelLBL);
            this.Controls.Add(this.LevelCB1);
            this.Controls.Add(this.btnDEBUG);
            this.Controls.Add(this.OutputNameTBX);
            this.Controls.Add(this.DestinationBTN);
            this.Controls.Add(this.FileNameOutputTBX);
            this.Controls.Add(this.BtnChoosePreset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PresetSelectCB1);
            this.Controls.Add(this.FileEXTCB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VencodCB1);
            this.Controls.Add(this.ProfileCheckB);
            this.Controls.Add(this.ProfileLBL);
            this.Controls.Add(this.ProfileCB1);
            this.Controls.Add(this.MaxrateCheckB);
            this.Controls.Add(this.BufsizeCheckB);
            this.Controls.Add(this.BufsizeLBL);
            this.Controls.Add(this.BufSizeCB1);
            this.Controls.Add(this.MaxrateLBL);
            this.Controls.Add(this.MaxrateCB1);
            this.Controls.Add(this.PresetCheckB);
            this.Controls.Add(this.PresetLBL);
            this.Controls.Add(this.PresetCB1);
            this.Controls.Add(this.crfCheckB);
            this.Controls.Add(this.crfLBL);
            this.Controls.Add(this.crfCB1);
            this.Controls.Add(this.FPSCheckB);
            this.Controls.Add(this.FPSLBL);
            this.Controls.Add(this.FPSCB1);
            this.Controls.Add(this.DeinterlaceCheckB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deinterlaceCB1);
            this.Controls.Add(this.AspectRatioCheckB);
            this.Controls.Add(this.AspectRatioLBL);
            this.Controls.Add(this.AspectRatioCB1);
            this.Controls.Add(this.ResCheckB);
            this.Controls.Add(this.resolutionLBL);
            this.Controls.Add(this.resolutionCB1);
            this.Controls.Add(this.fileTBX);
            this.Controls.Add(this.fileselectBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ffmpeg UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileselectBTN;
        private System.Windows.Forms.TextBox fileTBX;
        private System.Windows.Forms.ComboBox resolutionCB1;
        private System.Windows.Forms.Label resolutionLBL;
        private System.Windows.Forms.CheckBox ResCheckB;
        private System.Windows.Forms.CheckBox AspectRatioCheckB;
        private System.Windows.Forms.Label AspectRatioLBL;
        private System.Windows.Forms.ComboBox AspectRatioCB1;
        private System.Windows.Forms.CheckBox DeinterlaceCheckB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deinterlaceCB1;
        private System.Windows.Forms.CheckBox FPSCheckB;
        private System.Windows.Forms.Label FPSLBL;
        private System.Windows.Forms.ComboBox FPSCB1;
        private System.Windows.Forms.CheckBox crfCheckB;
        private System.Windows.Forms.Label crfLBL;
        private System.Windows.Forms.ComboBox crfCB1;
        private System.Windows.Forms.CheckBox PresetCheckB;
        private System.Windows.Forms.Label PresetLBL;
        private System.Windows.Forms.ComboBox PresetCB1;
        private System.Windows.Forms.Label MaxrateLBL;
        private System.Windows.Forms.ComboBox MaxrateCB1;
        private System.Windows.Forms.Label BufsizeLBL;
        private System.Windows.Forms.ComboBox BufSizeCB1;
        private System.Windows.Forms.CheckBox BufsizeCheckB;
        private System.Windows.Forms.CheckBox MaxrateCheckB;
        private System.Windows.Forms.CheckBox ProfileCheckB;
        private System.Windows.Forms.Label ProfileLBL;
        private System.Windows.Forms.ComboBox ProfileCB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VencodCB1;
        private System.Windows.Forms.ComboBox PresetSelectCB1;
        private System.Windows.Forms.Button BtnChoosePreset;
        private System.Windows.Forms.ComboBox FileEXTCB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FileNameOutputTBX;
        private System.Windows.Forms.Button DestinationBTN;
        private System.Windows.Forms.TextBox OutputNameTBX;
        private System.Windows.Forms.Button btnDEBUG;
        private System.Windows.Forms.CheckBox LevelCheckB;
        private System.Windows.Forms.Label LevelLBL;
        private System.Windows.Forms.ComboBox LevelCB1;
        private System.Windows.Forms.CheckBox AudioBitrateCheckB;
        private System.Windows.Forms.Label AudioBitrateLBL;
        private System.Windows.Forms.ComboBox AudioBitrateCB1;
        private System.Windows.Forms.Label AudioKbps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox CropCheckB;
        private System.Windows.Forms.Label lblCrop;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox CropXSizeTBX;
        private System.Windows.Forms.TextBox CropYSizeTBX;
        private System.Windows.Forms.TextBox CropXLocationTBX;
        private System.Windows.Forms.TextBox CropYLocationTBX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label VideoKbps;
        private System.Windows.Forms.CheckBox VideoBitrateCheckB;
        private System.Windows.Forms.Label VideoBitrateLBL;
        private System.Windows.Forms.ComboBox VideoBitrateCB1;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnLOAD;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox FinterpolateCheckB;
        private System.Windows.Forms.Label FinterpolateLBL;
        private System.Windows.Forms.ComboBox FinterpolateCB1;
        private System.Windows.Forms.Label quickLBL;
        private System.Windows.Forms.ProgressBar VideoProgressBar;
        private System.Windows.Forms.Button btnRUN;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.TextBox OUTPUTTBX;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblFullTime;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Button btnExportPreset;
        private System.Windows.Forms.Button btnDeletePreset;
    }
}

