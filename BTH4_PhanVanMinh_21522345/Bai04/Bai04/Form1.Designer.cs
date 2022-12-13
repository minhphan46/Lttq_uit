namespace Bai04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButon = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cb_font = new System.Windows.Forms.ToolStripComboBox();
            this.cb_size = new System.Windows.Forms.ToolStripComboBox();
            this.btn_bold = new System.Windows.Forms.ToolStripButton();
            this.tbn_italic = new System.Windows.Forms.ToolStripButton();
            this.btn_underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.richTb = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.editItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewItem,
            this.openItem,
            this.toolStripMenuItem2,
            this.saveItem,
            this.exitButon});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // CreateNewItem
            // 
            this.CreateNewItem.Image = ((System.Drawing.Image)(resources.GetObject("CreateNewItem.Image")));
            this.CreateNewItem.Name = "CreateNewItem";
            this.CreateNewItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateNewItem.Size = new System.Drawing.Size(285, 26);
            this.CreateNewItem.Text = "Tạo văn bản mới";
            this.CreateNewItem.Click += new System.EventHandler(this.CreateNewItem_Click);
            // 
            // openItem
            // 
            this.openItem.Image = ((System.Drawing.Image)(resources.GetObject("openItem.Image")));
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(285, 26);
            this.openItem.Text = "Mở tập tin";
            this.openItem.Click += new System.EventHandler(this.openItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(282, 6);
            // 
            // saveItem
            // 
            this.saveItem.Image = ((System.Drawing.Image)(resources.GetObject("saveItem.Image")));
            this.saveItem.Name = "saveItem";
            this.saveItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveItem.Size = new System.Drawing.Size(285, 26);
            this.saveItem.Text = "Lưu nội dung văn bản";
            // 
            // exitButon
            // 
            this.exitButon.Name = "exitButon";
            this.exitButon.Size = new System.Drawing.Size(285, 26);
            this.exitButon.Text = "Thoát";
            this.exitButon.Click += new System.EventHandler(this.exitButon_Click);
            // 
            // editItem
            // 
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(92, 26);
            this.editItem.Text = "Định dạng";
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.saveButton,
            this.toolStripSeparator1,
            this.cb_font,
            this.cb_size,
            this.btn_bold,
            this.tbn_italic,
            this.btn_underline,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.newButton.Size = new System.Drawing.Size(34, 28);
            this.newButton.Text = "btn_new";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.saveButton.Size = new System.Drawing.Size(34, 28);
            this.saveButton.Text = "btn_save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // cb_font
            // 
            this.cb_font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_font.Name = "cb_font";
            this.cb_font.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_font.Size = new System.Drawing.Size(210, 31);
            this.cb_font.TextChanged += new System.EventHandler(this.cb_font_TextChanged);
            // 
            // cb_size
            // 
            this.cb_size.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cb_size.Name = "cb_size";
            this.cb_size.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_size.Size = new System.Drawing.Size(75, 31);
            this.cb_size.TextChanged += new System.EventHandler(this.cb_size_TextChanged);
            // 
            // btn_bold
            // 
            this.btn_bold.BackColor = System.Drawing.SystemColors.Control;
            this.btn_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_bold.Image = global::Bai04.images.bold;
            this.btn_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_bold.Size = new System.Drawing.Size(34, 28);
            this.btn_bold.Text = "toolStripButton3";
            this.btn_bold.Click += new System.EventHandler(this.btn_bold_Click);
            // 
            // tbn_italic
            // 
            this.tbn_italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbn_italic.Image = ((System.Drawing.Image)(resources.GetObject("tbn_italic.Image")));
            this.tbn_italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbn_italic.Name = "tbn_italic";
            this.tbn_italic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tbn_italic.Size = new System.Drawing.Size(34, 28);
            this.tbn_italic.Text = "toolStripButton4";
            this.tbn_italic.Click += new System.EventHandler(this.tbn_italic_Click);
            // 
            // btn_underline
            // 
            this.btn_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_underline.Image = ((System.Drawing.Image)(resources.GetObject("btn_underline.Image")));
            this.btn_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_underline.Name = "btn_underline";
            this.btn_underline.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_underline.Size = new System.Drawing.Size(34, 28);
            this.btn_underline.Text = "btn_underline";
            this.btn_underline.Click += new System.EventHandler(this.btn_underline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // richTb
            // 
            this.richTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTb.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTb.Location = new System.Drawing.Point(0, 61);
            this.richTb.Margin = new System.Windows.Forms.Padding(4);
            this.richTb.Name = "richTb";
            this.richTb.Size = new System.Drawing.Size(800, 389);
            this.richTb.TabIndex = 2;
            this.richTb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTb);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateNewItem;
        private System.Windows.Forms.ToolStripMenuItem editItem;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem exitButon;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cb_font;
        private System.Windows.Forms.ToolStripComboBox cb_size;
        private System.Windows.Forms.ToolStripButton btn_bold;
        private System.Windows.Forms.ToolStripButton tbn_italic;
        private System.Windows.Forms.ToolStripButton btn_underline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.RichTextBox richTb;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

