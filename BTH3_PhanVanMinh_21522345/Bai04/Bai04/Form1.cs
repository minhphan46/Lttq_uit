using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = Color.White;
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDlg.Color;
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            BackColor = DefaultBackColor;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat khong?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
