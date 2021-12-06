using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; //TEST
using System.IO;

namespace ffmpegUI
{
    using Microsoft.CSharp;
    using System.CodeDom.Compiler;
    public partial class Form1 : Form
    {
        string outputFFMPEG;
        string VideoLength;
        string CurrentVideoProgress;
        int totalSecondsVideoLength;
        int totalSecondsCurrentProgress;
        string DotTxt;

        System.Diagnostics.Process ffmpeg = new System.Diagnostics.Process();
        private class ComboBoxItem
        {
            public int Value { get; set; }
            public double Progress { get; set; }
            public string Text { get; set; }
            public bool Selectable { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void fileTBX_TextChanged(object sender, EventArgs e) { }
        private void fileselectBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog //Välja input fil
            {
                InitialDirectory = @"B:\Videos",
                Title = "Browse Video Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Video files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Skickar filvägen till input fileTBX rutan
            {
                fileTBX.Text = openFileDialog1.FileName;
            }
            Properties.Settings.Default.fileTBXPrevious = fileTBX.Text;
            Properties.Settings.Default.Save();
        }

        private void btnDEBUG_Click(object sender, EventArgs e) //Här läses alla textrutor, comborutor etc in och uppfattas
        {
            string ExportName = OutputNameTBX.Text + "\u005c" + FileNameOutputTBX.Text + FileEXTCB1.Text; //Läser in vart filen ska och vad den ska heta
            string AspectRatio = string.Empty; //Aspect ratio, form på videon
            if (AspectRatioCB1.Enabled == true) //Om aktiverad så kollar den vad för värde som skrivits in
            {
                AspectRatio = "-aspect " + AspectRatioCB1.Text + " ";
            }
            else //Annars gör inget
            {
                AspectRatio = "";
            }

            string vf = string.Empty; //Samma som tidigare
            if ((resolutionCB1.Enabled || deinterlaceCB1.Enabled || CropCheckB.Checked || FinterpolateCB1.Enabled == true))
            {
                vf = "-vf ";
            }
            else
            {
                vf = "";
            }

            string Deinterlace = string.Empty;
            if (deinterlaceCB1.Enabled == true)
            {
                Deinterlace = deinterlaceCB1.Text;
            }
            else
            {
                Deinterlace = "";
            }

            string CropNPos = string.Empty;       //WORK IN PROGRESS//https://video.stackexchange.com/questions/4563/how-can-i-crop-a-video-with-ffmpeg //
            if (deinterlaceCB1.Enabled == true)
            {
                CropNPos = ",";
            }
            if (CropCheckB.Checked == true)
            {
                //Normalt ffmpeg kommand "-filter:v \u0022 crop = 80:60:200:100 \u0022 "
                CropNPos = CropNPos + "\u0022 crop = " + CropXSizeTBX.Text + ":" + CropYSizeTBX.Text + ":" + CropXLocationTBX.Text + ":" + CropYLocationTBX.Text + " \u0022"; //kollar av vart videon ska cropas och hur mycket
                //" -filter:v " + "\u0022" + "minterpolate = 'fps=60'" + "\u0022 ";
            }
            else
            {
                CropNPos = "";
            }

            string Resolution = string.Empty;
            if (deinterlaceCB1.Enabled || CropCheckB.Checked == true)
            {
                Resolution = ",";
            }
            if (resolutionCB1.Enabled == true)
            {
                Resolution = Resolution + "scale=" + resolutionCB1.Text + "";
            }
            else
            {
                Resolution = "";
            }

            string Finterpolate = string.Empty;
            if (deinterlaceCB1.Enabled || CropCheckB.Checked || resolutionCB1.Enabled == true)
            {
                Finterpolate = ",";
            }
            if (FinterpolateCB1.Enabled == true)
            {
                Finterpolate = Finterpolate + "\u0022" + "minterpolate='fps=" + FinterpolateCB1.Text + "'" + "\u0022";
            }
            else
            {
                Finterpolate = "";
            }

            string Vcodec = string.Empty;
            Vcodec = "-c:v " + VencodCB1.Text + " ";


            string Preset = string.Empty;
            if (PresetCB1.Enabled == true)
            {
                Preset = "-preset " + PresetCB1.Text + " ";
            }
            else
            {
                Preset = "";
            }

            string Profile = string.Empty;
            if (ProfileCB1.Enabled == true)
            {
                Profile = "-profile:v " + ProfileCB1.Text + " ";
            }
            else
            {
                Profile = "";
            }

            string Level = string.Empty;
            if (LevelCB1.Enabled == true)
            {
                Level = "-level:v " + LevelCB1.Text + " ";
            }
            else
            {
                Level = "";
            }

            string crf = string.Empty;
            if (crfCB1.Enabled == true)
            {
                crf = "-crf " + crfCB1.Text + " ";
            }
            else
            {
                crf = "";
            }

            string Maxrate = string.Empty;
            if (MaxrateCB1.Enabled == true)
            {
                Maxrate = "-maxrate " + MaxrateCB1.Text + " ";
            }
            else
            {
                Maxrate = "";
            }

            string Bufsize = string.Empty;
            if (BufSizeCB1.Enabled == true)
            {
                Bufsize = "-bufsize " + BufSizeCB1.Text + " ";
            }
            else
            {
                Maxrate = "";
            }


            string FPS = string.Empty;
            if (FPSCB1.Enabled == true)
            {
                FPS = "-r " + FPSCB1.Text + " ";
            }
            else
            {
                FPS = "";
            }

            string AudioBitrate = string.Empty;
            if (AudioBitrateCB1.Enabled == true)
            {
                int AudioBitrateCalc = int.Parse(AudioBitrateCB1.Text) * 1000;
                AudioBitrate = "-ab " + AudioBitrateCalc + " ";
            }
            else
            {
                AudioBitrate = "";
            }

            string VideoBitrate = string.Empty;
            if (VideoBitrateCB1.Enabled == true)
            {
                double VideoBitrateCalc = double.Parse(VideoBitrateCB1.Text) * 1000000;
                VideoBitrate = "-vb " + VideoBitrateCalc + " ";
            }
            else
            {
                VideoBitrate = "";
            }


            string path = @""; //Starta i program mappen

            string ffprobePath = System.IO.Path.Combine(path, "ffprobe.exe");
            string ffprobeParams = "-show_streams \u0022" + fileTBX.Text + "\u0022";
            var ffprobe = new System.Diagnostics.Process();
            ffprobe.StartInfo.FileName = "cmd.exe";
            ffprobe.StartInfo.Arguments = "/k " + ffprobePath + " " + ffprobeParams;
            //ffprobe.Start();

            System.Diagnostics.Process ffmpeg = new System.Diagnostics.Process();
            string ffmpegPath = System.IO.Path.Combine(path, "ffmpeg.exe"); //Programmer som ska öppnas och nedan finns paramerterna vilket säger till om vad som ska göras när programet går igång.
            string ffmpegParams = "-i \u0022" + @fileTBX.Text + "\u0022 " + AspectRatio + vf + Deinterlace + CropNPos + Resolution + Finterpolate + " " + Vcodec + Preset + Profile + Level + crf + Maxrate + Bufsize + FPS + AudioBitrate + VideoBitrate + " -movflags +faststart -y " + "\u0022" + ExportName + "\u0022 "; //"-strict experimental -c:a aac -b:a 96k 
            ffmpeg.StartInfo.FileName = "cmd.exe"; //Väljer Kommandotolken som ska startas
            ffmpeg.StartInfo.Arguments = "/k " + ffmpegPath + " " + ffmpegParams; //Start argument
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.CreateNoWindow = false;
            ffmpeg.StartInfo.RedirectStandardOutput = false;
            ffmpeg.Start(); //Startar CMD med alla information åvan



        }

        private void fileTBX_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            fileTBX.Text = (String.Concat(filePaths));
        }

