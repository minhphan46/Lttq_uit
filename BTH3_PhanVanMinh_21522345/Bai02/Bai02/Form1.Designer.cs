namespace Bai02
{
    partial class PaintEvent
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
            this.btn_paint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_paint
            // 
            this.btn_paint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_paint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_paint.Location = new System.Drawing.Point(329, 148);
            this.btn_paint.Name = "btn_paint";
            this.btn_paint.Size = new System.Drawing.Size(89, 46);
            this.btn_paint.TabIndex = 0;
            this.btn_paint.Text = "Paint";
            this.btn_paint.UseVisualStyleBackColor = true;
            this.btn_paint.Click += new System.EventHandler(this.btn_paint_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(329, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaintEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_paint);
            this.Name = "PaintEvent";
            this.Text = "PaintEvent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_paint;
        private System.Windows.Forms.Button button1;
    }
}

