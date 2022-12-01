namespace Bai03
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
            this.btn_change_color = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_change_color
            // 
            this.btn_change_color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_change_color.Location = new System.Drawing.Point(321, 165);
            this.btn_change_color.Name = "btn_change_color";
            this.btn_change_color.Size = new System.Drawing.Size(135, 53);
            this.btn_change_color.TabIndex = 0;
            this.btn_change_color.Text = "Change Color";
            this.btn_change_color.UseVisualStyleBackColor = true;
            this.btn_change_color.Click += new System.EventHandler(this.btn_change_color_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Location = new System.Drawing.Point(321, 224);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(135, 53);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_change_color);
            this.Name = "Form1";
            this.Text = "ChangeColor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_change_color;
        private System.Windows.Forms.Button btn_reset;
    }
}

