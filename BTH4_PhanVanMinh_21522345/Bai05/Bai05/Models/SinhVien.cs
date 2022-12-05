using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05.Models
{
    internal class SinhVien
    {
        private long _mssv;
        public long MSSV
        {
            get { return _mssv; }
            set { _mssv = value; }
        }
        private string _hoTen;
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        private Khoa _khoa;
        public Khoa Khoa
        {
            get { return _khoa; }
            set { _khoa = value; }
        }
        private double _diemTB;
        public double DiemTB
        {
            get { return _diemTB; }
            set { _diemTB = value; }
        }
        public SinhVien(long mSSV, string hoTen, Khoa khoa, double diemTB)
        {
            MSSV = mSSV;
            HoTen = hoTen;
            Khoa = khoa;
            DiemTB = diemTB;
        }
    }
}
