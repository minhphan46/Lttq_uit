using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04
{
    public partial class MainWindow : Form
    {
        Color textColor;
        string fontName;
        int fontSize;
        FontStyle fontStyle;
        enum textAligin { left, center, right }
        textAligin aligin;
        
        public MainWindow()
        {
            InitializeComponent();

            textColor = Color.Red;
            fontName = "Arial";
            fontSize = 24;
            fontStyle = FontStyle.Regular;
            aligin = textAligin.center;
            
        }

        void drawString(textAligin aligin, string fontName, int fontSize, FontStyle fontStyle, Color color)
        {
            int x = 0;

            switch (aligin)
            {
                case textAligin.left:
                    x = 1;
                    break;
                case textAligin.right:
                    x = contentPanel.Width - fontSize * 4;
                    break;
                default:
                    x = contentPanel.Width / 2 - fontSize * 2;
                    break;
            }
            Graphics draw = contentPanel.CreateGraphics();
            draw.TextRenderingHint = TextRenderingHint.AntiAlias;
            draw.DrawString("Hello", new Font(fontName, fontSize, fontStyle), new SolidBrush(color), x, contentPanel.Height / 2 - fontSize);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fontComboBox.Items.Add(font.Name);
            }

            for (int i = 1; i< 100; i++)
            {
                fontSizeComboBox.Items.Add(i);
            }

            fontComboBox.SelectedItem = "Arial";
            fontSizeComboBox.Text = "24";
        }
        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {
            drawString(aligin, fontName, fontSize, fontStyle, textColor);
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontName = fontComboBox.SelectedItem.ToString();
            contentPanel.Refresh();
        }
        private void fontSizeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (fontSizeComboBox.Text.ToString() == "" || fontSizeComboBox.Text.ToString() == "0")
                fontSize = 1;
            else fontSize = int.Parse(fontSizeComboBox.Text.ToString());
            contentPanel.Refresh();
        }
        private void pickColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                textColor = pickColor.BackColor = colorDlg.Color;
                contentPanel.Refresh();
            }
        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Bold;
            contentPanel.Refresh();
        }
        private void italic_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Italic;
            contentPanel.Refresh();
        }
        private void underlined_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Underline;
            contentPanel.Refresh();
        }

        private void left_CheckedChanged(object sender, EventArgs e)
        {
            aligin = textAligin.left;
            contentPanel.Refresh();
        }
        private void center_CheckedChanged(object sender, EventArgs e)
        {
            aligin = textAligin.center;
            contentPanel.Refresh();
        }
        private void right_CheckedChanged(object sender, EventArgs e)
        {
            aligin = textAligin.right;
            contentPanel.Refresh();
        }
    }
}
