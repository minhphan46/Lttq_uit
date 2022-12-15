namespace Bai_10
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
            this.cbb_dashStyle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_width = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_lineJoin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_dashCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_StartCap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_EndCap = new System.Windows.Forms.ComboBox();
            this.ptb_paint = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_paint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dash Style :";
            // 
            // cbb_dashStyle
            // 
            this.cbb_dashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dashStyle.FormattingEnabled = true;
            this.cbb_dashStyle.Location = new System.Drawing.Point(106, 21);
            this.cbb_dashStyle.Name = "cbb_dashStyle";
            this.cbb_dashStyle.Size = new System.Drawing.Size(152, 24);
            this.cbb_dashStyle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width :";
            // 
            // cbb_width
            // 
            this.cbb_width.FormattingEnabled = true;
            this.cbb_width.Location = new System.Drawing.Point(106, 67);
            this.cbb_width.Name = "cbb_width";
            this.cbb_width.Size = new System.Drawing.Size(152, 24);
            this.cbb_width.TabIndex = 1;
            this.cbb_width.TextChanged += new System.EventHandler(this.cbb_width_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Line Join :";
            // 
            // cbb_lineJoin
            // 
            this.cbb_lineJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lineJoin.FormattingEnabled = true;
            this.cbb_lineJoin.Location = new System.Drawing.Point(106, 112);
            this.cbb_lineJoin.Name = "cbb_lineJoin";
            this.cbb_lineJoin.Size = new System.Drawing.Size(152, 24);
            this.cbb_lineJoin.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dash Cap :";
            // 
            // cbb_dashCap
            // 
            this.cbb_dashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dashCap.FormattingEnabled = true;
            this.cbb_dashCap.Location = new System.Drawing.Point(106, 158);
            this.cbb_dashCap.Name = "cbb_dashCap";
            this.cbb_dashCap.Size = new System.Drawing.Size(152, 24);
            this.cbb_dashCap.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start Cap :";
            // 
            // cbb_StartCap
            // 
            this.cbb_StartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_StartCap.FormattingEnabled = true;
            this.cbb_StartCap.Location = new System.Drawing.Point(106, 210);
            this.cbb_StartCap.Name = "cbb_StartCap";
            this.cbb_StartCap.Size = new System.Drawing.Size(152, 24);
            this.cbb_StartCap.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "End Cap :";
            // 
            // cbb_EndCap
            // 
            this.cbb_EndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_EndCap.FormattingEnabled = true;
            this.cbb_EndCap.Location = new System.Drawing.Point(106, 262);
            this.cbb_EndCap.Name = "cbb_EndCap";
            this.cbb_EndCap.Size = new System.Drawing.Size(152, 24);
            this.cbb_EndCap.TabIndex = 1;
            // 
            // ptb_paint
            // 
            this.ptb_paint.BackColor = System.Drawing.Color.White;
            this.ptb_paint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_paint.Location = new System.Drawing.Point(275, 2);
            this.ptb_paint.Name = "ptb_paint";
            this.ptb_paint.Size = new System.Drawing.Size(527, 448);
            this.ptb_paint.TabIndex = 2;
            this.ptb_paint.TabStop = false;
            this.ptb_paint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptb_paint_MouseDown);
            this.ptb_paint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptb_paint_MouseMove);
            this.ptb_paint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptb_paint_MouseUp);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(25, 321);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(105, 45);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giữ chuột trái để vẽ\r\nBấm chuột phải để nối\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.ptb_paint);
            this.Controls.Add(this.cbb_EndCap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbb_StartCap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_dashCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_lineJoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_dashStyle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pen demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_paint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_dashStyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_lineJoin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_dashCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_StartCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_EndCap;
        private System.Windows.Forms.PictureBox ptb_paint;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label7;
    }
}

