﻿namespace Bai04
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(248, 171);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(105, 49);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "ChangeColor";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnR
            // 
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Location = new System.Drawing.Point(383, 171);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(105, 49);
            this.btnR.TabIndex = 0;
            this.btnR.Text = "Reset";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnChange);
            this.Name = "Form1";
            this.Text = "Bai04";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnR;
    }
}

