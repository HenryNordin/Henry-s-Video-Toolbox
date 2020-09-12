using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ffmpegUI
{
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

        private void fileTBX_TextChanged(object sender, EventArgs e)
        {

        }
        private void fileselectBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
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

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileTBX.Text = openFileDialog1.FileName;
            }
        }

        private void btnDEBUG_Click(object sender, EventArgs e)
        {
            string ExportName = OutputNameTBX.Text + "\u005c" + FileNameOutputTBX.Text + FileEXTCB1.Text;

            string AspectRatio = string.Empty;
            if (AspectRatioCB1.Enabled == true)
            {
                AspectRatio = "-aspect " + AspectRatioCB1.Text + " ";
            }
            else
            {
                AspectRatio = "";
            }

            string vf = string.Empty;
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

            

            string path = @"";
            string ffmpegPath = System.IO.Path.Combine(path, "ffmpeg.exe");
            string ffmpegParams = "-i \u0022" + @fileTBX.Text + "\u0022 " + AspectRatio + vf + Deinterlace + Resolution + "-c:v libx264 " + Preset + Profile + crf + Maxrate + Bufsize + FPS + "-ac 2 -strict experimental -c:a aac -b:a 96k -movflags +faststart -y " + "\u0022"  + ExportName + "\u0022 ";
            var ffmpeg = new System.Diagnostics.Process();
            ffmpeg.StartInfo.FileName = "cmd.exe";
            ffmpeg.StartInfo.Arguments = "/k " + ffmpegPath + " " + ffmpegParams;
            ffmpeg.Start();
        }

        private void fileTBX_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void fileTBX_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resolutionCB1.Enabled = false;
            AspectRatioCB1.Enabled = false;
            deinterlaceCB1.Enabled = false;
            FPSCB1.Enabled = false;
            MaxrateCB1.Enabled = false;
            BufSizeCB1.Enabled = false;
            crfCB1.Enabled = false;
            PresetCB1.Enabled = true;
            PresetCheckB.Checked = true;
            ProfileCB1.Enabled = true;
            ProfileCheckB.Checked = true;

            this.resolutionCB1.ValueMember = "Value";
            this.resolutionCB1.DisplayMember = "Text";
            this.resolutionCB1.Items.AddRange(new[] {
            new ComboBoxItem() { Selectable = false, Text="16:9", Value=0},
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

        private void DestinationBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
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
            resolutionCB1.Text = "720x576";
            deinterlaceCB1.Text = "yadif=1";
            AspectRatioCB1.Text = "4:3";
            crfCB1.Text = "1";
            MaxrateCB1.Text = "15M";
            BufSizeCB1.Text = "15M";
            resolutionCB1.Enabled = true;
            AspectRatioCB1.Enabled = true;
            deinterlaceCB1.Enabled = true;
            FPSCB1.Enabled = false;
            MaxrateCB1.Enabled = true;
            BufSizeCB1.Enabled = true;
            crfCB1.Enabled = true;
            PresetCB1.Enabled = true;
            ProfileCB1.Enabled = true;
            PresetCheckB.Checked = true;
            ProfileCheckB.Checked = true;
            ResCheckB.Checked = true;
            AspectRatioCheckB.Checked = true;
            DeinterlaceCheckB.Checked = true;
            FPSCheckB.Checked = false;
            MaxrateCheckB.Checked = true;
            BufsizeCheckB.Checked = true;
            crfCheckB.Checked = true;

        }
    }
}
