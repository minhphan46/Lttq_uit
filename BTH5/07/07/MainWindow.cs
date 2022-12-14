using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            clock.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Application.StartupPath, "digital-7.ttf"));
            timeLabel.Font = new Font(pfc.Families[0], 100, FontStyle.Bold);
            updateTime();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            updateTime();
        }

        void updateTime()
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            timeLabel.Left = this.Width / 2 - timeLabel.Width / 2;
        }
    }
}
