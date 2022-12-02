using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt");
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt");
        }
    }
}
