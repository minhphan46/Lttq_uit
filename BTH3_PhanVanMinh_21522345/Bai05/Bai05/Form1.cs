using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai05
{
    public partial class Form1 : Form
    {
        protected decimal number1 = 0;
        protected decimal number2 = 0;

        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
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
        public bool checkNumber()
        {
            if (string.IsNullOrWhiteSpace(tb1.Text))
            {
                MessageBox.Show("number1 is empty");
                return true;
            }
            bool canConvert1 = decimal.TryParse(tb1.Text, out number1);
            if (canConvert1 == false)
            {
                MessageBox.Show("number1 is not a valid number");
                return true;
            }
            if (String.IsNullOrEmpty(tb2.Text))
            {
                MessageBox.Show("number2 is empty");
                return true;
            }

            bool canConvert2 = decimal.TryParse(tb2.Text, out number2);
            if (canConvert2 == false)
            {
                MessageBox.Show("number2 is not a valid number");
                return true;
            }
            return false;
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (checkNumber()) return;
            tba.Text = (number1 + number2).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (checkNumber()) return;
            tba.Text = (number1 - number2).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (checkNumber()) return;
            tba.Text = (number1 * number2).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (checkNumber()) return;
            if(number2 == 0)
            {
                MessageBox.Show("Phep chia khong hop le");
                return;
            }
            tba.Text = (number1 / number2).ToString();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            tb1.Clear();
            tb2.Clear();
            tba.Clear();
        }
    }
}
