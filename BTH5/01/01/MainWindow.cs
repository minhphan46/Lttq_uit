using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class MainWindow : Form
    {
        int x, y, space = 5;

        public MainWindow()
        {
            InitializeComponent();
            x = y = 200;
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            drawString(x, y);
        }

        void drawString(int x, int y)
        {
            Graphics draw = this.CreateGraphics();
            var font = new Font(new FontFamily("Arial"), 20, FontStyle.Bold, GraphicsUnit.Pixel);
            var solidBrush = new SolidBrush(Color.Red);
            draw.DrawString("Phan Xuân Quang - 20521008", font, solidBrush, new PointF(x, y));
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    y -= space;
                    this.Refresh();
                    drawString(x, y);
                    break;
                case Keys.Down:
                    y += space;
                    this.Refresh();
                    drawString(x, y);
                    break;
                case Keys.Left:
                    x -= space;
                    this.Refresh();
                    drawString(x, y);
                    break;
                case Keys.Right:
                    x += space;
                    this.Refresh();
                    drawString(x, y);
                    break;
            }
        }
    }
}
