using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("hh:mm:ss");
            lb_time.Left = this.Width / 2 - lb_time.Width / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Application.StartupPath, "Font\\digital-7.ttf"));
            lb_time.Font = new Font(pfc.Families[0], 100, FontStyle.Bold);
        }
    }
}
