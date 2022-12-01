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

namespace bai06
{
    public partial class Form1 : Form
    {
        public String calculatString = "";
        public String curString = "";
        public Form1()
        {
            InitializeComponent();
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

        private void button0_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "0") tBCurrunt.Clear();
            tBCurrunt.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "0") tBCurrunt.Clear();
            tBCurrunt.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "0") tBCurrunt.Clear();
            tBCurrunt.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "0") tBCurrunt.Clear();
            tBCurrunt.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "0") tBCurrunt.Clear();
            tBCurrunt.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "0") tBCurrunt.Clear();
            tBCurrunt.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "0") tBCurrunt.Clear();
            tBCurrunt.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "0") tBCurrunt.Clear();
            tBCurrunt.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "0") tBCurrunt.Clear();
            tBCurrunt.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "0") tBCurrunt.Clear();
            tBCurrunt.Text += "9";
        }
        private void buttonDoiDau_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "") return;
            if (tBCurrunt.Text[0] != '-')
            {
                tBCurrunt.Text = "-" + tBCurrunt.Text;
            }
            else
            {
                tBCurrunt.Text = tBCurrunt.Text.Substring(1);
            }
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if(tBCurrunt.Text == "")
            {
                tBCurrunt.Text += "0,";
            }
            else
            {
                if (!tBCurrunt.Text.Contains(","))
                {
                    tBCurrunt.Text += ",";
                }
            }
            
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (tBCurrunt.Text == "") return;
            tBCurrunt.Text = tBCurrunt.Text.Remove(tBCurrunt.Text.Length - 1);
        }
        
        private void buttonCE_Click(object sender, EventArgs e)
        {
            cur = 0;
            tBCurrunt.Clear();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            total = 0;
            cur = 0;
            tbTinh.Clear();
            tBCurrunt.Clear();
        }
        // tinh toan
        public decimal total = 0;
        public decimal cur = 0;
        public bool convert()
        {
            bool canConvert = decimal.TryParse(tBCurrunt.Text, out cur);
            if (canConvert == false)
            {
                MessageBox.Show("So dang nhap khong hop le!", "Warning!");
                return false;
            }
            return true;
        }
        public void tinhToan()
        {
            if (tbTinh.Text == "")
            {
                total = cur;
                return;
            }
            if (tbTinh.Text[tbTinh.Text.Length - 1] == '+')
            {
                total += cur;
                cur = 0;
            }
            else if (tbTinh.Text[tbTinh.Text.Length - 1] == '-')
            {
                total -= cur;
                cur = 0;
            }
            else if (tbTinh.Text[tbTinh.Text.Length - 1] == 'x')
            {
                total *= cur;
                cur = 0;
            }
            else if (tbTinh.Text[tbTinh.Text.Length - 1] == '/')
            {
                if( cur == 0)
                {
                    MessageBox.Show("Phep chia khong hop le");
                    return;
                }
                total /= cur;
                cur = 0;
            }
        }
        private void buttonCong_Click(object sender, EventArgs e)
        {
            if (convert() == false) return;
            else
            {
                tinhToan();
                tbTinh.Text = total.ToString() + "+";
                tBCurrunt.Clear();
            }
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            if (convert() == false) return;
            else
            {
                tinhToan();
                tbTinh.Text = total.ToString() + "-";
                tBCurrunt.Clear();
            }
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            if (convert() == false) return;
            else
            {
                tinhToan();
                tbTinh.Text = total.ToString() + "x";
                tBCurrunt.Clear();
            }
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            if (convert() == false) return;
            else
            {
                tinhToan();
                tbTinh.Text = total.ToString() + "/";
                tBCurrunt.Clear();
            }
        }


        private void buttonBang_Click(object sender, EventArgs e)
        {
            if (convert() == false) return;
            else
            {
                tinhToan();
                tbTinh.Clear();
                tBCurrunt.Text = total.ToString();
                tBCurrunt_TextChanged(sender, e);
            }
        }

        private void tBCurrunt_TextChanged(object sender, EventArgs e)
        {
            if (tBCurrunt.Text.Length > 10)
            {
                float newSize = tBCurrunt.Font.Size - (tBCurrunt.Text.Length - 10);
                if (newSize < 12) newSize = 12;
                tBCurrunt.Font = new Font(tBCurrunt.Font.FontFamily, newSize);
            }
            else
            {
                tBCurrunt.Font = new Font(tBCurrunt.Font.FontFamily, 36);
            }   
        }
    }
}
