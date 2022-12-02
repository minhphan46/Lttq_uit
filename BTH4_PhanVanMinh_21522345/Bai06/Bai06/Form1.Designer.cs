namespace Bai06
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDich = new System.Windows.Forms.Button();
            this.tbDich = new System.Windows.Forms.TextBox();
            this.btnNguon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNguon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCopy = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnDich);
            this.panel1.Controls.Add(this.tbDich);
            this.panel1.Controls.Add(this.btnNguon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNguon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 277);
            this.panel1.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(347, 213);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(165, 43);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Sao chép";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDich
            // 
            this.btnDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDich.Location = new System.Drawing.Point(801, 140);
            this.btnDich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDich.Name = "btnDich";
            this.btnDich.Size = new System.Drawing.Size(75, 27);
            this.btnDich.TabIndex = 2;
            this.btnDich.Text = "...";
            this.btnDich.UseVisualStyleBackColor = true;
            this.btnDich.Click += new System.EventHandler(this.btnDich_Click);
            // 
            // tbDich
            // 
            this.tbDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDich.Location = new System.Drawing.Point(245, 142);
            this.tbDich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDich.Name = "tbDich";
            this.tbDich.Size = new System.Drawing.Size(529, 27);
            this.tbDich.TabIndex = 1;
            // 
            // btnNguon
            // 
            this.btnNguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguon.Location = new System.Drawing.Point(801, 81);
            this.btnNguon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNguon.Name = "btnNguon";
            this.btnNguon.Size = new System.Drawing.Size(75, 27);
            this.btnNguon.TabIndex = 2;
            this.btnNguon.Text = "...";
            this.btnNguon.UseVisualStyleBackColor = true;
            this.btnNguon.Click += new System.EventHandler(this.btnNguon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đường dãn thư mục nguồn";
            // 
            // tbNguon
            // 
            this.tbNguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNguon.Location = new System.Drawing.Point(245, 82);
            this.tbNguon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNguon.Name = "tbNguon";
            this.tbNguon.Size = new System.Drawing.Size(529, 27);
            this.tbNguon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dãn thư mục nguồn";
            // 
            // pbCopy
            // 
            this.pbCopy.Location = new System.Drawing.Point(27, 31);
            this.pbCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCopy.Name = "pbCopy";
            this.pbCopy.Size = new System.Drawing.Size(851, 23);
            this.pbCopy.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbCopy);
            this.panel2.Location = new System.Drawing.Point(51, 370);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 78);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(59, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sao chép tập tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(59, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiến trình sao chép";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDich;
        private System.Windows.Forms.TextBox tbDich;
        private System.Windows.Forms.Button btnNguon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNguon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbCopy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

