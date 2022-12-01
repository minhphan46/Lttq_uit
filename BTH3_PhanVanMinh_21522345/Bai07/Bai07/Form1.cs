using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai07
{
    public partial class Form1 : Form
    {
        Seat[,] _seats = new Seat[3, 5];
        long _total = 0;
        public Form1()
        {
            InitializeComponent();
            textBox.ReadOnly = true;
            init();
        }

        public void init()
        {
            int count = 1;
            int top = 17;
            int left = 29;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Seat seat = new Seat(i,j, count, top, left, SeatColor.white, SeatType.a);
                    _seats[i,j] = seat;
                    panelSeats.Controls.Add(seat);
                    count++;
                    left += 75;
                }
                left = 29;
                top += 65;
            }
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(_seats[i, j].SeatColor == SeatColor.blue)
                    {
                        _total += _seats[i, j].Price;
                        _seats[i, j].SeatColor = SeatColor.yellow;
                    }
                }
            }
            textBox.Text = _total.ToString();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            _total = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (_seats[i, j].SeatColor == SeatColor.blue)
                    {
                        _seats[i, j].SeatColor = SeatColor.white;
                    }
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            _total = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    _seats[i, j].SeatColor = SeatColor.white;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat khong?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
