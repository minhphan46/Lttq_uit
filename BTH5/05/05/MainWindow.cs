using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void drawString(int x, int y, string fontName, int fontSize, FontStyle fontStyle, Color color)
        {
            Graphics draw = this.CreateGraphics();
            draw.TextRenderingHint = TextRenderingHint.AntiAlias;
            draw.DrawString("ĐH CNTT", new Font(fontName, fontSize, fontStyle), new SolidBrush(color), x, y);
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            drawString(20, 10, "Times New Roman", 15, FontStyle.Bold, Color.FromArgb(248, 146, 132));
            drawString(20, 30, "Arial", 42, FontStyle.Bold, Color.FromArgb(0, 0, 128));
            drawString(20, 85, "Arial", 42, FontStyle.Bold | FontStyle.Italic, Color.FromArgb(218, 112, 214));
            drawString(20, 125, "Segoe UI", 60, FontStyle.Bold, Color.FromArgb(255, 105, 180));
        }
    }
}
