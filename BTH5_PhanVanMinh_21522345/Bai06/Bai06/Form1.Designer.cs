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
            this.rtb_font = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_font
            // 
            this.rtb_font.Location = new System.Drawing.Point(12, 12);
            this.rtb_font.Name = "rtb_font";
            this.rtb_font.Size = new System.Drawing.Size(460, 540);
            this.rtb_font.TabIndex = 0;
            this.rtb_font.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 564);
            this.Controls.Add(this.rtb_font);
            this.Name = "Form1";
            this.Text = "Bai 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_font;
    }
}

