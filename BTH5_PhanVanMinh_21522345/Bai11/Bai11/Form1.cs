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

namespace Bai11
{
    public partial class Form1 : Form
    {
        enum ShapeType { Line, Rectangle, Ellipse}

        private ShapeType _shapeType;
        private float _width;
        private Color _color;
        // graphic
        private Pen pen;
        private Brush _brush;
        private RectangleF _rec; // to draw linear
        private Graphics gTemp;
        private Graphics gBitmap;
        private Bitmap _bitmap;
        private Point startPoint = Point.Empty;
        private Point endPoint = Point.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _width = 10;
            _shapeType = ShapeType.Line;
            _color = Color.Black;
            tb_Width.Text = _width.ToString();
            // graphic
            _bitmap = new Bitmap(ptb_paint.Width, ptb_paint.Height);
            ptb_paint.Image = _bitmap;
            ptb_paint.BackgroundImageLayout = ImageLayout.None;
            gBitmap = Graphics.FromImage(_bitmap);
            gTemp = ptb_paint.CreateGraphics();
            gBitmap.SmoothingMode = SmoothingMode.AntiAlias;
            gTemp.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void tb_Width_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!float.TryParse(tb_Width.Text, out _width) || _width <= 0)
                {
                    MessageBox.Show("Width không hợp lệ", "Đã xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //else changePen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Width khong hop le\n" + ex.ToString());
            }
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                _color = btn_Color.BackColor = colorDlg.Color;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            gBitmap.Clear(Color.White);
            ptb_paint.Refresh();
        }
        private void setDrawProperty()
        {
            if (rbtn_Line.Checked) _shapeType = ShapeType.Line;
            else if (rbtn_rec.Checked) _shapeType = ShapeType.Rectangle;
            else _shapeType = ShapeType.Ellipse;
            pen = new Pen(_color, _width);
            if (rbtn_solid.Checked)
            {
                _brush = new SolidBrush(_color);
            }
            else if(rbtn_Hatch.Checked)
            {
                _brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
            }
            else if (rbtn_Texture.Checked)
            {
                _brush = new TextureBrush(image.pngwing_com);
            }
            else 
            {
                Size size = new Size(Math.Max(1, (int)_rec.Width), Math.Max(1, (int)_rec.Height));
                RectangleF r = new RectangleF(_rec.Location, size);
                _brush = new LinearGradientBrush(r, Color.Red, Color.Green, LinearGradientMode.Vertical);
            }
        }
        bool isHolding = false;
        private void ptb_paint_MouseDown(object sender, MouseEventArgs e)
        {
            isHolding = true;
            setDrawProperty();
            startPoint = e.Location;
        }

        private void ptb_paint_MouseUp(object sender, MouseEventArgs e)
        {
            isHolding = false;
            endPoint = e.Location;
            Drawing(gBitmap);
        }

        private void ptb_paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isHolding)
            {
                endPoint = e.Location;
                Drawing(gTemp);
            }
        }
        private void Drawing(Graphics g)
        {
            _rec = GetRectangleF(startPoint, endPoint);
            if (_shapeType == ShapeType.Line)
            {
                g.DrawLine(pen, startPoint, endPoint);
            }
            else if (_shapeType == ShapeType.Rectangle)
            {
                setDrawProperty();
                g.FillRectangle(_brush, _rec);
            }
            else
            {
                setDrawProperty();
                g.FillEllipse(_brush, _rec);
            }
            ptb_paint.Refresh();
        }
        private RectangleF GetRectangleF(Point start, Point end)
        {
            RectangleF rec = new RectangleF(
                    Math.Min(start.X, end.X),
                    Math.Min(start.Y, end.Y),
                    Math.Abs(start.X - end.X),
                    Math.Abs(start.Y - end.Y));
            return rec;
        }
    }
}
