using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ffmpegUI
{
    using Microsoft.CSharp;
    using System.CodeDom.Compiler;
    public partial class Form1 : Form
    {
        private class ComboBoxItem
        {
            public int Value { get; set; }
            public string Text { get; set; }
            public bool Selectable { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void fileTBX_TextChanged(object sender, EventArgs e){}
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
        }
        public double Progress { get; set; }
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
            if ((resolutionCB1.Enabled || deinterlaceCB1.Enabled == true))
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

            string Resolution = string.Empty;
            if ((resolutionCB1.Enabled && deinterlaceCB1.Enabled == true))
            {
                Resolution = ",scale=" + resolutionCB1.Text + " ";
            }
            else if (resolutionCB1.Enabled == true)
            {
                Resolution = "scale=" + resolutionCB1.Text + " ";
            }
            else
            {
                Resolution = " ";
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

            string CropNPos = string.Empty;       //WORK IN PROGRESS//https://video.stackexchange.com/questions/4563/how-can-i-crop-a-video-with-ffmpeg //
            if (CropCheckB.Checked == true)
            {
                //Normalt ffmpeg kommand "-filter:v \u0022 crop = 80:60:200:100 \u0022 "
                CropNPos = "-filter:v \u0022 crop = " + CropXSizeTBX.Text + ":" + CropYSizeTBX.Text + ":" + CropXLocationTBX.Text + ":" + CropYLocationTBX.Text + " \u0022"; //kollar av vart videon ska cropas och hur mycket
            }
            else
            {
                CropNPos = "";
            }


            string path = @""; //Starta i program mappen
            string ffmpegPath = System.IO.Path.Combine(path, "ffmpeg.exe"); //Programmer som ska öppnas och nedan finns paramerterna vilket säger till om vad som ska göras när programet går igång.
            string ffmpegParams = "-i \u0022" + @fileTBX.Text + "\u0022 " + AspectRatio + vf + Deinterlace + Resolution + Vcodec + Preset + Profile + Level + crf + Maxrate + Bufsize + FPS + AudioBitrate + CropNPos +  " -movflags +faststart -y " + "\u0022"  + ExportName + "\u0022 "; //"-strict experimental -c:a aac -b:a 96k 
            var ffmpeg = new System.Diagnostics.Process(); //Ny process
            ffmpeg.StartInfo.FileName = "cmd.exe"; //Väljer Kommandotolken som ska startas
            ffmpeg.StartInfo.Arguments = "/k " + ffmpegPath + " " + ffmpegParams; //Start argument
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
            CropXLocationTBX.Enabled = false;
            CropYLocationTBX.Enabled = false;
            CropXSizeTBX.Enabled = false;
            CropYSizeTBX.Enabled = false;

            ResCheckB.Checked = false;
            AspectRatioCheckB.Checked = false;
            DeinterlaceCheckB.Checked = false;
            FPSCheckB.Checked = false;
            AudioBitrateCheckB.Checked = false;
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

            this.resolutionCB1.SelectedIndexChanged += (cbSender, cbe) => {
                var cb = cbSender as ComboBox;

                if (cb.SelectedItem != null && cb.SelectedItem is ComboBoxItem && ((ComboBoxItem)cb.SelectedItem).Selectable == false)
                {
                    // deselect item
                    cb.SelectedIndex = -1;
                }
            };

        }

        private void resolutionCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ResCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (ResCheckB.Checked == false) {
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
        }

        private void PS2PALPRESETBTN_Click(object sender, EventArgs e)
        {
        }

        private void PresetSelectCB1_DropDown(object sender, EventArgs e) //Välj preset konfiguration
        {
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
                        if (line.Contains("AudioBitrate="))
                        {
                            string lineAudioBitrate = line;
                            lineAudioBitrate = (lineAudioBitrate.Replace("AudioBitrate=", ""));
                            AudioBitrateCB1.Enabled = true;
                            AudioBitrateCheckB.Checked = true;
                            AudioBitrateCB1.Text = lineAudioBitrate;
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
    }
}
