namespace _04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bold = new System.Windows.Forms.CheckBox();
            this.italic = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.underlined = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pickColor = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.right = new System.Windows.Forms.RadioButton();
            this.center = new System.Windows.Forms.RadioButton();
            this.left = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontComboBox
            // 
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.Location = new System.Drawing.Point(59, 20);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(158, 21);
            this.fontComboBox.TabIndex = 0;
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(80, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bold
            // 
            this.bold.AutoSize = true;
            this.bold.Location = new System.Drawing.Point(59, 62);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(15, 14);
            this.bold.TabIndex = 3;
            this.bold.UseVisualStyleBackColor = true;
            this.bold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // italic
            // 
            this.italic.AutoSize = true;
            this.italic.Location = new System.Drawing.Point(116, 62);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(15, 14);
            this.italic.TabIndex = 5;
            this.italic.UseVisualStyleBackColor = true;
            this.italic.CheckedChanged += new System.EventHandler(this.italic_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(137, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // underlined
            // 
            this.underlined.AutoSize = true;
            this.underlined.Location = new System.Drawing.Point(176, 62);
            this.underlined.Name = "underlined";
            this.underlined.Size = new System.Drawing.Size(15, 14);
            this.underlined.TabIndex = 7;
            this.underlined.UseVisualStyleBackColor = true;
            this.underlined.CheckedChanged += new System.EventHandler(this.underlined_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(197, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(276, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size";
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.FormattingEnabled = true;
            this.fontSizeComboBox.Location = new System.Drawing.Point(323, 20);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(75, 21);
            this.fontSizeComboBox.TabIndex = 8;
            this.fontSizeComboBox.TextChanged += new System.EventHandler(this.fontSizeComboBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(276, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Color";
            // 
            // pickColor
            // 
            this.pickColor.BackColor = System.Drawing.Color.Red;
            this.pickColor.Location = new System.Drawing.Point(323, 56);
            this.pickColor.Name = "pickColor";
            this.pickColor.Size = new System.Drawing.Size(75, 23);
            this.pickColor.TabIndex = 11;
            this.pickColor.UseVisualStyleBackColor = false;
            this.pickColor.Click += new System.EventHandler(this.pickColor_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contentPanel.Location = new System.Drawing.Point(137, 106);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(261, 118);
            this.contentPanel.TabIndex = 12;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.right);
            this.groupBox1.Controls.Add(this.center);
            this.groupBox1.Controls.Add(this.left);
            this.groupBox1.Location = new System.Drawing.Point(16, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aligin Text";
            // 
            // right
            // 
            this.right.AutoSize = true;
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.right.Location = new System.Drawing.Point(23, 86);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(54, 19);
            this.right.TabIndex = 21;
            this.right.Text = "Right";
            this.right.UseVisualStyleBackColor = true;
            this.right.CheckedChanged += new System.EventHandler(this.right_CheckedChanged);
            // 
            // center
            // 
            this.center.AutoSize = true;
            this.center.Checked = true;
            this.center.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.center.Location = new System.Drawing.Point(23, 56);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(61, 19);
            this.center.TabIndex = 20;
            this.center.TabStop = true;
            this.center.Text = "Center";
            this.center.UseVisualStyleBackColor = true;
            this.center.CheckedChanged += new System.EventHandler(this.center_CheckedChanged);
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.left.Location = new System.Drawing.Point(23, 26);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(45, 19);
            this.left.TabIndex = 19;
            this.left.Text = "Left";
            this.left.UseVisualStyleBackColor = true;
            this.left.CheckedChanged += new System.EventHandler(this.left_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.pickColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fontSizeComboBox);
            this.Controls.Add(this.underlined);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fontComboBox);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.CheckBox italic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox underlined;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fontSizeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pickColor;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton right;
        private System.Windows.Forms.RadioButton center;
        private System.Windows.Forms.RadioButton left;
    }
}

