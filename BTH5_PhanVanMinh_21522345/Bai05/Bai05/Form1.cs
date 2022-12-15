using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string text = "ĐH CNTT";
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawString(20, 10, "Times New Roman", 15, FontStyle.Bold, Color.FromArgb(248, 146, 132));
            DrawString(20, 30, "Arial", 42, FontStyle.Bold, Color.FromArgb(0, 0, 128));
            DrawString(20, 85, "Arial", 42, FontStyle.Bold | FontStyle.Italic, Color.FromArgb(218, 112, 214));
            DrawString(20, 125, "Segoe UI", 60, FontStyle.Bold, Color.FromArgb(255, 105, 180));
        }
        private void DrawString(int x, int y, string fontName, float fontSize, FontStyle fontStyle, Color textColor)
        {
            try
            {
                Graphics g = CreateGraphics();
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                Font font = new Font(fontName, fontSize, fontStyle);
                g.DrawString(text, font, new SolidBrush(textColor), x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Loi DrawString");
            }
        }
    }
}
