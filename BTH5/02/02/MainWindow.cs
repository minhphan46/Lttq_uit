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

namespace _02
{
    public partial class MainWindow : Form
    {
        int x, y;

        Rectangle rectangle;

        public MainWindow()
        {
            InitializeComponent();
            

            x = this.Width / 2 - 100;
            y = this.Height / 2 - 100;

            rectangle = new Rectangle(x, y, 200, 200);
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    rectangle.X -= 5;
                    this.Refresh();
                    break;
                case Keys.Right:
                    rectangle.X += 5;
                    this.Refresh();
                    break;
                case Keys.Up:
                    rectangle.Y -= 5;
                    this.Refresh();
                    break;
                case Keys.Down:
                    rectangle.Y += 5;
                    this.Refresh();
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, rectangle);
        }
    }
}
