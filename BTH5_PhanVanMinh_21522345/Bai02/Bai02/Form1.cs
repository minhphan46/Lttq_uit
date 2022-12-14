using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        int x, y;
        int size = 100;
        Rectangle rectangle;
        bool isMove = false;
        public Form1()
        {
            InitializeComponent();
            x = y = 100;
            rectangle = new Rectangle(x, y, size, size);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, rectangle);
        }

        int xMouseInR = 0;
        int yMouseInR = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove)
            {
                x = e.X - xMouseInR;
                y = e.Y - yMouseInR;
                rectangle = new Rectangle(x, y, size, size);
                Refresh();
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.X >= x && e.X <= x+ size && e.Y >= y  && e.Y <= y + size)
            {
                isMove = true;
                xMouseInR = e.X - x;
                yMouseInR = e.Y - y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove= false;
        }
    }
}
