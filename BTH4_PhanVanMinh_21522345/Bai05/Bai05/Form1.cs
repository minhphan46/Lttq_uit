﻿using Bai05.Provider;
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
            DisplayDanhSachVien();
        }
        public void DisplayDanhSachVien()
        {
            dgv_SinhVien.Rows.Clear();
            int i = 1;
            DataProvider.Instance.ListsinhVien.ForEach(sv =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv_SinhVien);
                row.Cells[0].Value = i;
                row.Cells[1].Value = sv.MSSV;
                row.Cells[2].Value = sv.HoTen;
                row.Cells[3].Value = sv.Khoa;
                row.Cells[4].Value = sv.DiemTB;
                row.Tag = sv;
                dgv_SinhVien.Rows.Add(row);
                i++;
            });
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.ShowDialog();
        }

        private void tbn_TS_add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_find_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgv_SinhVien.RowCount; i++)
                {
                    if (dgv_SinhVien.Rows[i].Cells[2].Value != null && dgv_SinhVien.Rows[i].Cells[2].Value.ToString().ToLower().Contains(tb_find.Text.ToLower().Trim()))
                    {
                        dgv_SinhVien.CurrentCell = null;
                        dgv_SinhVien.Rows[i].Visible = true;
                    }
                    else
                    {
                        dgv_SinhVien.CurrentCell = null;
                        dgv_SinhVien.Rows[i].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_find_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
