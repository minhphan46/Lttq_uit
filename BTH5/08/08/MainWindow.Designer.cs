namespace _08
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.Hour = new System.Windows.Forms.Panel();
            this.Minute = new System.Windows.Forms.Panel();
            this.Sec = new System.Windows.Forms.Panel();
            this.CenterPoint = new System.Windows.Forms.Panel();
            this.Hour.SuspendLayout();
            this.Minute.SuspendLayout();
            this.Sec.SuspendLayout();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // Hour
            // 
            this.Hour.BackColor = System.Drawing.Color.Transparent;
            this.Hour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hour.BackgroundImage")));
            this.Hour.Controls.Add(this.Minute);
            this.Hour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hour.Location = new System.Drawing.Point(0, 0);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(800, 800);
            this.Hour.TabIndex = 0;
            // 
            // Minute
            // 
            this.Minute.BackColor = System.Drawing.Color.Transparent;
            this.Minute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minute.BackgroundImage")));
            this.Minute.Controls.Add(this.Sec);
            this.Minute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minute.Location = new System.Drawing.Point(0, 0);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(800, 800);
            this.Minute.TabIndex = 1;
            // 
            // Sec
            // 
            this.Sec.BackColor = System.Drawing.Color.Transparent;
            this.Sec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sec.BackgroundImage")));
            this.Sec.Controls.Add(this.CenterPoint);
            this.Sec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sec.Location = new System.Drawing.Point(0, 0);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(800, 800);
            this.Sec.TabIndex = 2;
            // 
            // CenterPoint
            // 
            this.CenterPoint.BackColor = System.Drawing.Color.Transparent;
            this.CenterPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CenterPoint.BackgroundImage")));
            this.CenterPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPoint.Location = new System.Drawing.Point(0, 0);
            this.CenterPoint.Name = "CenterPoint";
            this.CenterPoint.Size = new System.Drawing.Size(800, 800);
            this.CenterPoint.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.Hour);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analog Clock";
            this.Hour.ResumeLayout(false);
            this.Minute.ResumeLayout(false);
            this.Sec.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Panel Hour;
        private System.Windows.Forms.Panel Minute;
        private System.Windows.Forms.Panel Sec;
        private System.Windows.Forms.Panel CenterPoint;
    }
}

