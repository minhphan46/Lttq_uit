using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbCN.DataSource = GetData.Instance.nganhHocs;
            cbCN.DisplayMember = "TenNganh";

            GetData.Instance.monHocs.ForEach(mh =>
            {
                ListViewItem item = new ListViewItem(mh.maMon);
                item.SubItems.Add(mh.tenMon);
                item.Tag = mh;
                lv_MonHoc.Items.Add(item);
            });
            FetchDanhSachSinhVien();
        }
        private void FetchDanhSachSinhVien()
        {
            dgv_thongTIn.Rows.Clear();
            GetData.Instance.sinhViens.ForEach(sv =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv_thongTIn);
                row.Cells[0].Value = sv.maSoSinhVien;
                row.Cells[1].Value = sv.hoTen;
                row.Cells[2].Value = sv.nganhHoc;
                row.Cells[3].Value = sv.gioiTinh == 'M' ? "Nam" : "Nữ";
                row.Cells[4].Value = sv.listMonHoc.Count;
                row.Tag = sv;
                dgv_thongTIn.Rows.Add(row);
            });
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetInput();
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in lv_MonHoc.SelectedItems)
            {
                lv_MonHoc.Items.Remove(listViewItem);
                lv_ThamGia.Items.Add(listViewItem);
            }
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in lv_ThamGia.SelectedItems)
            {
                lv_ThamGia.Items.Remove(listViewItem);
                lv_MonHoc.Items.Add(listViewItem);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            long mssv = 0;
            if (tbMSV.Text == "" || !long.TryParse(tbMSV.Text, out mssv) || mssv < 0)
            {
                MessageBox.Show("Ma so sinh vien bi sai", mssv.ToString());
                tbMSV.Focus();
                return;
            }
            else if (tbTen.Text == "")
            {
                MessageBox.Show("Ten sinh vien rong");
                tbMSV.Focus();
                return;
            }
            else if (!rbtn_nam.Checked && !rbtn_nu.Checked)
            {
                MessageBox.Show("Gioi tinh bi sai");
                return;
            }
            List<MonHoc> monHocs = new List<MonHoc>();
            foreach (ListViewItem item in lv_ThamGia.Items)
            {
                monHocs.Add((MonHoc)item.Tag);
            }
            SinhVien sv = new SinhVien(mssv, tbTen.Text, rbtn_nam.Checked ? 'M' : 'F', (NganhHoc)cbCN.SelectedItem, monHocs);
            int find = GetData.Instance.sinhViens.FindIndex(val => val.maSoSinhVien == sv.maSoSinhVien);
            if (find == -1)
            {
                GetData.Instance.addSinhVien(sv);
                MessageBox.Show("Đã thêm sinh viên", "Thành công", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                GetData.Instance.UpdateSinhVien(sv);
                MessageBox.Show("Đã cập nhật sinh viên", "Thành công", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            FetchDanhSachSinhVien();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            long mssv = 0;
            if (tbMSV.Text == "" || !long.TryParse(tbMSV.Text, out mssv) || mssv < 0)
            {
                MessageBox.Show("Ma so sinh vien bi sai");
                tbMSV.Focus();
                return;
            }
            int find = GetData.Instance.sinhViens.FindIndex(sv => sv.maSoSinhVien == mssv);
            if(find == -1)
            {
                MessageBox.Show("Không tìm thấy sinh viên", "Không tìm thấy", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult =
                MessageBox.Show("Bạn có muốn xoá sinh viên?", "Xoá sinh viên", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            GetData.Instance.DeleteSinhVien(GetData.Instance.sinhViens[find]);
            resetInput();
            MessageBox.Show("Đã xoá sinh viên", "Đã xoá sinh viên", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            FetchDanhSachSinhVien();
        }
        public void resetInput()
        {
            tbTen.Clear();
            tbMSV.Clear();
            rbtn_nam.Checked = false;
            rbtn_nu.Checked = false;
            cbCN.SelectedIndex = 0;
            foreach (ListViewItem item in lv_ThamGia.Items)
            {
                lv_ThamGia.Items.Remove(item);
                lv_MonHoc.Items.Add(item);
            }
        }
        private void rbtn_nam_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtn_nu_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_thongTIn_Click(object sender, EventArgs e)
        {
            if(dgv_thongTIn.SelectedRows.Count > 0)
            {
                SinhVien data = (SinhVien)dgv_thongTIn.SelectedRows[0].Tag;
                if (data == null) return;
                tbMSV.Text = data.maSoSinhVien.ToString();
                tbTen.Text = data.hoTen;
                cbCN.SelectedIndex = cbCN.FindString(data.nganhHoc.tenNganh);
                if (data.gioiTinh == 'M')
                    rbtn_nam.Checked = true;
                else
                    rbtn_nu.Checked = true;
                foreach (ListViewItem item in lv_ThamGia.Items)
                {
                    lv_ThamGia.Items.Remove(item);
                    lv_MonHoc.Items.Add(item);
                }
                data.listMonHoc.ForEach(mh =>
                {
                    foreach (ListViewItem item in lv_MonHoc.Items)
                    {
                        MonHoc monHoc = item.Tag as MonHoc;
                        if (monHoc.maMon == mh.maMon)
                        {
                            lv_MonHoc.Items.Remove(item);
                            lv_ThamGia.Items.Add(item);
                        }
                    }
                });
            }
        }

        private void rbtn_nu_Click(object sender, EventArgs e)
        {
            if (rbtn_nam.Checked == true) rbtn_nam.Checked = false;
        }

        private void rbtn_nam_Click(object sender, EventArgs e)
        {
            if (rbtn_nu.Checked == true) rbtn_nu.Checked = false;
        }
    }
}
