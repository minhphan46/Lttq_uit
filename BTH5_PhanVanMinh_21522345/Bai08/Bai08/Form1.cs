using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        int WIDTH = 300, HEIGHT = 300;
        float fRadius;
        //center
        int cx, cy;

        Bitmap bmp;
        Graphics g;
        float fHourLength;
        float fMinLength;
        float fSecLength;

        float fHourThickness;
        float fMinThickness;
        float fSecThickness;
        public Form1()
        {
            InitializeComponent();
            this.fHourLength = (float)this.Height / 3 / 1.65F;
            this.fMinLength = (float)this.Height / 3 / 1.20F;
            this.fSecLength = (float)this.Height / 3 / 1.15F;
            this.fHourThickness = (float)this.Height / 100;
            this.fMinThickness = (float)this.Height / 150;
            this.fSecThickness = (float)this.Height / 200;
            this.fRadius = 210;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create bitmap
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            //center
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //backcolor
            this.BackColor = Color.Black;

            //timer
            t.Interval = 1000;      //in millisecond
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }
        private void t_Tick(object sender, EventArgs e)
        {
            //create graphics
            g = Graphics.FromImage(bmp);

            //get time
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            float fRadHr = (float)((hh % 12 + mm / 60F) * 30 * Math.PI / 180);
            float fRadMin = (float)((mm) * 6 * Math.PI / 180);
            float fRadSec = (float)((ss) * 6 * Math.PI / 180);

            //clear
            g.Clear(Color.Black);
            //draw clock
            drawClock();
            //hour hand
            DrawPolygon(this.fHourThickness, this.fHourLength, Color.MediumVioletRed, fRadHr, g);
            //minute hand
            DrawPolygon(this.fMinThickness, this.fMinLength, Color.SteelBlue, fRadMin, g);
            //second hand
            DrawLine(this.fSecThickness, this.fSecLength, Color.White, fRadSec, g);
            // draw circle at center
            g.FillEllipse(new SolidBrush(Color.White), cx - 5, cy - 5, 10, 10);
            //load bmp in picturebox1
            pictureBox1.Image = bmp;

            //disp time
            this.Text = "Analog Clock -  " + hh + ":" + mm + ":" + ss;

            //dispose
            g.Dispose();
        }
        // draw clock
        private void drawClock()
        {
            for (int i = 0; i < 60; i++)
            {
                if (i % 5 == 0) // Draw 5 minute ticks
                {
                    g.FillEllipse(
                        new SolidBrush(Color.White),
                        cx + (float)(this.fRadius / 1.50F * System.Math.Sin(i * 6 * Math.PI / 180)),
                        cy - (float)(this.fRadius / 1.50F * System.Math.Cos(i * 6 * Math.PI / 180)),
                        6, 
                        6);
                }
                else // draw 1 minute ticks
                {
                    g.FillEllipse(
                        new SolidBrush(Color.White),
                        cx + (float)(this.fRadius / 1.50F * System.Math.Sin(i * 6 * Math.PI / 180)),
                        cy - (float)(this.fRadius / 1.50F * System.Math.Cos(i * 6 * Math.PI / 180)),
                        2, 
                        2);
                }
            }
        }
        // draw clock hand
        private void DrawPolygon(float fThickness, float fLength, Color color, float fRadians, Graphics g)
        {

            PointF A = new PointF((float)(cx +
                     fThickness * 2 * System.Math.Sin(fRadians + Math.PI / 2)),
                     (float)(cy -
                     fThickness * 2 * System.Math.Cos(fRadians + Math.PI / 2)));
            PointF B = new PointF((float)(cx +
                     fThickness * 2 * System.Math.Sin(fRadians - Math.PI / 2)),
                    (float)(cy -
                    fThickness * 2 * System.Math.Cos(fRadians - Math.PI / 2)));
            PointF C = new PointF((float)(cx +
                     fLength * System.Math.Sin(fRadians)),
                     (float)(cy -
                     fLength * System.Math.Cos(fRadians)));
            PointF D = new PointF((float)(cx -
                     fThickness * 4 * System.Math.Sin(fRadians)),
                     (float)(cy +
                     fThickness * 4 * System.Math.Cos(fRadians)));
            PointF[] points = { A, D, B, C };
            g.FillPolygon(new SolidBrush(color), points);
        }
        private void DrawLine(float fThickness, float fLength, Color color, float fRadians, Graphics g)
        {
            g.DrawLine(new Pen(color, fThickness),
            cx - (float)(fLength / 9 * System.Math.Sin(fRadians)),
            cy + (float)(fLength / 9 * System.Math.Cos(fRadians)),
            cx + (float)(fLength * System.Math.Sin(fRadians)),
            cy - (float)(fLength * System.Math.Cos(fRadians)));
        }
    }
}
