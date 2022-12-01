namespace Bai09
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_nu = new System.Windows.Forms.RadioButton();
            this.rbtn_nam = new System.Windows.Forms.RadioButton();
            this.cbCN = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lv_MonHoc = new System.Windows.Forms.ListView();
            this.lv_ThamGia = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_thongTIn = new System.Windows.Forms.DataGridView();
            this.CMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CchuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CgioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CsoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongTIn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_nu);
            this.panel1.Controls.Add(this.rbtn_nam);
            this.panel1.Controls.Add(this.cbCN);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lv_MonHoc);
            this.panel1.Controls.Add(this.lv_ThamGia);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbTen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbMSV);
            this.panel1.Location = new System.Drawing.Point(53, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 418);
            this.panel1.TabIndex = 0;
            // 
            // rbtn_nu
            // 
            this.rbtn_nu.AutoSize = true;
            this.rbtn_nu.Location = new System.Drawing.Point(411, 162);
            this.rbtn_nu.Name = "rbtn_nu";
            this.rbtn_nu.Size = new System.Drawing.Size(45, 20);
            this.rbtn_nu.TabIndex = 6;
            this.rbtn_nu.TabStop = true;
            this.rbtn_nu.Text = "Nữ";
            this.rbtn_nu.UseVisualStyleBackColor = true;
            this.rbtn_nu.CheckedChanged += new System.EventHandler(this.rbtn_nu_CheckedChanged);
            this.rbtn_nu.Click += new System.EventHandler(this.rbtn_nu_Click);
            // 
            // rbtn_nam
            // 
            this.rbtn_nam.AutoSize = true;
            this.rbtn_nam.Location = new System.Drawing.Point(326, 162);
            this.rbtn_nam.Name = "rbtn_nam";
            this.rbtn_nam.Size = new System.Drawing.Size(57, 20);
            this.rbtn_nam.TabIndex = 6;
            this.rbtn_nam.TabStop = true;
            this.rbtn_nam.Text = "Nam";
            this.rbtn_nam.UseVisualStyleBackColor = true;
            this.rbtn_nam.CheckedChanged += new System.EventHandler(this.rbtn_nam_CheckedChanged);
            this.rbtn_nam.Click += new System.EventHandler(this.rbtn_nam_Click);
            // 
            // cbCN
            // 
            this.cbCN.FormattingEnabled = true;
            this.cbCN.Location = new System.Drawing.Point(326, 115);
            this.cbCN.Name = "cbCN";
            this.cbCN.Size = new System.Drawing.Size(448, 24);
            this.cbCN.TabIndex = 5;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(475, 292);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(35, 35);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "<";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnQuaTrai_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(475, 239);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(35, 35);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = ">";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnQuaPhai_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(576, 356);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 33);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Location = new System.Drawing.Point(422, 356);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(114, 33);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xóa Chọn";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(266, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu Thông Tin";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lv_MonHoc
            // 
            this.lv_MonHoc.HideSelection = false;
            this.lv_MonHoc.Location = new System.Drawing.Point(173, 239);
            this.lv_MonHoc.Name = "lv_MonHoc";
            this.lv_MonHoc.Size = new System.Drawing.Size(283, 97);
            this.lv_MonHoc.TabIndex = 3;
            this.lv_MonHoc.UseCompatibleStateImageBehavior = false;
            // 
            // lv_ThamGia
            // 
            this.lv_ThamGia.HideSelection = false;
            this.lv_ThamGia.Location = new System.Drawing.Point(531, 239);
            this.lv_ThamGia.Name = "lv_ThamGia";
            this.lv_ThamGia.Size = new System.Drawing.Size(283, 97);
            this.lv_ThamGia.TabIndex = 3;
            this.lv_ThamGia.UseCompatibleStateImageBehavior = false;
            this.lv_ThamGia.View = System.Windows.Forms.View.List;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuyên ngành";
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.Location = new System.Drawing.Point(326, 68);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(448, 24);
            this.tbTen.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // tbMSV
            // 
            this.tbMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMSV.Location = new System.Drawing.Point(326, 23);
            this.tbMSV.Name = "tbMSV";
            this.tbMSV.Size = new System.Drawing.Size(238, 24);
            this.tbMSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // dgv_thongTIn
            // 
            this.dgv_thongTIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongTIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMSSV,
            this.CHoTen,
            this.CchuyenNganh,
            this.CgioiTinh,
            this.CsoMon});
            this.dgv_thongTIn.Location = new System.Drawing.Point(53, 451);
            this.dgv_thongTIn.Name = "dgv_thongTIn";
            this.dgv_thongTIn.ReadOnly = true;
            this.dgv_thongTIn.RowHeadersWidth = 51;
            this.dgv_thongTIn.RowTemplate.Height = 24;
            this.dgv_thongTIn.Size = new System.Drawing.Size(1033, 257);
            this.dgv_thongTIn.TabIndex = 1;
            this.dgv_thongTIn.Click += new System.EventHandler(this.dgv_thongTIn_Click);
            // 
            // CMSSV
            // 
            this.CMSSV.HeaderText = "MSSV";
            this.CMSSV.MinimumWidth = 6;
            this.CMSSV.Name = "CMSSV";
            this.CMSSV.ReadOnly = true;
            this.CMSSV.Width = 125;
            // 
            // CHoTen
            // 
            this.CHoTen.HeaderText = "Họ Tên";
            this.CHoTen.MinimumWidth = 6;
            this.CHoTen.Name = "CHoTen";
            this.CHoTen.ReadOnly = true;
            this.CHoTen.Width = 180;
            // 
            // CchuyenNganh
            // 
            this.CchuyenNganh.HeaderText = "Chuyên Ngành";
            this.CchuyenNganh.MinimumWidth = 6;
            this.CchuyenNganh.Name = "CchuyenNganh";
            this.CchuyenNganh.ReadOnly = true;
            this.CchuyenNganh.Width = 200;
            // 
            // CgioiTinh
            // 
            this.CgioiTinh.HeaderText = "Giới Tính";
            this.CgioiTinh.MinimumWidth = 6;
            this.CgioiTinh.Name = "CgioiTinh";
            this.CgioiTinh.ReadOnly = true;
            this.CgioiTinh.Width = 125;
            // 
            // CsoMon
            // 
            this.CsoMon.HeaderText = "Số Môn";
            this.CsoMon.MinimumWidth = 6;
            this.CsoMon.Name = "CsoMon";
            this.CsoMon.ReadOnly = true;
            this.CsoMon.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1139, 736);
            this.Controls.Add(this.dgv_thongTIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Nhập Liệu Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongTIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lv_ThamGia;
        private System.Windows.Forms.ComboBox cbCN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lv_MonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_thongTIn;
        private System.Windows.Forms.RadioButton rbtn_nu;
        private System.Windows.Forms.RadioButton rbtn_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CchuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CgioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CsoMon;
    }
}