        private void fileTBX_DragEnter(object sender, DragEventArgs e)  //Gör så att man kan dra in en fil i input textboxen
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void Clear()
        {
            PresetSelectCB1.Enabled = true;
            BtnChoosePreset.Enabled = true;
            resolutionCB1.Enabled = false;

            ReduceNoiseCB1.Enabled = false;

            FinterpolateCB1.Enabled = false;
            AspectRatioCB1.Enabled = false;
            deinterlaceCB1.Enabled = false;
            FPSCB1.Enabled = false;
            MaxrateCB1.Enabled = false;
            BufSizeCB1.Enabled = false;
            crfCB1.Enabled = false;
            PresetCB1.Enabled = true;
            PresetCheckB.Checked = false;
            ProfileCB1.Enabled = true;
            ProfileCheckB.Checked = true;
            LevelCB1.Enabled = false;
            LevelCheckB.Checked = false;
            AudioBitrateCB1.Enabled = false;
            VideoBitrateCB1.Enabled = false;
            CropXLocationTBX.Enabled = false;
            CropYLocationTBX.Enabled = false;
            CropXSizeTBX.Enabled = false;
            CropYSizeTBX.Enabled = false;

            PresetCB1.Enabled = false;

            VideoCutCheckB.Checked = false;
            VideoCutEndTBX.Enabled = false;
            VideoCutStartTBX.Enabled = false;

            ResCheckB.Checked = false;
            AspectRatioCheckB.Checked = false;
            DeinterlaceCheckB.Checked = false;
            FinterpolateCheckB.Checked = false;
            FPSCheckB.Checked = false;
            AudioBitrateCheckB.Checked = false;
            VideoBitrateCheckB.Checked = false;
            crfCheckB.Checked = false;
            MaxrateCheckB.Checked = false;
            BufsizeCheckB.Checked = false;
            CropCheckB.Checked = false;
            PresetCheckB.Checked = false;
            ProfileCheckB.Checked = false;
            LevelCheckB.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        { //Sätter på eller stänger av checkbboaxar osv vid start
            lblPercent.Text = "0%";
            lblCurrentTime.Text = "00:00:00";
            lblFullTime.Text = "00:00:00";

            Clear();
            this.resolutionCB1.ValueMember = "Value"; //alla Selectable true är alternativ bland upplösningarna där "4:3" och "16:9" bara är där för att visa vad som är en sådan upplösning
            this.resolutionCB1.DisplayMember = "Text";
            this.resolutionCB1.Items.AddRange(new[] {
                new ComboBoxItem() { Selectable = false, Text="16:9", Value=0}, //Bara till för att visa
                new ComboBoxItem() { Selectable = true, Text="1152x648", Value=1},
                new ComboBoxItem() { Selectable = true, Text="1280x720", Value=2},
                new ComboBoxItem() { Selectable = true, Text="1366x768", Value=3},
                new ComboBoxItem() { Selectable = true, Text="1600x900", Value=4},
                new ComboBoxItem() { Selectable = true, Text="1920x1080", Value=5},
                new ComboBoxItem() { Selectable = true, Text="2560x1440", Value=6},
                new ComboBoxItem() { Selectable = true, Text="3840x2160", Value=7},
                new ComboBoxItem() { Selectable = false, Text="4:3", Value=8},
                new ComboBoxItem() { Selectable = true, Text="640x480", Value=9},
                new ComboBoxItem() { Selectable = true, Text="800x600", Value=10},
                new ComboBoxItem() { Selectable = true, Text="960x720", Value=11},
                new ComboBoxItem() { Selectable = true, Text="1024x768", Value=12},
                new ComboBoxItem() { Selectable = true, Text="1280x960", Value=13},
                new ComboBoxItem() { Selectable = true, Text="1400x1050", Value=14},
                new ComboBoxItem() { Selectable = true, Text="1440x1080", Value=15},
            });

            this.resolutionCB1.SelectedIndexChanged += (cbSender, cbe) =>
            {
                var cb = cbSender as ComboBox;

                if (cb.SelectedItem != null && cb.SelectedItem is ComboBoxItem && ((ComboBoxItem)cb.SelectedItem).Selectable == false)
                {
                    // deselect item
                    cb.SelectedIndex = -1;
                }
            };
            fileTBX.Text = Properties.Settings.Default.fileTBXPrevious;
            OutputNameTBX.Text = Properties.Settings.Default.OutputNameTBXPrevious;

        }

        private void resolutionCB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (ResCheckB.Checked == false)
            {
                resolutionCB1.Enabled = false;
            }
            else if (ResCheckB.Checked == true)
            {
                resolutionCB1.Enabled = true;
            }
        }

