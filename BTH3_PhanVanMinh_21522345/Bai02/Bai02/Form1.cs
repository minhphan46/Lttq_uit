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
    public partial class PaintEvent : Form
    {
        Label lb = new Label();
        static Random rand = new Random();
        public int top = 0;
        public int left = 0;
        public PaintEvent()
        {
            InitializeComponent();
            lb.Text = "Paint Event";
            lb.Location = new Point(0, 0);
            Controls.Add(lb);
            this.Paint += Form1_Paint;
            FormClosing += Form1_FormClosing;
        }

        private void btn_paint_Click(object sender, EventArgs e)
        {
            top = rand.Next(0, Location.X);
            left = rand.Next(0, Location.Y);
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            lb.Location = new Point(top, left);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat khong?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            top = 0;
            left = 0;
            this.Invalidate();
        }
    }
}
