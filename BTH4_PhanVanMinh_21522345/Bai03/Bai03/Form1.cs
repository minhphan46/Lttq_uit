using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public string songPath = "";
        public Form1()
        {
            InitializeComponent();
            tlsLb.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("HH:mm:ss tt");
            timer1.Enabled = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video/sound File|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3";
            ofd.Title = "Open";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                songPath = ofd.FileName;
                //filenames = ofd.SafeFileName;
            }
            player.URL = songPath;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tlsLb.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
