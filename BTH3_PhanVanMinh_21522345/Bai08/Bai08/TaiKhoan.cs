using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
    internal class TaiKhoan
    {
        protected int soTaiKhoan;
        protected string ten;
        protected string diaChi;
        protected decimal soTien;

        public int SoTaiKhoan {
           get { return soTaiKhoan; }
        }
        public decimal SoTien
        {
            get { return soTien; }
        }
        public string Ten
        {
            get { return ten; }
        }
        public string DiaChi
        {
            get { return diaChi; }
        }
        public TaiKhoan(int soTaiKhoan, string ten, string diaChi, decimal soTien)
        {
            this.soTaiKhoan = soTaiKhoan;
            this.ten = ten;
            this.diaChi = diaChi;
            this.soTien = soTien;
        }
    }
}
