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

namespace _03
{
    public partial class MainWindow : Form
    {
        circle c;

        public MainWindow()
        {
            InitializeComponent();
            c = new circle(200, 200, Color.Red);
        }

        private void MainWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Refresh();
                c.x = e.X;
                c.y = e.Y;
                Draw(c);
            }
        }

        private void Draw(circle Circle)
        {
            Graphics draw = this.CreateGraphics();
            Pen blackPen = new Pen(Circle.borderColor, 4);
            draw.SmoothingMode = SmoothingMode.AntiAlias;
            draw.DrawEllipse(blackPen, Circle.x - Circle.radius / 2, Circle.y - Circle.radius / 2, Circle.radius, Circle.radius);
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Oemplus:
                    c.radius += 5;
                    this.Refresh();
                    Draw(c);
                    break;
                case Keys.OemMinus:
                    c.radius -= 5;
                    this.Refresh();
                    Draw(c);
                    break;
            }
        }
    }
}
