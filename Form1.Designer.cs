﻿namespace ffmpegUI
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
            this.label4 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // fileselectBTN
            // 
            this.fileselectBTN.Location = new System.Drawing.Point(351, 27);
            this.fileselectBTN.Name = "fileselectBTN";
            this.fileselectBTN.Size = new System.Drawing.Size(75, 20);
            this.fileselectBTN.TabIndex = 0;
            this.fileselectBTN.Text = "Select file";
            this.fileselectBTN.UseVisualStyleBackColor = true;
            this.fileselectBTN.Click += new System.EventHandler(this.fileselectBTN_Click);
            // 
            // fileTBX
            // 
            this.fileTBX.AllowDrop = true;
            this.fileTBX.Location = new System.Drawing.Point(13, 28);
            this.fileTBX.Name = "fileTBX";
            this.fileTBX.Size = new System.Drawing.Size(332, 20);
            this.fileTBX.TabIndex = 1;
            this.fileTBX.Text = "C:\\";
            this.fileTBX.TextChanged += new System.EventHandler(this.fileTBX_TextChanged);
            this.fileTBX.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileTBX_DragDrop);
            this.fileTBX.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileTBX_DragEnter);
            // 
            // resolutionCB1
            // 
            this.resolutionCB1.FormattingEnabled = true;
            this.resolutionCB1.Location = new System.Drawing.Point(451, 24);
            this.resolutionCB1.Name = "resolutionCB1";
            this.resolutionCB1.Size = new System.Drawing.Size(82, 21);
            this.resolutionCB1.TabIndex = 3;
            this.resolutionCB1.SelectedIndexChanged += new System.EventHandler(this.resolutionCB1_SelectedIndexChanged);
            // 
            // resolutionLBL
            // 
            this.resolutionLBL.AutoSize = true;
            this.resolutionLBL.Location = new System.Drawing.Point(429, 9);
            this.resolutionLBL.Name = "resolutionLBL";
            this.resolutionLBL.Size = new System.Drawing.Size(57, 13);
            this.resolutionLBL.TabIndex = 4;
            this.resolutionLBL.Text = "Resolution";
            // 
            // ResCheckB
            // 
            this.ResCheckB.AutoSize = true;
            this.ResCheckB.Location = new System.Drawing.Point(432, 27);
            this.ResCheckB.Name = "ResCheckB";
            this.ResCheckB.Size = new System.Drawing.Size(15, 14);
            this.ResCheckB.TabIndex = 5;
            this.ResCheckB.UseVisualStyleBackColor = true;
            this.ResCheckB.CheckedChanged += new System.EventHandler(this.ResCheckB_CheckedChanged);
            // 
            // AspectRatioCheckB
            // 
            this.AspectRatioCheckB.AutoSize = true;
            this.AspectRatioCheckB.Location = new System.Drawing.Point(432, 70);
            this.AspectRatioCheckB.Name = "AspectRatioCheckB";
            this.AspectRatioCheckB.Size = new System.Drawing.Size(15, 14);
            this.AspectRatioCheckB.TabIndex = 8;
            this.AspectRatioCheckB.UseVisualStyleBackColor = true;
            this.AspectRatioCheckB.CheckedChanged += new System.EventHandler(this.AspectRatioCheckB_CheckedChanged);
            // 
            // AspectRatioLBL
            // 
            this.AspectRatioLBL.AutoSize = true;
            this.AspectRatioLBL.Location = new System.Drawing.Point(429, 52);
            this.AspectRatioLBL.Name = "AspectRatioLBL";
            this.AspectRatioLBL.Size = new System.Drawing.Size(68, 13);
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
            this.AspectRatioCB1.Location = new System.Drawing.Point(451, 67);
            this.AspectRatioCB1.Name = "AspectRatioCB1";
            this.AspectRatioCB1.Size = new System.Drawing.Size(82, 21);
            this.AspectRatioCB1.TabIndex = 6;
            // 
            // DeinterlaceCheckB
            // 
            this.DeinterlaceCheckB.AutoSize = true;
            this.DeinterlaceCheckB.Location = new System.Drawing.Point(550, 27);
            this.DeinterlaceCheckB.Name = "DeinterlaceCheckB";
            this.DeinterlaceCheckB.Size = new System.Drawing.Size(15, 14);
            this.DeinterlaceCheckB.TabIndex = 11;
            this.DeinterlaceCheckB.UseVisualStyleBackColor = true;
            this.DeinterlaceCheckB.CheckedChanged += new System.EventHandler(this.DeinterlaceCheckB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
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
            this.deinterlaceCB1.Location = new System.Drawing.Point(569, 24);
            this.deinterlaceCB1.Name = "deinterlaceCB1";
            this.deinterlaceCB1.Size = new System.Drawing.Size(82, 21);
            this.deinterlaceCB1.TabIndex = 9;
            this.deinterlaceCB1.TabStop = false;
            // 
            // FPSCheckB
            // 
            this.FPSCheckB.AutoSize = true;
            this.FPSCheckB.Location = new System.Drawing.Point(550, 70);
            this.FPSCheckB.Name = "FPSCheckB";
            this.FPSCheckB.Size = new System.Drawing.Size(15, 14);
            this.FPSCheckB.TabIndex = 14;
            this.FPSCheckB.UseVisualStyleBackColor = true;
            this.FPSCheckB.CheckedChanged += new System.EventHandler(this.FPSCheckB_CheckedChanged);
            // 
            // FPSLBL
            // 
            this.FPSLBL.AutoSize = true;
            this.FPSLBL.Location = new System.Drawing.Point(547, 52);
            this.FPSLBL.Name = "FPSLBL";
            this.FPSLBL.Size = new System.Drawing.Size(54, 13);
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
            this.FPSCB1.Location = new System.Drawing.Point(569, 67);
            this.FPSCB1.Name = "FPSCB1";
            this.FPSCB1.Size = new System.Drawing.Size(82, 21);
            this.FPSCB1.TabIndex = 12;
            // 
            // crfCheckB
            // 
            this.crfCheckB.AutoSize = true;
            this.crfCheckB.Location = new System.Drawing.Point(16, 95);
            this.crfCheckB.Name = "crfCheckB";
            this.crfCheckB.Size = new System.Drawing.Size(15, 14);
            this.crfCheckB.TabIndex = 17;
            this.crfCheckB.UseVisualStyleBackColor = true;
            this.crfCheckB.CheckedChanged += new System.EventHandler(this.crfCheckB_CheckedChanged);
            // 
            // crfLBL
            // 
            this.crfLBL.AutoSize = true;
            this.crfLBL.Location = new System.Drawing.Point(13, 77);
            this.crfLBL.Name = "crfLBL";
            this.crfLBL.Size = new System.Drawing.Size(19, 13);
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
            this.crfCB1.Location = new System.Drawing.Point(35, 92);
            this.crfCB1.Name = "crfCB1";
            this.crfCB1.Size = new System.Drawing.Size(82, 21);
            this.crfCB1.TabIndex = 15;
            // 
            // PresetCheckB
            // 
            this.PresetCheckB.AutoSize = true;
            this.PresetCheckB.Location = new System.Drawing.Point(13, 362);
            this.PresetCheckB.Name = "PresetCheckB";
            this.PresetCheckB.Size = new System.Drawing.Size(15, 14);
            this.PresetCheckB.TabIndex = 20;
            this.PresetCheckB.UseVisualStyleBackColor = true;
            this.PresetCheckB.CheckedChanged += new System.EventHandler(this.PresetCheckB_CheckedChanged);
            // 
            // PresetLBL
            // 
            this.PresetLBL.AutoSize = true;
            this.PresetLBL.Location = new System.Drawing.Point(10, 344);
            this.PresetLBL.Name = "PresetLBL";
            this.PresetLBL.Size = new System.Drawing.Size(37, 13);
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
            this.PresetCB1.Location = new System.Drawing.Point(32, 359);
            this.PresetCB1.Name = "PresetCB1";
            this.PresetCB1.Size = new System.Drawing.Size(82, 21);
            this.PresetCB1.TabIndex = 18;
            this.PresetCB1.Text = "superfast";
            // 
            // MaxrateLBL
            // 
            this.MaxrateLBL.AutoSize = true;
            this.MaxrateLBL.Location = new System.Drawing.Point(13, 118);
            this.MaxrateLBL.Name = "MaxrateLBL";
            this.MaxrateLBL.Size = new System.Drawing.Size(45, 13);
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
            this.MaxrateCB1.Location = new System.Drawing.Point(35, 133);
            this.MaxrateCB1.Name = "MaxrateCB1";
            this.MaxrateCB1.Size = new System.Drawing.Size(82, 21);
            this.MaxrateCB1.TabIndex = 21;
            // 
            // BufsizeLBL
            // 
            this.BufsizeLBL.AutoSize = true;
            this.BufsizeLBL.Location = new System.Drawing.Point(13, 160);
            this.BufsizeLBL.Name = "BufsizeLBL";
            this.BufsizeLBL.Size = new System.Drawing.Size(43, 13);
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
            this.BufSizeCB1.Location = new System.Drawing.Point(35, 175);
            this.BufSizeCB1.Name = "BufSizeCB1";
            this.BufSizeCB1.Size = new System.Drawing.Size(82, 21);
            this.BufSizeCB1.TabIndex = 23;
            // 
            // BufsizeCheckB
            // 
            this.BufsizeCheckB.AutoSize = true;
            this.BufsizeCheckB.Location = new System.Drawing.Point(16, 178);
            this.BufsizeCheckB.Name = "BufsizeCheckB";
            this.BufsizeCheckB.Size = new System.Drawing.Size(15, 14);
            this.BufsizeCheckB.TabIndex = 25;
            this.BufsizeCheckB.UseVisualStyleBackColor = true;
            this.BufsizeCheckB.CheckedChanged += new System.EventHandler(this.BufsizeCheckB_CheckedChanged);
            // 
            // MaxrateCheckB
            // 
            this.MaxrateCheckB.AutoSize = true;
            this.MaxrateCheckB.Location = new System.Drawing.Point(16, 136);
            this.MaxrateCheckB.Name = "MaxrateCheckB";
            this.MaxrateCheckB.Size = new System.Drawing.Size(15, 14);
            this.MaxrateCheckB.TabIndex = 26;
            this.MaxrateCheckB.UseVisualStyleBackColor = true;
            this.MaxrateCheckB.CheckedChanged += new System.EventHandler(this.MaxrateCheckB_CheckedChanged);
            // 
            // ProfileCheckB
            // 
            this.ProfileCheckB.AutoSize = true;
            this.ProfileCheckB.Location = new System.Drawing.Point(119, 362);
            this.ProfileCheckB.Name = "ProfileCheckB";
            this.ProfileCheckB.Size = new System.Drawing.Size(15, 14);
            this.ProfileCheckB.TabIndex = 29;
            this.ProfileCheckB.UseVisualStyleBackColor = true;
            this.ProfileCheckB.CheckedChanged += new System.EventHandler(this.ProfileCheckB_CheckedChanged);
            // 
            // ProfileLBL
            // 
            this.ProfileLBL.AutoSize = true;
            this.ProfileLBL.Location = new System.Drawing.Point(116, 344);
            this.ProfileLBL.Name = "ProfileLBL";
            this.ProfileLBL.Size = new System.Drawing.Size(36, 13);
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
            this.ProfileCB1.Location = new System.Drawing.Point(138, 359);
            this.ProfileCB1.Name = "ProfileCB1";
            this.ProfileCB1.Size = new System.Drawing.Size(82, 21);
            this.ProfileCB1.TabIndex = 27;
            this.ProfileCB1.Text = "high";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Video Encoder";
            // 
            // VencodCB1
            // 
            this.VencodCB1.FormattingEnabled = true;
            this.VencodCB1.Items.AddRange(new object[] {
            "libx264",
            "libx265"});
            this.VencodCB1.Location = new System.Drawing.Point(322, 129);
            this.VencodCB1.Name = "VencodCB1";
            this.VencodCB1.Size = new System.Drawing.Size(61, 21);
            this.VencodCB1.TabIndex = 31;
            this.VencodCB1.Text = "libx264";
            // 
            // PresetSelectCB1
            // 
            this.PresetSelectCB1.FormattingEnabled = true;
            this.PresetSelectCB1.Location = new System.Drawing.Point(377, 242);
            this.PresetSelectCB1.Name = "PresetSelectCB1";
            this.PresetSelectCB1.Size = new System.Drawing.Size(148, 21);
            this.PresetSelectCB1.TabIndex = 38;
            this.PresetSelectCB1.DropDown += new System.EventHandler(this.PresetSelectCB1_DropDown);
            // 
            // BtnChoosePreset
            // 
            this.BtnChoosePreset.Location = new System.Drawing.Point(531, 240);
            this.BtnChoosePreset.Name = "BtnChoosePreset";
            this.BtnChoosePreset.Size = new System.Drawing.Size(99, 23);
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
            ".mp3"});
            this.FileEXTCB1.Location = new System.Drawing.Point(569, 339);
            this.FileEXTCB1.Name = "FileEXTCB1";
            this.FileEXTCB1.Size = new System.Drawing.Size(80, 21);
            this.FileEXTCB1.TabIndex = 35;
            this.FileEXTCB1.Text = ".mp4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "File name";
            // 
            // FileNameOutputTBX
            // 
            this.FileNameOutputTBX.Location = new System.Drawing.Point(440, 340);
            this.FileNameOutputTBX.Name = "FileNameOutputTBX";
            this.FileNameOutputTBX.Size = new System.Drawing.Size(125, 20);
            this.FileNameOutputTBX.TabIndex = 34;
            this.FileNameOutputTBX.Text = "Export";
            // 
            // DestinationBTN
            // 
            this.DestinationBTN.Location = new System.Drawing.Point(569, 313);
            this.DestinationBTN.Name = "DestinationBTN";
            this.DestinationBTN.Size = new System.Drawing.Size(80, 20);
            this.DestinationBTN.TabIndex = 33;
            this.DestinationBTN.Text = "Save location";
            this.DestinationBTN.UseVisualStyleBackColor = true;
            this.DestinationBTN.Click += new System.EventHandler(this.DestinationBTN_Click);
            // 
            // OutputNameTBX
            // 
            this.OutputNameTBX.Location = new System.Drawing.Point(374, 314);
            this.OutputNameTBX.Name = "OutputNameTBX";
            this.OutputNameTBX.Size = new System.Drawing.Size(191, 20);
            this.OutputNameTBX.TabIndex = 30;
            this.OutputNameTBX.Text = "C:\\";
            // 
            // btnDEBUG
            // 
            this.btnDEBUG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEBUG.Location = new System.Drawing.Point(374, 362);
            this.btnDEBUG.Name = "btnDEBUG";
            this.btnDEBUG.Size = new System.Drawing.Size(277, 64);
            this.btnDEBUG.TabIndex = 2;
            this.btnDEBUG.Text = "Export Video File";
            this.btnDEBUG.UseVisualStyleBackColor = true;
            this.btnDEBUG.Click += new System.EventHandler(this.btnDEBUG_Click);
            // 
            // LevelCheckB
            // 
            this.LevelCheckB.AutoSize = true;
            this.LevelCheckB.Location = new System.Drawing.Point(233, 362);
            this.LevelCheckB.Name = "LevelCheckB";
            this.LevelCheckB.Size = new System.Drawing.Size(15, 14);
            this.LevelCheckB.TabIndex = 43;
            this.LevelCheckB.UseVisualStyleBackColor = true;
            this.LevelCheckB.CheckedChanged += new System.EventHandler(this.LevelCheckB_CheckedChanged);
            // 
            // LevelLBL
            // 
            this.LevelLBL.AutoSize = true;
            this.LevelLBL.Location = new System.Drawing.Point(230, 344);
            this.LevelLBL.Name = "LevelLBL";
            this.LevelLBL.Size = new System.Drawing.Size(33, 13);
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
            this.LevelCB1.Location = new System.Drawing.Point(252, 359);
            this.LevelCB1.Name = "LevelCB1";
            this.LevelCB1.Size = new System.Drawing.Size(82, 21);
            this.LevelCB1.TabIndex = 41;
            this.LevelCB1.Text = "4.2";
            // 
            // AudioBitrateCheckB
            // 
            this.AudioBitrateCheckB.AutoSize = true;
            this.AudioBitrateCheckB.Location = new System.Drawing.Point(233, 90);
            this.AudioBitrateCheckB.Name = "AudioBitrateCheckB";
            this.AudioBitrateCheckB.Size = new System.Drawing.Size(15, 14);
            this.AudioBitrateCheckB.TabIndex = 46;
            this.AudioBitrateCheckB.UseVisualStyleBackColor = true;
            this.AudioBitrateCheckB.CheckedChanged += new System.EventHandler(this.AudioBitrateCheckB_CheckedChanged);
            // 
            // AudioBitrateLBL
            // 
            this.AudioBitrateLBL.AutoSize = true;
            this.AudioBitrateLBL.Location = new System.Drawing.Point(230, 72);
            this.AudioBitrateLBL.Name = "AudioBitrateLBL";
            this.AudioBitrateLBL.Size = new System.Drawing.Size(66, 13);
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
            this.AudioBitrateCB1.Location = new System.Drawing.Point(252, 87);
            this.AudioBitrateCB1.Name = "AudioBitrateCB1";
            this.AudioBitrateCB1.Size = new System.Drawing.Size(42, 21);
            this.AudioBitrateCB1.TabIndex = 44;
            this.AudioBitrateCB1.Text = "128";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "kbps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Audio Encoder";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "mp3"});
            this.comboBox1.Location = new System.Drawing.Point(322, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // CropCheckB
            // 
            this.CropCheckB.AutoSize = true;
            this.CropCheckB.Location = new System.Drawing.Point(13, 245);
            this.CropCheckB.Name = "CropCheckB";
            this.CropCheckB.Size = new System.Drawing.Size(15, 14);
            this.CropCheckB.TabIndex = 52;
            this.CropCheckB.UseVisualStyleBackColor = true;
            this.CropCheckB.CheckedChanged += new System.EventHandler(this.CropCheckB_CheckedChanged);
            // 
            // lblCrop
            // 
            this.lblCrop.AutoSize = true;
            this.lblCrop.Location = new System.Drawing.Point(10, 227);
            this.lblCrop.Name = "lblCrop";
            this.lblCrop.Size = new System.Drawing.Size(29, 13);
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
            this.comboBox2.Location = new System.Drawing.Point(688, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 21);
            this.comboBox2.TabIndex = 50;
            // 
            // CropXSizeTBX
            // 
            this.CropXSizeTBX.Location = new System.Drawing.Point(64, 241);
            this.CropXSizeTBX.Name = "CropXSizeTBX";
            this.CropXSizeTBX.Size = new System.Drawing.Size(50, 20);
            this.CropXSizeTBX.TabIndex = 53;
            // 
            // CropYSizeTBX
            // 
            this.CropYSizeTBX.Location = new System.Drawing.Point(64, 267);
            this.CropYSizeTBX.Name = "CropYSizeTBX";
            this.CropYSizeTBX.Size = new System.Drawing.Size(50, 20);
            this.CropYSizeTBX.TabIndex = 54;
            // 
            // CropXLocationTBX
            // 
            this.CropXLocationTBX.Location = new System.Drawing.Point(169, 241);
            this.CropXLocationTBX.Name = "CropXLocationTBX";
            this.CropXLocationTBX.Size = new System.Drawing.Size(48, 20);
            this.CropXLocationTBX.TabIndex = 55;
            // 
            // CropYLocationTBX
            // 
            this.CropYLocationTBX.Location = new System.Drawing.Point(169, 267);
            this.CropYLocationTBX.Name = "CropYLocationTBX";
            this.CropYLocationTBX.Size = new System.Drawing.Size(48, 20);
            this.CropYLocationTBX.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "X size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Y size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Y position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "X position";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 442);
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
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
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
    }
}

