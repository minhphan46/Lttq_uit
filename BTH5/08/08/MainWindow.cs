using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08
{
    public partial class MainWindow : Form
    {
        int second = 0;
        public MainWindow()
        {
            InitializeComponent();

            clock.Start();
        }

        //Anti Flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            second++;
            Sec.BackgroundImage = RotateImage(new Bitmap(Sec.BackgroundImage), 6);
            if (second % 60 == 0)
                Minute.BackgroundImage = RotateImage(new Bitmap(Minute.BackgroundImage), 6);
            if (second % 3600 == 0)
                Hour.BackgroundImage = RotateImage(new Bitmap(Hour.BackgroundImage), 30);
        }
    }
    
}
