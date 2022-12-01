using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public enum SeatColor { white, blue, yellow };
    public enum SeatType { a, b, c };
    public class Seat : Button
    {
        protected SeatColor _seatColor;
        public SeatColor SeatColor
        {
            get { return _seatColor; }
            set { 
                if(value == SeatColor.blue)
                {
                    this.BackColor = Color.Blue;
                }
                else if (value == SeatColor.yellow)
                {
                    this.BackColor = Color.Yellow;
                }
                else if (value == SeatColor.white)
                {
                    this.BackColor = Color.White;
                }
                _seatColor = value;
            }
        }
        protected long _price = 0;
        public long Price
        {
            get { return _price; }
        }

        protected SeatType _type;
        public SeatType Type
        {
            get { return this._type; }
            set
            {
                if( value == SeatType.a)
                {
                    _price = 5000;
                }
                if(value == SeatType.b)
                {
                    _price = 6500;
                }
                if (value == SeatType.c)
                {
                    _price = 8000;
                }
            }
        }
        protected int _value;
        public int Value
        {
            set 
            { 
                _value = value;
                this.Text = value.ToString();
            }
        }
        public int X;
        public int Y;

        public Seat(int x, int y, int value, int top, int left ,SeatColor seatColor, SeatType type)
        {
            SeatColor = seatColor;
            Type = type;

            this.Top = top;
            this.Left = left;
            X = x;
            Y = y;
            Value = value;
            this.Size = new Size(66, 60);
            this.FlatStyle = FlatStyle.Flat;
            this.Click += Seat_Click;
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            if(this.SeatColor == SeatColor.yellow)
            {
                MessageBox.Show("Ve nay da duoc ban");
            }
            else if (this.SeatColor == SeatColor.blue)
            {
                this.SeatColor = SeatColor.white;
            }
            else if (this.SeatColor == SeatColor.white)
            {
                this.SeatColor = SeatColor.blue;
            }
        }
    }
}
