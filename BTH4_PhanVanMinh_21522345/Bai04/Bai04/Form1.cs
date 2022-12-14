using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public string filename = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(FontFamily font in FontFamily.Families)
            {
                string temp = font.Name.ToString();

                cb_font.Items.Add(font.Name.ToString());
            }
            richTb.Font = new Font("Tahoma", 14);
            cb_font.SelectedItem = richTb.Font.FontFamily.Name.ToString();
            cb_size.Text = richTb.Font.Size.ToString();
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTb.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTb.Font = fontDialog1.Font;
                cb_font.SelectedItem = richTb.Font.FontFamily.Name.ToString();
                cb_size.Text = richTb.Font.Size.ToString();
                if ((richTb.Font.Style & FontStyle.Bold) != 0) btn_bold.BackColor = SystemColors.GradientActiveCaption;
                if ((richTb.Font.Style & FontStyle.Italic) != 0) tbn_italic.BackColor = SystemColors.GradientActiveCaption;
                if ((richTb.Font.Style & FontStyle.Underline) != 0) btn_underline.BackColor = SystemColors.GradientActiveCaption;
            }
        }

        private void exitButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_font_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FontFamily fontFamily = new FontFamily(cb_font.Text);
                richTb.Font = new Font(fontFamily, richTb.Font.Size, richTb.Font.Style);
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Loi font family");
            }
        }
        private void cb_size_TextChanged(object sender, EventArgs e)
        {
            try
            {
                richTb.Font = new Font(richTb.Font.FontFamily, float.Parse(cb_size.Text), richTb.Font.Style);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Loi size");
            }
        }

        private void btn_bold_Click(object sender, EventArgs e)
        {
            if (btn_bold.BackColor == SystemColors.Control)
            {
                btn_bold.BackColor = SystemColors.GradientActiveCaption;
                richTb.Font = new Font(richTb.Font.FontFamily, richTb.Font.Size, richTb.Font.Style | FontStyle.Bold);
            }
            else
            {
                btn_bold.BackColor = SystemColors.Control;
                richTb.Font = new Font(richTb.Font.FontFamily, richTb.Font.Size, richTb.Font.Style & ~FontStyle.Bold);
            }
        }

        private void tbn_italic_Click(object sender, EventArgs e)
        {
            if (tbn_italic.BackColor == SystemColors.Control)
            {
                tbn_italic.BackColor = SystemColors.GradientActiveCaption;
                richTb.Font = new Font(richTb.Font.FontFamily, richTb.Font.Size, richTb.Font.Style | FontStyle.Italic);
            }
            else
            {
                tbn_italic.BackColor = SystemColors.Control;
                richTb.Font = new Font(richTb.Font.FontFamily, richTb.Font.Size, richTb.Font.Style & ~FontStyle.Italic);
            }
        }
        
        private void btn_underline_Click(object sender, EventArgs e)
        {
            if (btn_underline.BackColor == SystemColors.Control)
            {
                btn_underline.BackColor = SystemColors.GradientActiveCaption;
                richTb.Font = new Font(richTb.Font.FontFamily, richTb.Font.Size, richTb.Font.Style | FontStyle.Underline);
            }
            else
            {
                btn_underline.BackColor = SystemColors.Control;
                richTb.Font = new Font(richTb.Font.FontFamily, richTb.Font.Size, richTb.Font.Style & ~FontStyle.Underline);
            }
        }

        
        private void openItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "TXT|*.txt|RTF|*.rtf", ValidateNames = true, Multiselect = false })
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        filename = openFileDialog1.FileName;
                        string extension = Path.GetExtension(filename);
                        if (extension == ".txt") richTb.LoadFile(filename, RichTextBoxStreamType.PlainText);
                        else richTb.LoadFile(filename, RichTextBoxStreamType.RichText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured open: " + ex.Message);
            }
        }


        private void newButton_Click(object sender, EventArgs e)
        {
            filename = "";
            richTb.Text = "";
            richTb.Font = new Font("Tahoma", 14);
            cb_font.SelectedItem = richTb.Font.FontFamily.Name.ToString();
            cb_size.Text = richTb.Font.Size.ToString();
            btn_underline.BackColor = SystemColors.Control;
            tbn_italic.BackColor = SystemColors.Control;
            btn_bold.BackColor = SystemColors.Control;
        }

        private void CreateNewItem_Click(object sender, EventArgs e)
        {
            filename = "";
            richTb.Text = "";
            richTb.Font = new Font("Tahoma", 14);
            cb_font.SelectedItem = richTb.Font.FontFamily.Name.ToString();
            cb_size.Text = richTb.Font.Size.ToString();
            btn_underline.BackColor = SystemColors.Control;
            tbn_italic.BackColor = SystemColors.Control;
            btn_bold.BackColor = SystemColors.Control;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "rtf|*.rtf";

                if (string.IsNullOrEmpty(filename))
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        richTb.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                    }
                }
                else
                {
                    richTb.SaveFile(filename, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Đã lưu thành công file !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured save: " + ex.Message);
            }
        }
    }
}
