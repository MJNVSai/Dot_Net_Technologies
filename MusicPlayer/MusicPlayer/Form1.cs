using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 50;
            label2.Text = "50 %";
        }

        string[] paths, files;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Double Click On The List Box.
            Player.URL = paths[listBox1.SelectedIndex];
            Player.Ctlcontrols.play();

            try
            {
                var file = TagLib.File.Create(paths[listBox1.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {
                // Empty Catch Block..
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Stop Button
            Player.Ctlcontrols.stop();
            progressBar1.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Pause Button
            Player.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Play Button
            Player.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Next Button
            if(listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Preview Button

            if(listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Timer
            if(Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)Player.Ctlcontrols.currentPosition;

                try
                {
                    label3.Text = Player.Ctlcontrols.currentPositionString;
                    label4.Text = Player.Ctlcontrols.currentItem.durationString.ToString();

                }
                catch
                {
                    // Empty  Catch Block
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // track Bar Or Sound bar
            Player.settings.volume = trackBar1.Value;
            label2.Text = trackBar1.Value.ToString() + " %";
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            // Mouse Down Event
            Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / progressBar1.Width;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Exit Button
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Open Button
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;

                for(int x = 0; x < files.Length; x++)
                {
                    listBox1.Items.Add(files[x]);
                }
            }
        }
    }
}
