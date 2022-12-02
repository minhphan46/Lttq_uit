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

namespace Bai08
{
    public partial class Form1 : Form
    {
        private ListTaiKhoan listTK;
        private decimal total= 0;
        public Form1()
        {
            InitializeComponent();
            listTK = new ListTaiKhoan();
        }


        private void btnEXit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        public bool checkEmply()
        {
            if (string.IsNullOrWhiteSpace(tbSoTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(tbDiaChi.Text) ||
                string.IsNullOrWhiteSpace(tbTen.Text) ||
                string.IsNullOrWhiteSpace(tbTien.Text))
            {
                return true;
            }
            return false;
        }
        private void addTotal(decimal tien)
        {
            total += tien;
            tbTotal.Text = total.ToString();
        }
        private void deleteTextInput()
        {
            tbSoTaiKhoan.Clear();
            tbTen.Clear();
            tbDiaChi.Clear();
            tbTien.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check
            if (checkEmply())
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }
            if (tbTen.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ten khong hop le!");
                return;
            }
            int soTaiKhoan = 0;
            decimal soTien = 0;
            bool canConvert1 = int.TryParse(tbSoTaiKhoan.Text, out soTaiKhoan);
            if (canConvert1 == false || soTaiKhoan < 0)
            {
                MessageBox.Show("So tai khoan khong hop le!");
                return;
            }
            bool canConvert2 = decimal.TryParse(tbTien.Text, out soTien);
            if (canConvert2 == false || soTien < 0)
            {
                MessageBox.Show("So tien trong tai khoan khong hop le!");
                return;
            }
            // add
            if (listTK.isExit(soTaiKhoan))
            {
                // update
                int i = listTK.getSTT(soTaiKhoan);
                total -= listTK.listTaiKhoan[i].SoTien;
                ListViewItem item1 = new ListViewItem();
                item1.Text = listTK.getSTT(soTaiKhoan).ToString();
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tbSoTaiKhoan.Text });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tbTen.Text });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tbDiaChi.Text });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tbTien.Text });
                listView.Items[i] = item1;

                listTK.updateTaiKhoan(soTaiKhoan, tbTen.Text, tbDiaChi.Text, soTien);
                addTotal(soTien);
                deleteTextInput();
                MessageBox.Show("Cap nhap du lieu thanh cong!");
            }
            else
            {
                // add
                listTK.addTaiKhoan(soTaiKhoan, tbTen.Text, tbDiaChi.Text, soTien);

                ListViewItem item1 = new ListViewItem();
                item1.Text = listTK.getSTT(soTaiKhoan).ToString();
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tbSoTaiKhoan.Text });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tbTen.Text });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tbDiaChi.Text });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tbTien.Text });
                listView.Items.Add(item1);

                addTotal(soTien);
                deleteTextInput();

                MessageBox.Show("Them moi du lieu thanh cong!");
            }
            tbSoTaiKhoan.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Bạn muốn xóa", "canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    int i = listTK.getSTT(int.Parse(listView.SelectedItems[0].SubItems[0].Text));
                    total -= listTK.listTaiKhoan[i].SoTien;
                    tbTotal.Text = total.ToString();
                    listTK.removeTaiKhoan(int.Parse(listView.SelectedItems[0].SubItems[0].Text));
                    listView.Items.Remove(listView.SelectedItems[0]);
                    for( i = 0; i < listView.Items.Count; i++) {
                        listView.Items[i].Text = i.ToString();
                    }
                }
                MessageBox.Show("Xóa tài khoản thành công.");
            }
            else MessageBox.Show("Xóa lỗi");
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count > 0)
                {
                    int i = int.Parse(listView.SelectedItems[0].Text);
                    tbSoTaiKhoan.Text = listTK.listTaiKhoan[i].SoTaiKhoan.ToString();
                    tbTen.Text = listTK.listTaiKhoan[i].Ten;
                    tbDiaChi.Text = listTK.listTaiKhoan[i].DiaChi;
                    tbTien.Text = listTK.listTaiKhoan[i].SoTien.ToString();
                }
            }
            catch
            {
                MessageBox.Show("loi");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            deleteTextInput();
            total = 0;
            tbTotal.Clear();
            listView.Items.Clear();
        }

        private void listView_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count > 0)
                {
                    int i = int.Parse(listView.SelectedItems[0].Text);
                    tbSoTaiKhoan.Text = listTK.listTaiKhoan[i].SoTaiKhoan.ToString();
                    tbTen.Text = listTK.listTaiKhoan[i].Ten;
                    tbDiaChi.Text = listTK.listTaiKhoan[i].DiaChi;
                    tbTien.Text = listTK.listTaiKhoan[i].SoTien.ToString();
                }
            }
            catch
            {
                MessageBox.Show("loi");
            }
        }
    }
}
