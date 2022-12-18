namespace Bai11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_Elip = new System.Windows.Forms.RadioButton();
            this.rbtn_rec = new System.Windows.Forms.RadioButton();
            this.rbtn_Line = new System.Windows.Forms.RadioButton();
            this.tb_Width = new System.Windows.Forms.TextBox();
            this.btn_Color = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_Linear = new System.Windows.Forms.RadioButton();
            this.rbtn_Texture = new System.Windows.Forms.RadioButton();
            this.rbtn_Hatch = new System.Windows.Forms.RadioButton();
            this.rbtn_solid = new System.Windows.Forms.RadioButton();
            this.ptb_paint = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_paint)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_Elip);
            this.groupBox1.Controls.Add(this.rbtn_rec);
            this.groupBox1.Controls.Add(this.rbtn_Line);
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rbtn_Elip
            // 
            this.rbtn_Elip.AutoSize = true;
            this.rbtn_Elip.Location = new System.Drawing.Point(18, 103);
            this.rbtn_Elip.Name = "rbtn_Elip";
            this.rbtn_Elip.Size = new System.Drawing.Size(66, 20);
            this.rbtn_Elip.TabIndex = 1;
            this.rbtn_Elip.Text = "Elipse";
            this.rbtn_Elip.UseVisualStyleBackColor = true;
            // 
            // rbtn_rec
            // 
            this.rbtn_rec.AutoSize = true;
            this.rbtn_rec.Location = new System.Drawing.Point(18, 66);
            this.rbtn_rec.Name = "rbtn_rec";
            this.rbtn_rec.Size = new System.Drawing.Size(90, 20);
            this.rbtn_rec.TabIndex = 1;
            this.rbtn_rec.Text = "Rectangle";
            this.rbtn_rec.UseVisualStyleBackColor = true;
            // 
            // rbtn_Line
            // 
            this.rbtn_Line.AutoSize = true;
            this.rbtn_Line.Checked = true;
            this.rbtn_Line.Location = new System.Drawing.Point(18, 28);
            this.rbtn_Line.Name = "rbtn_Line";
            this.rbtn_Line.Size = new System.Drawing.Size(53, 20);
            this.rbtn_Line.TabIndex = 1;
            this.rbtn_Line.TabStop = true;
            this.rbtn_Line.Text = "Line";
            this.rbtn_Line.UseVisualStyleBackColor = true;
            // 
            // tb_Width
            // 
            this.tb_Width.Location = new System.Drawing.Point(71, 33);
            this.tb_Width.Name = "tb_Width";
            this.tb_Width.Size = new System.Drawing.Size(100, 22);
            this.tb_Width.TabIndex = 2;
            this.tb_Width.TextChanged += new System.EventHandler(this.tb_Width_TextChanged);
            // 
            // btn_Color
            // 
            this.btn_Color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Color.ForeColor = System.Drawing.Color.White;
            this.btn_Color.Location = new System.Drawing.Point(71, 74);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(100, 30);
            this.btn_Color.TabIndex = 4;
            this.btn_Color.Text = "Color";
            this.btn_Color.UseVisualStyleBackColor = false;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Color);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_Width);
            this.groupBox2.Location = new System.Drawing.Point(11, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtn_Linear);
            this.groupBox3.Controls.Add(this.rbtn_Texture);
            this.groupBox3.Controls.Add(this.rbtn_Hatch);
            this.groupBox3.Controls.Add(this.rbtn_solid);
            this.groupBox3.Location = new System.Drawing.Point(11, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 186);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // rbtn_Linear
            // 
            this.rbtn_Linear.AutoSize = true;
            this.rbtn_Linear.Location = new System.Drawing.Point(18, 145);
            this.rbtn_Linear.Name = "rbtn_Linear";
            this.rbtn_Linear.Size = new System.Drawing.Size(150, 20);
            this.rbtn_Linear.TabIndex = 1;
            this.rbtn_Linear.Text = "LinearGradientBrush";
            this.rbtn_Linear.UseVisualStyleBackColor = true;
            // 
            // rbtn_Texture
            // 
            this.rbtn_Texture.AutoSize = true;
            this.rbtn_Texture.Location = new System.Drawing.Point(18, 105);
            this.rbtn_Texture.Name = "rbtn_Texture";
            this.rbtn_Texture.Size = new System.Drawing.Size(107, 20);
            this.rbtn_Texture.TabIndex = 1;
            this.rbtn_Texture.Text = "TextureBrush";
            this.rbtn_Texture.UseVisualStyleBackColor = true;
            // 
            // rbtn_Hatch
            // 
            this.rbtn_Hatch.AutoSize = true;
            this.rbtn_Hatch.Location = new System.Drawing.Point(18, 68);
            this.rbtn_Hatch.Name = "rbtn_Hatch";
            this.rbtn_Hatch.Size = new System.Drawing.Size(97, 20);
            this.rbtn_Hatch.TabIndex = 1;
            this.rbtn_Hatch.Text = "HatchBrush";
            this.rbtn_Hatch.UseVisualStyleBackColor = true;
            // 
            // rbtn_solid
            // 
            this.rbtn_solid.AutoSize = true;
            this.rbtn_solid.Checked = true;
            this.rbtn_solid.Location = new System.Drawing.Point(18, 30);
            this.rbtn_solid.Name = "rbtn_solid";
            this.rbtn_solid.Size = new System.Drawing.Size(93, 20);
            this.rbtn_solid.TabIndex = 1;
            this.rbtn_solid.TabStop = true;
            this.rbtn_solid.Text = "SolidBrush";
            this.rbtn_solid.UseVisualStyleBackColor = true;
            // 
            // ptb_paint
            // 
            this.ptb_paint.BackColor = System.Drawing.Color.White;
            this.ptb_paint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_paint.Location = new System.Drawing.Point(217, -1);
            this.ptb_paint.Name = "ptb_paint";
            this.ptb_paint.Size = new System.Drawing.Size(809, 601);
            this.ptb_paint.TabIndex = 1;
            this.ptb_paint.TabStop = false;
            this.ptb_paint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptb_paint_MouseDown);
            this.ptb_paint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptb_paint_MouseMove);
            this.ptb_paint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptb_paint_MouseUp);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(50, 542);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(103, 36);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 600);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.ptb_paint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bai 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_paint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_rec;
        private System.Windows.Forms.RadioButton rbtn_Line;
        private System.Windows.Forms.TextBox tb_Width;
        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.RadioButton rbtn_Elip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtn_Linear;
        private System.Windows.Forms.RadioButton rbtn_Texture;
        private System.Windows.Forms.RadioButton rbtn_Hatch;
        private System.Windows.Forms.RadioButton rbtn_solid;
        private System.Windows.Forms.PictureBox ptb_paint;
        private System.Windows.Forms.Button btn_reset;
    }
}