        private void AspectRatioCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (AspectRatioCheckB.Checked == false)
            {
                AspectRatioCB1.Enabled = false;
            }
            else if (AspectRatioCheckB.Checked == true)
            {
                AspectRatioCB1.Enabled = true;
            }
        }

        private void DeinterlaceCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (DeinterlaceCheckB.Checked == false)
            {
                deinterlaceCB1.Enabled = false;
            }
            else if (DeinterlaceCheckB.Checked == true)
            {
                deinterlaceCB1.Enabled = true;
            }
        }

        private void FPSCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (FPSCheckB.Checked == false)
            {
                FPSCB1.Enabled = false;
            }
            else if (FPSCheckB.Checked == true)
            {
                FPSCB1.Enabled = true;
            }
        }

        private void MaxrateCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (MaxrateCheckB.Checked == false)
            {
                MaxrateCB1.Enabled = false;
            }
            else if (MaxrateCheckB.Checked == true)
            {
                MaxrateCB1.Enabled = true;
            }
        }

        private void BufsizeCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (BufsizeCheckB.Checked == false)
            {
                BufSizeCB1.Enabled = false;
            }
            else if (BufsizeCheckB.Checked == true)
            {
                BufSizeCB1.Enabled = true;
            }
        }

        private void crfCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (crfCheckB.Checked == false)
            {
                crfCB1.Enabled = false;
            }
            else if (crfCheckB.Checked == true)
            {
                crfCB1.Enabled = true;
            }
        }

        private void PresetCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (PresetCheckB.Checked == false)
            {
                PresetCB1.Enabled = false;
            }
            else if (PresetCheckB.Checked == true)
            {
                PresetCB1.Enabled = true;
            }
        }

        private void ProfileCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (ProfileCheckB.Checked == false)
            {
                ProfileCB1.Enabled = false;
            }
            else if (ProfileCheckB.Checked == true)
            {
                ProfileCB1.Enabled = true;
            }
        }

        private void LevelCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (LevelCheckB.Checked == false)
            {
                LevelCB1.Enabled = false;
            }
            else if (LevelCheckB.Checked == true)
            {
                LevelCB1.Enabled = true;
            }
        }

        private void DestinationBTN_Click(object sender, EventArgs e)
        {
            if (0 == 1) //Test kod som jag vill ska vara kvar till tidigare tester
            {
                SaveFileDialog sfd1 = new SaveFileDialog();
                if (sfd1.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(sfd1.FileName, FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(OutputNameTBX.Text);
                    }
                }
            }

            FolderBrowserDialog fbd = new FolderBrowserDialog();    //Väljer vart videon ska sparas efter export
            fbd.Description = "Custom Description";
            string sSelectedPath = string.Empty;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sSelectedPath = fbd.SelectedPath;
            }
            OutputNameTBX.Text = sSelectedPath;
            Properties.Settings.Default.OutputNameTBXPrevious = OutputNameTBX.Text;
            Properties.Settings.Default.Save();
        }

        private void PresetSelectCB1_DropDown(object sender, EventArgs e) //Välj preset konfiguration
        {
            if (!Directory.Exists(@"Presets\"))
            {
                Directory.CreateDirectory(@"Presets\");
            }
            string current = PresetSelectCB1.Text;
            DirectoryInfo d = new DirectoryInfo(@"Presets\");//Preset är mappen som kollas i
            FileInfo[] Files = d.GetFiles("*.txt"); //Sammlar alla filnamn
            PresetSelectCB1.DataSource = Files;
            PresetSelectCB1.DisplayMember = "Name";
            PresetSelectCB1.Text = current;
        }

        private void BtnChoosePreset_Click(object sender, EventArgs e) //Med denna del kan man välja preset till programmet, som är nedskrivna som txt filer i presets mappen
        {
            Clear();
            string presettext = PresetSelectCB1.Text; //Tar vad som redan visas i presets comboboxen
            if (!File.Exists(@"Presets\" + presettext)) //Gör inget om filnamnet som är inskrivet ej finns.
            {
            }
            else
            {
                string codetext = File.ReadAllText(@"Presets\" + presettext); //Letar efter filer som finns i Presets mappen
                string[] dataline = File.ReadAllLines(@"Presets\" + presettext); //Läser alla rader i filen
                using (StreamWriter w = File.AppendText(@"Presets\" + presettext))  //kollar igenom alla rader
                {
                    foreach (var line in dataline)
                    {
                        if (line.Contains("Resolution=")) //Om rad innehåller ... så gör detta, annars..
                        {
                            string lineResolution = line;
                            lineResolution = (lineResolution.Replace("Resolution=", ""));
                            resolutionCB1.Enabled = true;
                            ResCheckB.Checked = true;
                            resolutionCB1.Text = lineResolution;
                        }
                        else { } //Gör inget
                        if (line.Contains("Deinterlace=")) //samma här
                        {
                            string lineDeinterlace = line;
                            lineDeinterlace = (lineDeinterlace.Replace("Deinterlace=", ""));
                            deinterlaceCB1.Enabled = true;
                            DeinterlaceCheckB.Checked = true;
                            deinterlaceCB1.Text = lineDeinterlace;
                        }
                        else { }
                        if (line.Contains("AspectRatio=")) //och här
                        {
                            string lineAspectRatio = line;
                            lineAspectRatio = (lineAspectRatio.Replace("AspectRatio=", ""));
                            AspectRatioCB1.Enabled = true;
                            AspectRatioCheckB.Checked = true;
                            AspectRatioCB1.Text = lineAspectRatio;
                        }
                        else { }
                        if (line.Contains("FPS=")) //och så vidare
                        {
                            string lineFPS = line;
                            lineFPS = (lineFPS.Replace("FPS=", ""));
                            FPSCB1.Enabled = true;
                            FPSCheckB.Checked = true;
                            FPSCB1.Text = lineFPS;
                        }
                        else { }
                        if (line.Contains("MInterpolate=")) //och så vidare
                        {
                            string lineFinterpolate = line;
                            lineFinterpolate = (lineFinterpolate.Replace("MInterpolate=", ""));
                            FinterpolateCB1.Enabled = true;
                            FinterpolateCheckB.Checked = true;
                            FinterpolateCB1.Text = lineFinterpolate;
                        }
                        else { }
                        if (line.Contains("Maxrate=")) //Osv
                        {
                            string lineMaxrate = line;
                            lineMaxrate = (lineMaxrate.Replace("Maxrate=", ""));
                            MaxrateCB1.Enabled = true;
                            MaxrateCheckB.Checked = true;
                            MaxrateCB1.Text = lineMaxrate;
                        }
                        else { }
                        if (line.Contains("BufSize="))
                        {
                            string lineBufSize = line;
                            lineBufSize = (lineBufSize.Replace("BufSize=", ""));
                            BufSizeCB1.Enabled = true;
                            BufsizeCheckB.Checked = true;
                            BufSizeCB1.Text = lineBufSize;
                        }
                        else { }
                        if (line.Contains("CRF="))
                        {
                            string lineCRF = line;
                            lineCRF = (lineCRF.Replace("CRF=", ""));
                            crfCB1.Enabled = true;
                            crfCheckB.Checked = true;
                            crfCB1.Text = lineCRF;
                        }
                        else { }
                        if (line.Contains("VideoEncoder="))
                        {
                            string lineVideoEncoder = line;
                            lineVideoEncoder = (lineVideoEncoder.Replace("VideoEncoder=", ""));
                            VencodCB1.Enabled = true;
                            VencodCB1.Text = lineVideoEncoder;
                        }
                        else { }
                        if (line.Contains("VideoBitrate="))
                        {
                            string lineVideoBitrate = line;
                            lineVideoBitrate = (lineVideoBitrate.Replace("VideoBitrate=", ""));
                            VideoBitrateCB1.Enabled = true;
                            VideoBitrateCheckB.Checked = true;
                            VideoBitrateCB1.Text = lineVideoBitrate;
                        }
                        else { }
                        if (line.Contains("AudioBitrate="))
                        {
                            string lineAudioBitrate = line;
                            lineAudioBitrate = (lineAudioBitrate.Replace("AudioBitrate=", ""));
                            AudioBitrateCB1.Enabled = true;
                            AudioBitrateCheckB.Checked = true;
                            AudioBitrateCB1.Text = lineAudioBitrate;
                        }
                        else { }
                        if (line.Contains("SpeedPreset="))
                        {
                            string lineSpeedPreset = line;
                            lineSpeedPreset = (lineSpeedPreset.Replace("SpeedPreset=", ""));
                            PresetCB1.Enabled = true;
                            PresetCheckB.Checked = true;
                            PresetCB1.Text = lineSpeedPreset;
                        }
                        else { }
                        if (line.Contains("Profile="))
                        {
                            string lineProfile = line;
                            lineProfile = (lineProfile.Replace("Profile=", ""));
                            ProfileCB1.Enabled = true;
                            ProfileCheckB.Checked = true;
                            ProfileCB1.Text = lineProfile;
                        }
                        else { }
                        if (line.Contains("Level="))
                        {
                            string lineLevel = line;
                            lineLevel = (lineLevel.Replace("Level=", ""));
                            LevelCB1.Enabled = true;
                            LevelCheckB.Checked = true;
                            LevelCB1.Text = lineLevel;
                        }
                        else { }
                        if (line.Contains("CropXSize="))
                        {
                            string lineCropXSize = line;
                            lineCropXSize = (lineCropXSize.Replace("CropXSize=", ""));
                            CropCheckB.Checked = true;
                            CropXSizeTBX.Text = lineCropXSize;
                        }
                        else { }
                        if (line.Contains("CropYSize="))
                        {
                            string lineCropYSize = line;
                            lineCropYSize = (lineCropYSize.Replace("CropYSize=", ""));
                            CropCheckB.Checked = true;
                            CropYSizeTBX.Text = lineCropYSize;
                        }
                        else { }
                        if (line.Contains("CropXLocation="))
                        {
                            string lineCropXLocation = line;
                            lineCropXLocation = (lineCropXLocation.Replace("CropXLocation=", ""));
                            CropCheckB.Checked = true;
                            CropXLocationTBX.Text = lineCropXLocation;
                        }
                        else { }
                        if (line.Contains("CropYLocation="))
                        {
                            string lineCropYLocation = line;
                            lineCropYLocation = (lineCropYLocation.Replace("CropYLocation=", ""));
                            CropCheckB.Checked = true;
                            CropYLocationTBX.Text = lineCropYLocation;
                        }
                        else { }
                    }
                }
            }
        }

        private void AudioBitrateCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (AudioBitrateCheckB.Checked == false)
            {
                AudioBitrateCB1.Enabled = false;
            }
            else if (AudioBitrateCheckB.Checked == true)
            {
                AudioBitrateCB1.Enabled = true;
            }
        }

        private void CropCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (CropCheckB.Checked == false)
            {
                CropXSizeTBX.Enabled = false;
                CropYSizeTBX.Enabled = false;
                CropXLocationTBX.Enabled = false;
                CropYLocationTBX.Enabled = false;
            }
            else if (CropCheckB.Checked == true)
            {
                CropXSizeTBX.Enabled = true;
                CropYSizeTBX.Enabled = true;
                CropXLocationTBX.Enabled = true;
                CropYLocationTBX.Enabled = true;
            }
        }

        private void VideoBitrateCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoBitrateCheckB.Checked == false)
            {
                VideoBitrateCB1.Enabled = false;
            }
            else if (VideoBitrateCheckB.Checked == true)
            {
                VideoBitrateCB1.Enabled = true;
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ResCheckB = ResCheckB.Checked;
            Properties.Settings.Default.resolutionCB1 = resolutionCB1.Text;
            Properties.Settings.Default.AspectRatioCheckB = AspectRatioCheckB.Checked;
            Properties.Settings.Default.AspectRatioCB1 = AspectRatioCB1.Text;
            Properties.Settings.Default.fileTBX = fileTBX.Text;
            Properties.Settings.Default.Save();
        }

        private void btnLOAD_Click(object sender, EventArgs e)
        {
            ResCheckB.Checked = Properties.Settings.Default.ResCheckB;
            resolutionCB1.Text = Properties.Settings.Default.resolutionCB1;
            AspectRatioCheckB.Checked = Properties.Settings.Default.AspectRatioCheckB;
            AspectRatioCB1.Text = Properties.Settings.Default.AspectRatioCB1;
            fileTBX.Text = Properties.Settings.Default.fileTBX;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FinterpolateCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (FinterpolateCheckB.Checked == false)
            {
                FinterpolateCB1.Enabled = false;
            }
            else if (FinterpolateCheckB.Checked == true)
            {
                FinterpolateCB1.Enabled = true;
            }
        }

        private void btnRUN_Click(object sender, EventArgs e)
        {
            ProgressTimer.Enabled = true;
            VideoProgressBar.Enabled = true;

            lblPercent.Text = "0%";
            lblFullTime.Text = "00:00:00";
            lblCurrentTime.Text = "00:00:00";


            string ExportName = OutputNameTBX.Text + "\u005c" + FileNameOutputTBX.Text + FileEXTCB1.Text; //Läser in vart filen ska och vad den ska heta
            string AskOverWrite = string.Empty;
            if (File.Exists(ExportName))
            {
                string message = ExportName.ToString() + " already exists. \r\nDo you want to replace it?";
                string title = "Confirm overwrite?";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    AskOverWrite = "-y ";
                }
                else
                {
                    AskOverWrite = "-n ";
                }
            }
            string AspectRatio = string.Empty; //Aspect ratio, form på videon
            if (AspectRatioCB1.Enabled == true) //Om aktiverad så kollar den vad för värde som skrivits in
            {
                AspectRatio = "-aspect " + AspectRatioCB1.Text + " ";
            }
            else //Annars gör inget
            {
                AspectRatio = "";
            }

            string vf = string.Empty; //Samma som tidigare
            if ((resolutionCB1.Enabled || deinterlaceCB1.Enabled || CropCheckB.Checked || FinterpolateCB1.Enabled || ReduceNoiseCB1.Enabled == true))
            {
                vf = "-vf ";
            }
            else
            {
                vf = "";
            }

            string Deinterlace = string.Empty;
            if (deinterlaceCB1.Enabled == true)
            {
                Deinterlace = deinterlaceCB1.Text;
            }
            else
            {
                Deinterlace = "";
            }

            string CropNPos = string.Empty;       //WORK IN PROGRESS//https://video.stackexchange.com/questions/4563/how-can-i-crop-a-video-with-ffmpeg //
            if (deinterlaceCB1.Enabled == true)
            {
                CropNPos = ",";
            }
            if (CropCheckB.Checked == true)
            {
                //Normalt ffmpeg kommand "-filter:v \u0022 crop = 80:60:200:100 \u0022 "
                CropNPos = CropNPos + "\u0022 crop = " + CropXSizeTBX.Text + ":" + CropYSizeTBX.Text + ":" + CropXLocationTBX.Text + ":" + CropYLocationTBX.Text + " \u0022"; //kollar av vart videon ska cropas och hur mycket
                //" -filter:v " + "\u0022" + "minterpolate = 'fps=60'" + "\u0022 ";
            }
            else
            {
                CropNPos = "";
            }

            string Resolution = string.Empty;
            if (deinterlaceCB1.Enabled || CropCheckB.Checked == true)
            {
                Resolution = ",";
            }
            if (resolutionCB1.Enabled == true)
            {
                Resolution = Resolution + "scale=" + resolutionCB1.Text + "";
            }
            else
            {
                Resolution = "";
            }

            string ReduceNoise = string.Empty;
            if (deinterlaceCB1.Enabled || CropCheckB.Checked || resolutionCB1.Enabled == true)
            {
                ReduceNoise = ",";
            }
            if (ReduceNoiseCB1.Enabled == true)
            {
                ReduceNoise = ReduceNoise + ReduceNoiseCB1.Text; //"vaguedenoiser"; //"nlmeans"; //"atadenoise"; //"hqdn3d"; //"smartblur=5:0.8:0";
            }
            else
            {
                ReduceNoise = "";
            }

            string Finterpolate = string.Empty;
            if (deinterlaceCB1.Enabled || CropCheckB.Checked || resolutionCB1.Enabled || ReduceNoiseCB1.Enabled == true)
            {
                Finterpolate = ",";
            }
            if (FinterpolateCB1.Enabled == true)
            {
                Finterpolate = Finterpolate + "\u0022" + "minterpolate='fps=" + FinterpolateCB1.Text + "'" + "\u0022";
            }
            else
            {
                Finterpolate = "";
            }

            string Preset = string.Empty;
            if (PresetCB1.Enabled == true)
            {
                Preset = "-preset " + PresetCB1.Text + " ";
            }
            else
            {
                Preset = "";
            }

            string Vcodec = string.Empty;
            Vcodec = "-c:v " + VencodCB1.Text + " ";


            string VideoCut = string.Empty;
            if (VideoCutCheckB.Checked == true)
            {
                VideoCut = " -ss " + VideoCutStartTBX.Text + " -to " + VideoCutEndTBX.Text + " ";
            }
            else
            {
                VideoCut = "";
            }

            string Profile = string.Empty;
            if (ProfileCB1.Enabled == true)
            {
                Profile = "-profile:v " + ProfileCB1.Text + " ";
            }
            else
            {
                Profile = "";
            }

            string Level = string.Empty;
            if (LevelCB1.Enabled == true)
            {
                Level = "-level:v " + LevelCB1.Text + " ";
            }
            else
            {
                Level = "";
            }

            string crf = string.Empty;
            if (crfCB1.Enabled == true)
            {
                crf = "-crf " + crfCB1.Text + " ";
            }
            else
            {
                crf = "";
            }

            string Maxrate = string.Empty;
            if (MaxrateCB1.Enabled == true)
            {
                Maxrate = "-maxrate " + MaxrateCB1.Text + " ";
            }
            else
            {
                Maxrate = "";
            }

            string Bufsize = string.Empty;
            if (BufSizeCB1.Enabled == true)
            {
                Bufsize = "-bufsize " + BufSizeCB1.Text + " ";
            }
            else
            {
                Maxrate = "";
            }


            string FPS = string.Empty;
            if (FPSCB1.Enabled == true)
            {
                FPS = "-r " + FPSCB1.Text + " ";
            }
            else
            {
                FPS = "";
            }

            string AudioBitrate = string.Empty;
            if (AudioBitrateCB1.Enabled == true)
            {
                int AudioBitrateCalc = int.Parse(AudioBitrateCB1.Text) * 1000;
                AudioBitrate = "-ab " + AudioBitrateCalc + " ";
            }
            else
            {
                AudioBitrate = "";
            }

            string VideoBitrate = string.Empty;
            if (VideoBitrateCB1.Enabled == true)
            {
                double VideoBitrateCalc = double.Parse(VideoBitrateCB1.Text) * 1000000;
                VideoBitrate = "-vb " + VideoBitrateCalc + " ";
            }
            else
            {
                VideoBitrate = "";
            }
            string CustomLine = string.Empty;
            if (CustomLineCB1.Enabled == true)
            {
                CustomLine = CustomLineCB1.Text;
            }
            else
            {
                CustomLine = "";
            }

            string CopyNoEncode = string.Empty;
            if (CopyNoEncodeCheckB.Checked == true)
            {
                CopyNoEncode = "-c copy ";
            }
            else
            {
                CopyNoEncode = "";
            }
            //",hqdn3d=4.0:3.0:6.0:4.5 "
            string path = @""; //Starta i program mappen
            ffmpeg.StartInfo.FileName = path + "ffmpeg.exe";
            ffmpeg.StartInfo.Arguments = string.Format(@"-i " + "\u0022" + @fileTBX.Text + "\u0022 " + AspectRatio + vf + Deinterlace + CropNPos + Resolution + ReduceNoise + Finterpolate + VideoCut + " " + Vcodec + Preset + Profile + Level + crf + Maxrate + Bufsize + FPS + AudioBitrate + VideoBitrate + CustomLine + " -movflags +faststart " + CopyNoEncode + AskOverWrite + "\u0022" + ExportName + "\u0022 ");
            if (CMDCheckB.Checked == false)
            {
                ffmpeg.StartInfo.UseShellExecute = false; //false
                ffmpeg.StartInfo.CreateNoWindow = true; //true
                ffmpeg.StartInfo.RedirectStandardError = true; //true
                ffmpeg.StartInfo.RedirectStandardInput = true; //true
                ffmpeg.Start();

                Console.SetIn(ffmpeg.StandardError);
                Action _loop = () =>
                {
                    string _line = null;
                    while (true)
                    {
                        _line = Console.ReadLine();
                        if (_line == null)// if ffmpeg.exe exit , ReadLine would return null
                            break;
                        this.UpdateProgress(_line);
                    }
                };
                var _result = _loop.BeginInvoke(null, null);
            }
            else if (CMDCheckB.Checked == true)
            {
                ffmpeg.StartInfo.UseShellExecute = true; //false
                ffmpeg.StartInfo.CreateNoWindow = false; //true
                ffmpeg.StartInfo.RedirectStandardError = false; //true
                ffmpeg.StartInfo.RedirectStandardInput = false; //true
                ffmpeg.Start();
            }
            
        }

        private void UpdateProgress(string _line)
        {
            string output;
            if (this.InvokeRequired)
            {
                Action<string> _updater = this.UpdateProgress;
                this.Invoke(_updater, _line);
            }
            else
            {
                outputFFMPEG = (_line);
                // Duration: 00:02:09.56, start: 0.000000, bitrate: 19459 kb/s
                VideoLength = getBetween(outputFFMPEG, "Duration: ", ", ");
                if (VideoLength.Length > 0)
                {
                    TimeSpan VideoLengthRAW = TimeSpan.Parse(VideoLength);
                    totalSecondsVideoLength = (int)VideoLengthRAW.TotalMilliseconds;
                    //DEBUG  AspectRatioLBL.Text = totalSecondsVideoLength.ToString();
                }
                else { }

                if (outputFFMPEG == null)
                {

                }
                else
                {
                    CurrentVideoProgress = getBetween(outputFFMPEG, "time=", " ");
                    if (CurrentVideoProgress.Length > 0)
                    {
                        TimeSpan CurrentVideoProgressRAW = TimeSpan.Parse(CurrentVideoProgress);
                        totalSecondsCurrentProgress = (int)CurrentVideoProgressRAW.TotalMilliseconds;
                        //DEBUG lblCrop.Text = totalSecondsCurrentProgress.ToString();

                    }
                    else
                    {

                    }
                }



                this.OUTPUTTBX.AppendText(_line + "\r\n");
                this.OUTPUTTBX.ScrollToCaret();
            }
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            string millisec;

            int intVideoProgress = totalSecondsCurrentProgress / 1000;
            int intVideoLength = totalSecondsVideoLength / 1000;
            VideoProgressBar.Minimum = 0;
            VideoProgressBar.Maximum = intVideoLength; //100   //(int) totalSeconds
            int hoursCurrent = totalSecondsCurrentProgress / 3600000;
            int minsCurrent = (totalSecondsCurrentProgress) / 60000 % 3600;
            int secCurrent = totalSecondsCurrentProgress / 1000 % 60;
            int msCurrent = totalSecondsCurrentProgress % 1000 / 10;
            if (millisecondCheckB.Checked == true)
            {
                millisec = ".{3:D2}";
            }
            else
            {
                millisec = "";
            }
            lblCurrentTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}" + millisec, hoursCurrent, minsCurrent, secCurrent, msCurrent);
            int hoursVideoLength = totalSecondsVideoLength / 3600000;
            int minsVideoLength = (totalSecondsVideoLength) / 60000 % 3600;
            int secVideoLength = totalSecondsVideoLength / 1000 % 60;
            int msVideoLength = totalSecondsVideoLength % 1000 / 10;
            lblFullTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}" + millisec, hoursVideoLength, minsVideoLength, secVideoLength, msVideoLength);
            lblPercent.Text = ((int)Math.Round((double)(100 * totalSecondsCurrentProgress) / totalSecondsVideoLength)).ToString() + "%";
            //lblFullTime.Text = totalSecondsVideoLength.ToString();
            //lblCurrentTime.Text = totalSecondsCurrentProgress.ToString();
            if (totalSecondsVideoLength > 0)
            {


                if (intVideoProgress == intVideoLength)
                {
                    VideoProgressBar.Value = intVideoLength;
                }
                else if (intVideoProgress < intVideoLength) //fix
                {
                    VideoProgressBar.Value = intVideoProgress;
                }
                else { }
            }
            else { }
            if (totalSecondsVideoLength == 0)
            {
            }
            else
            {
                if (VideoProgressBar.Maximum == totalSecondsVideoLength)
                {
                    ProgressTimer.Stop();
                    VideoProgressBar.Value = totalSecondsVideoLength;
                }
            }
        }

        public void Cancel_Click(object sender, EventArgs e)
        {
            if (CMDCheckB.Checked == false)
            {
                ffmpeg.StandardInput.WriteLine("q");
            }
        }

        void ExportPreset()
        {
            using (StreamWriter writetext = new StreamWriter(@"Presets\" + PresetSelectCB1.Text + DotTxt))
            {
                writetext.WriteLine("FFMPEG UI PRESET CONFIG:");
                if (resolutionCB1.Enabled == true)
                {
                    writetext.WriteLine("Resolution=" + resolutionCB1.Text);
                }
                else { }
                if (deinterlaceCB1.Enabled == true)
                {
                    writetext.WriteLine("Deinterlace=" + deinterlaceCB1.Text);
                }
                else { }
                if (AspectRatioCB1.Enabled == true)
                {
                    writetext.WriteLine("AspectRatio=" + AspectRatioCB1.Text);
                }
                else { }
                if (FPSCB1.Enabled == true)
                {
                    writetext.WriteLine("FPS=" + FPSCB1.Text);
                }
                else { }
                if (FinterpolateCB1.Enabled == true)
                {
                    writetext.WriteLine("MInterpolate=" + FinterpolateCB1.Text);
                }
                else { }
                if (MaxrateCB1.Enabled == true)
                {
                    writetext.WriteLine("Maxrate=" + MaxrateCB1.Text);
                }
                else { }
                if (BufSizeCB1.Enabled == true)
                {
                    writetext.WriteLine("BufSize=" + BufSizeCB1.Text);
                }
                else { }
                if (crfCB1.Enabled == true)
                {
                    writetext.WriteLine("CRF=" + crfCB1.Text);
                }
                else { }
                if (VencodCB1.Enabled == true)
                {
                    writetext.WriteLine("VideoEncoder=" + VencodCB1.Text);
                }
                else { }
                if (VideoBitrateCB1.Enabled == true)
                {
                    writetext.WriteLine("VideoBitrate=" + VideoBitrateCB1.Text);
                }
                else { }
                if (AudioBitrateCB1.Enabled == true)
                {
                    writetext.WriteLine("AudioBitrate=" + AudioBitrateCB1.Text);
                }
                else { }
                if (PresetCB1.Enabled == true)
                {
                    writetext.WriteLine("SpeedPreset=" + PresetCB1.Text);
                }
                else { }
                if (ProfileCB1.Enabled == true)
                {
                    writetext.WriteLine("Profile=" + ProfileCB1.Text);
                }
                else { }
                if (LevelCB1.Enabled == true)
                {
                    writetext.WriteLine("Level=" + LevelCB1.Text);
                }
                else { }
                if (CropCheckB.Checked == true)
                {
                    writetext.WriteLine("CropXSize=" + CropXSizeTBX.Text);
                    writetext.WriteLine("CropYSize=" + CropYSizeTBX.Text);
                    writetext.WriteLine("CropXLocation=" + CropXLocationTBX.Text);
                    writetext.WriteLine("CropYLocation=" + CropYLocationTBX.Text);
                }
                else { }
            }
        }

        private void btnExportPreset_Click(object sender, EventArgs e)
        {
            if (PresetSelectCB1.Text.Contains(".txt"))
            {
                DotTxt = "";
            }
            else
            { DotTxt = ".txt"; }
            string filname = @"Presets\" + PresetSelectCB1.Text + DotTxt;
            if (File.Exists(filname))
            {
                string message = PresetSelectCB1.Text + " already exists. \r\nDo you want to replace it?";
                string title = "Confirm overwrite?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ExportPreset();
                }
                else
                { }
            }
            else
            {
                ExportPreset();
            }
        }

        private void btnDeletePreset_Click(object sender, EventArgs e)
        {
            if (PresetSelectCB1.Text.Contains(".txt"))
            {
                DotTxt = "";
            }
            else
            { DotTxt = ".txt"; }
            if (File.Exists(@"Presets\" + PresetSelectCB1.Text + DotTxt))
            {
                string message = "Do you want to delete " + PresetSelectCB1.Text + "?";
                string title = "Delete file?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    File.Delete(@"Presets\" + PresetSelectCB1.Text + DotTxt);
                    PresetSelectCB1.Text = "";
                }
                else
                { }
            }
            else
            { }
        }

        private void VideoCutCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoCutCheckB.Checked == false)
            {
                VideoCutStartTBX.Enabled = false;
                VideoCutEndTBX.Enabled = false;
            }
            else if (VideoCutCheckB.Checked == true)
            {
                VideoCutStartTBX.Enabled = true;
                VideoCutEndTBX.Enabled = true;
            }
        }

        private void ReduceNoiseCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (ReduceNoiseCheckB.Checked == false)
            {
                ReduceNoiseCB1.Enabled = false;
            }
            else if (ReduceNoiseCheckB.Checked == true)
            {
                ReduceNoiseCB1.Enabled = true;
            }
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ffmpegCombine = new System.Diagnostics.Process();
            string path = @""; //Starta i program mappen

            string ffmpegPath = System.IO.Path.Combine(path, "ffmpeg.exe");


            using (StreamWriter writetext = new StreamWriter(@"" + "CombineList.txt"))
            {
                writetext.WriteLine(@"file '" + fileCombineTBX1.Text + "'");
                writetext.WriteLine(@"file '" + fileCombineTBX2.Text + "'");
                //if (resolutionCB1.Enabled == true)
                //{
                //    writetext.WriteLine("Resolution=" + resolutionCB1.Text);
                //}
                //else { }
            }



            string ffmpegParams = "-safe 0 -f concat -i CombineList.txt -c copy output.mp4";
            ffmpegCombine.StartInfo.FileName = "cmd.exe";
            ffmpegCombine.StartInfo.Arguments = "/k " + ffmpegPath + " " + ffmpegParams;
            ffmpegCombine.Start();
        }

        private void fileselectCombineBTN1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCombine1 = new OpenFileDialog //Välja input fil
            {
                InitialDirectory = @"B:\Videos",
                Title = "Browse Video Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Video files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialogCombine1.ShowDialog() == DialogResult.OK) //Skickar filvägen till input fileTBX rutan
            {
                fileCombineTBX1.Text = openFileDialogCombine1.FileName;
            }
        }

        private void fileselectCombineBTN2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCombine2 = new OpenFileDialog //Välja input fil
            {
                InitialDirectory = @"B:\Videos",
                Title = "Browse Video Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Video files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialogCombine2.ShowDialog() == DialogResult.OK) //Skickar filvägen till input fileTBX rutan
            {
                fileCombineTBX2.Text = openFileDialogCombine2.FileName;
            }
        }

        private void CopyNoEncodeCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (CopyNoEncodeCheckB.Checked == false)
            {
                crfCheckB.Enabled = true;
                crfCB1.Enabled = true;
                MaxrateCheckB.Enabled = true;
                MaxrateCB1.Enabled = true;
                BufsizeCheckB.Enabled = true;
                BufSizeCB1.Enabled = true;
                AudioBitrateCheckB.Enabled = true;
                AudioBitrateCB1.Enabled = true;
                VideoBitrateCheckB.Enabled = true;
                VideoBitrateCB1.Enabled = true;
                resolutionCB1.Enabled = true;
                ResCheckB.Enabled = true;
                AspectRatioCB1.Enabled = true;
                AspectRatioCheckB.Enabled = true;
                ReduceNoiseCB1.Enabled = true;
                ReduceNoiseCheckB.Enabled = true;
                deinterlaceCB1.Enabled = true;
                DeinterlaceCheckB.Enabled = true;
                FPSCB1.Enabled = true;
                FPSCheckB.Enabled = true;
                FinterpolateCB1.Enabled = true;
                FinterpolateCheckB.Enabled = true;
                CropCheckB.Enabled = true;
                CropXSizeTBX.Enabled = true;
                CropYSizeTBX.Enabled = true;
                CropXLocationTBX.Enabled = true;
                CropYLocationTBX.Enabled = true;
                PresetCB1.Enabled = true;
                PresetCheckB.Enabled = true;
                ProfileCB1.Enabled = true;
                ProfileCheckB.Enabled = true;
                LevelCB1.Enabled = true;
                LevelCheckB.Enabled = true;
            }
            else if (CopyNoEncodeCheckB.Checked == true)
            {
                crfCheckB.Enabled = false;
                crfCB1.Enabled = false;
                MaxrateCheckB.Enabled = false;
                MaxrateCB1.Enabled = false;
                BufsizeCheckB.Enabled = false;
                BufSizeCB1.Enabled = false;
                AudioBitrateCheckB.Enabled = false;
                AudioBitrateCB1.Enabled = false;
                VideoBitrateCheckB.Enabled = false;
                VideoBitrateCB1.Enabled = false;
                resolutionCB1.Enabled = false;
                ResCheckB.Enabled = false;
                AspectRatioCB1.Enabled = false;
                AspectRatioCheckB.Enabled = false;
                ReduceNoiseCB1.Enabled = false;
                ReduceNoiseCheckB.Enabled = false;
                deinterlaceCB1.Enabled = false;
                DeinterlaceCheckB.Enabled = false;
                FPSCB1.Enabled = false;
                FPSCheckB.Enabled = false;
                FinterpolateCB1.Enabled = false;
                FinterpolateCheckB.Enabled = false;
                CropCheckB.Enabled = false;
                CropXSizeTBX.Enabled = false;
                CropYSizeTBX.Enabled = false;
                CropXLocationTBX.Enabled = false;
                CropYLocationTBX.Enabled = false;
                PresetCB1.Enabled = false;
                PresetCheckB.Enabled = false;
                ProfileCB1.Enabled = false;
                ProfileCheckB.Enabled = false;
                LevelCB1.Enabled = false;
                LevelCheckB.Enabled = false;
            }
        }

        private void ReduceNoiseBTN_Click(object sender, EventArgs e)
        {

        }

        private void CustomLineCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomLineCheckB.Checked == false)
            {
                CustomLineCB1.Enabled = false;
            }
            else if (CustomLineCheckB.Checked == true)
            {
                CustomLineCB1.Enabled = true;
            }
        }
    }
}
