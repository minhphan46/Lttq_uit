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

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbb_shape.Text = "Filled Ellipse";
        }

        private void cbb_shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Color color = Color.DarkRed;
            switch (cbb_shape.Text)
            {
                case "Circle":
                    DrawEllipse(200, 200, color, g);
                    break;
                case "Square":
                    DrawRectangle(200, 200, color, g);
                    break;
                case "Ellipse":
                    DrawEllipse(200, 100, color, g);
                    break;
                case "Pie":
                    DrawPie(200, 200, 300, color, g);
                    break;
                case "Filled Circle":
                    DrawFilledEllipse(200, 200, color, g);
                    break;
                case "Filled Square":
                    DrawFilledRectangle(200, 200, color, g);
                    break;
                case "Filled Ellipse":
                    DrawFilledEllipse(200, 100, color, g);
                    break;
                case "Filled Pie":
                    DrawFilledPie(200, 200, 300, color, g);
                    break;
            }
        }
        // draw fuction
        private void DrawEllipse(int width, int height, Color color, Graphics g)
        {
            Pen blackPen = new Pen(color, 5);
            g.DrawEllipse(blackPen, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height);
        }
        private void DrawRectangle(int width, int height, Color color, Graphics g)
        {
            Pen blackPen = new Pen(color, 4);
            g.DrawRectangle(blackPen, new Rectangle(this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height));
        }
        private void DrawPie(int width, int height, int angle, Color color, Graphics g)
        {
            Pen blackPen = new Pen(color, 4);
            g.DrawPie(blackPen, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height, 25, angle);
        }
        private void DrawFilledEllipse(int width, int height, Color color, Graphics g)
        {
            SolidBrush blackPen = new SolidBrush(color);
            g.FillEllipse(blackPen, new Rectangle(this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height));
        }
        private void DrawFilledRectangle(int width, int height, Color color, Graphics g)
        {
            SolidBrush blackPen = new SolidBrush(color);
            g.FillRectangle(blackPen, new Rectangle(this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height));
        }
        private void DrawFilledPie(int width, int height, int angle, Color color, Graphics g)
        {
            SolidBrush blackPen = new SolidBrush(color);
            g.FillPie(blackPen, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height, 25, angle);
        }
    }
}
