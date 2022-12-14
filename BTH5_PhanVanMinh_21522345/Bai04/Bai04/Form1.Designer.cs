namespace Bai04
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_font = new System.Windows.Forms.ComboBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.rbtn_left = new System.Windows.Forms.RadioButton();
            this.btn_color = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnRight = new System.Windows.Forms.RadioButton();
            this.rbtnCenter = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_size = new System.Windows.Forms.ComboBox();
            this.cbI = new System.Windows.Forms.CheckBox();
            this.cbU = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // cbb_font
            // 
            this.cbb_font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_font.FormattingEnabled = true;
            this.cbb_font.Location = new System.Drawing.Point(82, 34);
            this.cbb_font.Name = "cbb_font";
            this.cbb_font.Size = new System.Drawing.Size(203, 24);
            this.cbb_font.TabIndex = 1;
            this.cbb_font.SelectedIndexChanged += new System.EventHandler(this.cbb_font_SelectedIndexChanged);
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB.Location = new System.Drawing.Point(41, 86);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(48, 29);
            this.cbB.TabIndex = 2;
            this.cbB.Text = "B";
            this.cbB.UseVisualStyleBackColor = true;
            this.cbB.CheckedChanged += new System.EventHandler(this.cbB_CheckedChanged);
            // 
            // rbtn_left
            // 
            this.rbtn_left.AutoSize = true;
            this.rbtn_left.Location = new System.Drawing.Point(14, 34);
            this.rbtn_left.Name = "rbtn_left";
            this.rbtn_left.Size = new System.Drawing.Size(49, 20);
            this.rbtn_left.TabIndex = 3;
            this.rbtn_left.Text = "Left";
            this.rbtn_left.UseVisualStyleBackColor = true;
            this.rbtn_left.CheckedChanged += new System.EventHandler(this.rbtn_left_CheckedChanged);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_color.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_color.FlatAppearance.BorderSize = 2;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_color.Location = new System.Drawing.Point(393, 86);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(67, 38);
            this.btn_color.TabIndex = 4;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // pnContent
            // 
            this.pnContent.AllowDrop = true;
            this.pnContent.BackColor = System.Drawing.Color.White;
            this.pnContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnContent.Location = new System.Drawing.Point(226, 164);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(332, 111);
            this.pnContent.TabIndex = 5;
            this.pnContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContent_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnRight);
            this.groupBox1.Controls.Add(this.rbtnCenter);
            this.groupBox1.Controls.Add(this.rbtn_left);
            this.groupBox1.Location = new System.Drawing.Point(24, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align Text";
            // 
            // rbtnRight
            // 
            this.rbtnRight.AutoSize = true;
            this.rbtnRight.Location = new System.Drawing.Point(14, 106);
            this.rbtnRight.Name = "rbtnRight";
            this.rbtnRight.Size = new System.Drawing.Size(59, 20);
            this.rbtnRight.TabIndex = 3;
            this.rbtnRight.Text = "Right";
            this.rbtnRight.UseVisualStyleBackColor = true;
            this.rbtnRight.CheckedChanged += new System.EventHandler(this.rbtnRight_CheckedChanged);
            // 
            // rbtnCenter
            // 
            this.rbtnCenter.AutoSize = true;
            this.rbtnCenter.Checked = true;
            this.rbtnCenter.Location = new System.Drawing.Point(14, 70);
            this.rbtnCenter.Name = "rbtnCenter";
            this.rbtnCenter.Size = new System.Drawing.Size(67, 20);
            this.rbtnCenter.TabIndex = 3;
            this.rbtnCenter.TabStop = true;
            this.rbtnCenter.Text = "Center";
            this.rbtnCenter.UseVisualStyleBackColor = true;
            this.rbtnCenter.CheckedChanged += new System.EventHandler(this.rbtnCenter_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size";
            // 
            // cbb_size
            // 
            this.cbb_size.FormattingEnabled = true;
            this.cbb_size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbb_size.Location = new System.Drawing.Point(393, 34);
            this.cbb_size.Name = "cbb_size";
            this.cbb_size.Size = new System.Drawing.Size(121, 24);
            this.cbb_size.TabIndex = 1;
            this.cbb_size.TextChanged += new System.EventHandler(this.cbb_size_TextChanged);
            // 
            // cbI
            // 
            this.cbI.AutoSize = true;
            this.cbI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbI.Location = new System.Drawing.Point(113, 86);
            this.cbI.Name = "cbI";
            this.cbI.Size = new System.Drawing.Size(39, 29);
            this.cbI.TabIndex = 2;
            this.cbI.Text = "I";
            this.cbI.UseVisualStyleBackColor = true;
            this.cbI.CheckedChanged += new System.EventHandler(this.cbI_CheckedChanged);
            // 
            // cbU
            // 
            this.cbU.AutoSize = true;
            this.cbU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbU.Location = new System.Drawing.Point(172, 86);
            this.cbU.Name = "cbU";
            this.cbU.Size = new System.Drawing.Size(48, 29);
            this.cbU.TabIndex = 2;
            this.cbU.Text = "U";
            this.cbU.UseVisualStyleBackColor = true;
            this.cbU.CheckedChanged += new System.EventHandler(this.cbU_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.cbU);
            this.Controls.Add(this.cbI);
            this.Controls.Add(this.cbB);
            this.Controls.Add(this.cbb_size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_font);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai 04";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_font;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.RadioButton rbtn_left;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnRight;
        private System.Windows.Forms.RadioButton rbtnCenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_size;
        private System.Windows.Forms.CheckBox cbI;
        private System.Windows.Forms.CheckBox cbU;
        private System.Windows.Forms.Label label3;
    }
}

