using Bai05.Models;
using Bai05.Provider;
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
    public partial class AddForm : Form
    {
        public Form1 parentForm;
        public AddForm(Form1 parentForm)
        {
            InitializeComponent();
            cb_khoa.DataSource = DataProvider.Instance.ListKhoa;
            cb_khoa.DisplayMember = "Ten Khoa";
            this.parentForm = parentForm;
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            long mssv = 0;
            double diemTb = 0;
            if (tb_mssv.Text == "" || !long.TryParse(tb_mssv.Text, out mssv) || mssv < 0)
            {
                MessageBox.Show("Ma so sinh vien bi sai", mssv.ToString());
                tb_mssv.Focus();
                return;
            }
            else if (tb_tensv.Text == "")
            {
                MessageBox.Show("Ten sinh vien rong");
                tb_tensv.Focus();
                return;
            }
            else if (tb_tensv.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ten khong hop le!");
                tb_tensv.Focus();
                return;
            }
            else if (tb_diemtb.Text == "" || !double.TryParse(tb_diemtb.Text, out diemTb) || diemTb < 0 || diemTb> 10)
            {
                MessageBox.Show("Diem trung binh bi sai", diemTb.ToString());
                tb_diemtb.Focus();
                return;
            }
            SinhVien sv = new SinhVien(mssv, tb_tensv.Text, (Khoa)cb_khoa.SelectedItem, diemTb);
            int find = DataProvider.Instance.ListsinhVien.FindIndex(val => val.MSSV == sv.MSSV);
            if (find == -1)
            {
                DataProvider.Instance.addSinhVien(sv);
                MessageBox.Show("Đã thêm sinh viên", "Thành công", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("MSSV đã tồn tại!", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            parentForm.DisplayDanhSachVien();
        }
    }
}
