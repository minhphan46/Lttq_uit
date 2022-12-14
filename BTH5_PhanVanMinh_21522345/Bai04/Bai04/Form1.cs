using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        enum Align { Left, Center, Right};
        string text = "Hello";
        string fontName;
        float fontSize;
        FontStyle fontStyle;
        Color textColor;
        Align textAlign;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(FontFamily font in System.Drawing.FontFamily.Families)
            {
                cbb_font.Items.Add(font.Name);
            }
            cbb_font.SelectedItem = "Arial";
            cbb_size.Text = "28";
            fontName = "Arial";
            fontSize = 28;
            textColor = Color.Red;
            fontStyle = FontStyle.Regular;
            textAlign = Align.Center;
        }

        private void drawString()
        {
            float position = 0;
            switch (textAlign)
            {
                case Align.Left:
                    position = 1;
                    break;
                case Align.Right:
                    position = pnContent.Width - fontSize * 4;
                    break;
                case Align.Center:
                    position = pnContent.Width / 2 - fontSize * 2;
                    break;
            }
            try
            {
                Graphics g = pnContent.CreateGraphics();
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                Font font = new Font(fontName, fontSize, fontStyle);
                g.DrawString(text, font, new SolidBrush(textColor), position, pnContent.Height / 2 - fontSize);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Loi DrawString");
            }
        }

        private void pnContent_Paint(object sender, PaintEventArgs e)
        {
            drawString();
        }

        private void cbb_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontName = cbb_font.SelectedItem.ToString();
            pnContent.Refresh();
        }

        private void cbb_size_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbb_size.Text == "") return;
                fontSize = float.Parse(cbb_size.Text);
                if (fontSize <= 1) fontSize = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Loi fontSize");
            }
            pnContent.Refresh();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                textColor = btn_color.BackColor = colorDlg.Color;
                pnContent.Refresh();
            }
        }

        private void cbB_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Bold;
            pnContent.Refresh();
        }

        private void cbI_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Italic;
            pnContent.Refresh();
        }

        private void cbU_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Underline;
            pnContent.Refresh();
        }

        private void rbtn_left_CheckedChanged(object sender, EventArgs e)
        {
            textAlign = Align.Left;
            pnContent.Refresh();
        }

        private void rbtnCenter_CheckedChanged(object sender, EventArgs e)
        {
            textAlign = Align.Center;
            pnContent.Refresh();
        }

        private void rbtnRight_CheckedChanged(object sender, EventArgs e)
        {
            textAlign = Align.Right;
            pnContent.Refresh();
        }
    }
}
