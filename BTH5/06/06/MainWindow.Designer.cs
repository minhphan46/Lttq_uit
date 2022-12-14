namespace _06
{
    partial class MainWindow
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
            this.fontTextBox = new System.Windows.Forms.RichTextBox();
            this.loadingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontTextBox
            // 
            this.fontTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontTextBox.BackColor = System.Drawing.Color.White;
            this.fontTextBox.Location = new System.Drawing.Point(12, 13);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.ReadOnly = true;
            this.fontTextBox.Size = new System.Drawing.Size(666, 566);
            this.fontTextBox.TabIndex = 1;
            this.fontTextBox.Text = "";
            // 
            // loadingButton
            // 
            this.loadingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.loadingButton.ForeColor = System.Drawing.Color.Red;
            this.loadingButton.Location = new System.Drawing.Point(247, 585);
            this.loadingButton.Name = "loadingButton";
            this.loadingButton.Size = new System.Drawing.Size(223, 41);
            this.loadingButton.TabIndex = 2;
            this.loadingButton.Text = "Load all fonts from system";
            this.loadingButton.UseVisualStyleBackColor = true;
            this.loadingButton.Click += new System.EventHandler(this.loadingButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 634);
            this.Controls.Add(this.loadingButton);
            this.Controls.Add(this.fontTextBox);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Font";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox fontTextBox;
        private System.Windows.Forms.Button loadingButton;
    }
}

