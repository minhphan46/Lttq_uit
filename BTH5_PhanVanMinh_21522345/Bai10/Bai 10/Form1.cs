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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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
        private Graphics gDraw;
        private Bitmap bitmap;
        private Pen myPen;
        private Point startPoint;
        private Point endPoint;
        private Point nextPoint;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(ptb_paint.Width, ptb_paint.Height);
            ptb_paint.Image = bitmap;
            ptb_paint.BackgroundImageLayout = ImageLayout.None;
            gDraw = Graphics.FromImage(bitmap);
            gDraw.SmoothingMode = SmoothingMode.AntiAlias;
            graphics = ptb_paint.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            color = Color.Black;
            myPen = new Pen(color);
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
            cbb_dashStyle.SelectedIndex = 0;
            cbb_lineJoin.SelectedIndex = 0;
            cbb_dashCap.SelectedIndex = 0;
            cbb_StartCap.SelectedIndex = 0;
            cbb_EndCap.SelectedIndex = 0;
            cbb_width.Text = "8";
            changePen();
        }
        private void changePen()
        {
            try
            {
                width = float.Parse(cbb_width.Text);
                dashStyle = (DashStyle)cbb_dashStyle.SelectedItem;
                lineJoin = (LineJoin)cbb_lineJoin.SelectedItem;
                dashCap = (DashCap)cbb_dashCap.SelectedItem;
                startCap = (LineCap)cbb_StartCap.SelectedItem;
                endCap = (LineCap)cbb_EndCap.SelectedItem;
                myPen.DashStyle = dashStyle;
                myPen.Width = width;
                myPen.LineJoin = lineJoin;
                myPen.DashCap = dashCap;
                myPen.StartCap = startCap;
                myPen.EndCap = endCap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when set property of pen\n" + ex.ToString());
            }
        }
        private void cbb_width_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!float.TryParse(cbb_width.Text, out width) || width <= 0)
                {
                    MessageBox.Show("Width không hợp lệ", "Đã xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else changePen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Width khong hop le\n" + ex.ToString());
            }
        }
        bool isHoldMouse = false;
        bool drawJoinLine = false;
        private void ptb_paint_MouseDown(object sender, MouseEventArgs e)
        {
            changePen();
            if(e.Button == MouseButtons.Left)
            {
                isHoldMouse = true;
                startPoint = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                nextPoint = e.Location;
                drawJoinLine = true;
            }
        }

        private void ptb_paint_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawJoinLine)
            {
                Point[] dump = getPoints(20, startPoint, endPoint);
                gDraw.DrawLines(myPen, new Point[] { dump[18], endPoint, nextPoint });
                startPoint = endPoint;
                endPoint = nextPoint;
                drawJoinLine = false;
            }
            else
            {
                endPoint = e.Location;
                isHoldMouse = false;
                gDraw.DrawLine(myPen, startPoint, endPoint);
            }
            ptb_paint.Refresh();
        }

        private void ptb_paint_MouseMove(object sender, MouseEventArgs e)
        {
            if(isHoldMouse)
            {
                endPoint = e.Location;
                graphics.DrawLine(myPen, startPoint, endPoint);
            }
            ptb_paint.Refresh();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            gDraw.Clear(Color.White);
            ptb_paint.Refresh();
        }

        // ham lay list cac diem tren duong thang noi hai diem p1,p2
        public Point[] getPoints(int quantity, Point p1, Point p2)
        {
            var points = new Point[quantity];
            int ydiff = p2.Y - p1.Y, xdiff = p2.X - p1.X;
            double slope = (double)(p2.Y - p1.Y) / (p2.X - p1.X);
            double x, y;

            --quantity;

            for (double i = 0; i < quantity; i++)
            {
                y = slope == 0 ? 0 : ydiff * (i / quantity);
                x = slope == 0 ? xdiff * (i / quantity) : y / slope;
                points[(int)i] = new Point((int)Math.Round(x) + p1.X, (int)Math.Round(y) + p1.Y);
            }

            points[quantity] = p2;
            return points;
        }
    }
}
