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
            this.fileselectBTN = new System.Windows.Forms.Button();
            this.fileTBX = new System.Windows.Forms.TextBox();
            this.btnDEBUG = new System.Windows.Forms.Button();
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
            this.OutputNameTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DestinationBTN = new System.Windows.Forms.Button();
            this.FileNameOutputTBX = new System.Windows.Forms.TextBox();
            this.FileEXTCB1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PS2PALPRESETBTN = new System.Windows.Forms.Button();
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
            this.fileTBX.Location = new System.Drawing.Point(13, 28);
            this.fileTBX.Name = "fileTBX";
            this.fileTBX.Size = new System.Drawing.Size(332, 20);
            this.fileTBX.TabIndex = 1;
            this.fileTBX.Text = "B:\\Videos\\Elgato\\EGC_Library\\My Great Game - My Great Capture - 2020-09-07 15-11-" +
    "29\\Recording_2020-09-07_15-11-29_0004.ts";
            this.fileTBX.TextChanged += new System.EventHandler(this.fileTBX_TextChanged);
            this.fileTBX.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileTBX_DragDrop);
            this.fileTBX.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileTBX_DragEnter);
            // 
            // btnDEBUG
            // 
            this.btnDEBUG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEBUG.Location = new System.Drawing.Point(374, 374);
            this.btnDEBUG.Name = "btnDEBUG";
            this.btnDEBUG.Size = new System.Drawing.Size(277, 64);
            this.btnDEBUG.TabIndex = 2;
            this.btnDEBUG.Text = "Export Video File";
            this.btnDEBUG.UseVisualStyleBackColor = true;
            this.btnDEBUG.Click += new System.EventHandler(this.btnDEBUG_Click);
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
            this.BufsizeLBL.Location = new System.Drawing.Point(125, 118);
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
            this.BufSizeCB1.Location = new System.Drawing.Point(147, 133);
            this.BufSizeCB1.Name = "BufSizeCB1";
            this.BufSizeCB1.Size = new System.Drawing.Size(82, 21);
            this.BufSizeCB1.TabIndex = 23;
            // 
            // BufsizeCheckB
            // 
            this.BufsizeCheckB.AutoSize = true;
            this.BufsizeCheckB.Location = new System.Drawing.Point(128, 136);
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
            "high"});
            this.ProfileCB1.Location = new System.Drawing.Point(138, 359);
            this.ProfileCB1.Name = "ProfileCB1";
            this.ProfileCB1.Size = new System.Drawing.Size(82, 21);
            this.ProfileCB1.TabIndex = 27;
            this.ProfileCB1.Text = "high";
            // 
            // OutputNameTBX
            // 
            this.OutputNameTBX.Location = new System.Drawing.Point(374, 326);
            this.OutputNameTBX.Name = "OutputNameTBX";
            this.OutputNameTBX.Size = new System.Drawing.Size(191, 20);
            this.OutputNameTBX.TabIndex = 30;
            this.OutputNameTBX.Text = "B:\\ffmpeg\\EXPORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Encoder";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "libx264"});
            this.comboBox1.Location = new System.Drawing.Point(569, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "libx264";
            // 
            // DestinationBTN
            // 
            this.DestinationBTN.Location = new System.Drawing.Point(569, 325);
            this.DestinationBTN.Name = "DestinationBTN";
            this.DestinationBTN.Size = new System.Drawing.Size(80, 20);
            this.DestinationBTN.TabIndex = 33;
            this.DestinationBTN.Text = "Save location";
            this.DestinationBTN.UseVisualStyleBackColor = true;
            this.DestinationBTN.Click += new System.EventHandler(this.DestinationBTN_Click);
            // 
            // FileNameOutputTBX
            // 
            this.FileNameOutputTBX.Location = new System.Drawing.Point(440, 352);
            this.FileNameOutputTBX.Name = "FileNameOutputTBX";
            this.FileNameOutputTBX.Size = new System.Drawing.Size(125, 20);
            this.FileNameOutputTBX.TabIndex = 34;
            this.FileNameOutputTBX.Text = "Export";
            // 
            // FileEXTCB1
            // 
            this.FileEXTCB1.FormattingEnabled = true;
            this.FileEXTCB1.Items.AddRange(new object[] {
            ".mp4"});
            this.FileEXTCB1.Location = new System.Drawing.Point(569, 351);
            this.FileEXTCB1.Name = "FileEXTCB1";
            this.FileEXTCB1.Size = new System.Drawing.Size(80, 21);
            this.FileEXTCB1.TabIndex = 35;
            this.FileEXTCB1.Text = ".mp4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "File name";
            // 
            // PS2PALPRESETBTN
            // 
            this.PS2PALPRESETBTN.Location = new System.Drawing.Point(550, 173);
            this.PS2PALPRESETBTN.Name = "PS2PALPRESETBTN";
            this.PS2PALPRESETBTN.Size = new System.Drawing.Size(99, 23);
            this.PS2PALPRESETBTN.TabIndex = 37;
            this.PS2PALPRESETBTN.Text = "PS2 PAL Preset";
            this.PS2PALPRESETBTN.UseVisualStyleBackColor = true;
            this.PS2PALPRESETBTN.Click += new System.EventHandler(this.PS2PALPRESETBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.PS2PALPRESETBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileEXTCB1);
            this.Controls.Add(this.FileNameOutputTBX);
            this.Controls.Add(this.DestinationBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.OutputNameTBX);
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
            this.Controls.Add(this.btnDEBUG);
            this.Controls.Add(this.fileTBX);
            this.Controls.Add(this.fileselectBTN);
            this.Name = "Form1";
            this.Text = "ffmpeg UI V0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileselectBTN;
        private System.Windows.Forms.TextBox fileTBX;
        private System.Windows.Forms.Button btnDEBUG;
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
        private System.Windows.Forms.TextBox OutputNameTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button DestinationBTN;
        private System.Windows.Forms.TextBox FileNameOutputTBX;
        private System.Windows.Forms.ComboBox FileEXTCB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PS2PALPRESETBTN;
    }
}

