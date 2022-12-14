using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        int x, y, radius;

        public Form1()
        {
            InitializeComponent();
            radius = 80;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Refresh();
                x = e.X;
                y = e.Y;
                drawCircel();
            }
        }
        private void drawCircel()
        {
            if (radius <= 0) radius = 0;
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Blue, 4);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawCircle(pen, x, y, radius);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Oemplus:
                    radius += 10;
                    this.Refresh();
                    drawCircel();
                    break;
                case Keys.OemMinus:
                    radius -= 10;
                    this.Refresh();
                    drawCircel();
                    break;
            }
        }
    }
}
