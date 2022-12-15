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
            this.cbb_shape = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbb_shape
            // 
            this.cbb_shape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_shape.FormattingEnabled = true;
            this.cbb_shape.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Ellipse",
            "Pie",
            "Filled Circle",
            "Filled Square",
            "Filled Ellipse",
            "Filled Pie"});
            this.cbb_shape.Location = new System.Drawing.Point(26, 28);
            this.cbb_shape.Name = "cbb_shape";
            this.cbb_shape.Size = new System.Drawing.Size(176, 24);
            this.cbb_shape.TabIndex = 0;
            this.cbb_shape.SelectedIndexChanged += new System.EventHandler(this.cbb_shape_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbb_shape);
            this.Name = "Form1";
            this.Text = "Bai 9";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_shape;
    }
}

