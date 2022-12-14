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

namespace _09
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            shapeComboBox.Text = "Filled Ellipse";
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            switch (shapeComboBox.Text)
            {
                case "Circle":
                    DrawEllipse(200, 200);
                    break;
                case "Square":
                    DrawRectangle(200, 200);
                    break;
                case "Ellipse":
                    DrawEllipse(200, 100);
                    break;
                case "Pie":
                    DrawPie(200, 200, 300);
                    break;
                case "Filled Circle":
                    DrawFilledEllipse(200, 200);
                    break;
                case "Filled Square":
                    DrawFilledRectangle(200, 200);
                    break;
                case "Filled Ellipse":
                    DrawFilledEllipse(200, 100);
                    break;
                case "Filled Pie":
                    DrawFilledPie(200, 200, 300);
                    break;
            }
        }

        private void shapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();   
        }

        // Shape
        private void DrawEllipse(int width, int height)
        {
            Graphics draw = this.CreateGraphics();
            Pen blackPen = new Pen(Color.FromArgb(139, 0, 0), 5);
            draw.SmoothingMode = SmoothingMode.AntiAlias;
            draw.DrawEllipse(blackPen, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height);
        }
        private void DrawRectangle(int width, int height)
        {
            Graphics draw = this.CreateGraphics();
            Pen blackPen = new Pen(Color.FromArgb(139, 0, 0), 4);
            draw.SmoothingMode = SmoothingMode.AntiAlias;
            draw.DrawRectangle(blackPen, new Rectangle(this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height));
        }
        private void DrawPie(int width, int height, int angle)
        {
            Graphics draw = this.CreateGraphics();
            Pen blackPen = new Pen(Color.FromArgb(139, 0, 0), 4);
            draw.SmoothingMode = SmoothingMode.AntiAlias;
            draw.DrawPie(blackPen, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height, 0, angle);
        }
        
        // Filled Shape
        private void DrawFilledEllipse(int width, int height)
        {
            Graphics draw = this.CreateGraphics();
            SolidBrush blackPen = new SolidBrush(Color.FromArgb(139, 0, 0));
            draw.SmoothingMode = SmoothingMode.AntiAlias;
            draw.FillEllipse(blackPen, new Rectangle(this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height));
        }
        private void DrawFilledRectangle(int width, int height)
        {
            Graphics draw = this.CreateGraphics();
            SolidBrush blackPen = new SolidBrush(Color.FromArgb(139, 0, 0));
            draw.SmoothingMode = SmoothingMode.AntiAlias;
            draw.FillRectangle(blackPen, new Rectangle(this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height));
        }
        private void DrawFilledPie(int width, int height, int angle)
        {
            Graphics draw = this.CreateGraphics();
            SolidBrush blackPen = new SolidBrush(Color.FromArgb(139, 0, 0));
            draw.SmoothingMode = SmoothingMode.AntiAlias;
            draw.FillPie(blackPen, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height, 0, angle);
        }
    }
}
