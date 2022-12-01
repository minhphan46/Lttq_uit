using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_change_color_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            BackColor = randomColor;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            BackColor = DefaultBackColor;
        }
    }
}
