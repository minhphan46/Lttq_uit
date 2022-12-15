using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_10
{
    public partial class Form1 : Form
    {
        // property
        private DashStyle dashStyle;
        private float width;
        private LineJoin lineJoin;
        private DashCap dashCap;
        private LineCap startCap;
        private LineCap endCap;
        private Color color;
        // graphic
        private Graphics graphics;
        private Graphics g;
        private Bitmap bitmap;
        private Pen pen;
        private Point startPoint;
        private Point endPoint;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(ptb_paint.Width, ptb_paint.Height);
            graphics = ptb_paint.CreateGraphics();
            ptb_paint.Image = bitmap;
            ptb_paint.BackgroundImageLayout = ImageLayout.None;
            g = Graphics.FromImage(bitmap);
            color = Color.Black;
            pen = new Pen(color);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Enum.GetValues(typeof(DashStyle)).Cast<DashStyle>().ToList().ForEach(x =>
            {
                cbb_dashStyle.Items.Add(x);
            });
            Enum.GetValues(typeof(LineJoin)).Cast<LineJoin>().ToList().ForEach(x =>
            {
                cbb_lineJoin.Items.Add(x);
            });
            Enum.GetValues(typeof(DashCap)).Cast<DashCap>().ToList().ForEach(x =>
            {
                cbb_dashCap.Items.Add(x);
            });
            Enum.GetValues(typeof(LineCap)).Cast<LineCap>().ToList().ForEach(x =>
            {
                cbb_StartCap.Items.Add(x);
                cbb_EndCap.Items.Add(x);
            });
            for(int i = 1; i < 20; i++)
            {
                cbb_width.Items.Add(i);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
