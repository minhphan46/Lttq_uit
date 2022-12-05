namespace Bai05
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbn_TS_add = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_find = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.soTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSoSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(816, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbn_TS_add,
            this.btn_exit});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // tbn_TS_add
            // 
            this.tbn_TS_add.Name = "tbn_TS_add";
            this.tbn_TS_add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tbn_TS_add.Size = new System.Drawing.Size(224, 26);
            this.tbn_TS_add.Text = "Thêm mới";
            this.tbn_TS_add.Click += new System.EventHandler(this.tbn_TS_add_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(224, 26);
            this.btn_exit.Text = "Thoát";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.toolStripLabel1,
            this.tb_find});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_add
            // 
            this.btn_add.Image = global::Bai05.image.add_user;
            this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_add.Size = new System.Drawing.Size(140, 24);
            this.btn_add.Text = "Thêm mới";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(136, 24);
            this.toolStripLabel1.Text = "Tìm Kiếm Theo Tên";
            // 
            // tb_find
            // 
            this.tb_find.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(351, 27);
            // 
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soTT,
            this.MaSoSV,
            this.TenSV,
            this.Khoa,
            this.DiemTB});
            this.dgv_SinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SinhVien.Location = new System.Drawing.Point(0, 55);
            this.dgv_SinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.RowHeadersWidth = 51;
            this.dgv_SinhVien.RowTemplate.Height = 24;
            this.dgv_SinhVien.Size = new System.Drawing.Size(816, 395);
            this.dgv_SinhVien.TabIndex = 2;
            // 
            // soTT
            // 
            this.soTT.HeaderText = "Số TT";
            this.soTT.MinimumWidth = 6;
            this.soTT.Name = "soTT";
            this.soTT.Width = 70;
            // 
            // MaSoSV
            // 
            this.MaSoSV.HeaderText = "Mã Số SV";
            this.MaSoSV.MinimumWidth = 6;
            this.MaSoSV.Name = "MaSoSV";
            this.MaSoSV.Width = 90;
            // 
            // TenSV
            // 
            this.TenSV.HeaderText = "Tên Sinh Viên";
            this.TenSV.MinimumWidth = 6;
            this.TenSV.Name = "TenSV";
            this.TenSV.Width = 150;
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.Width = 150;
            // 
            // DiemTB
            // 
            this.DiemTB.HeaderText = "Điểm TB";
            this.DiemTB.MinimumWidth = 6;
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.dgv_SinhVien);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tbn_TS_add;
        private System.Windows.Forms.ToolStripMenuItem btn_exit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_add;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_find;
        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
    }
}

