using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class PhanSo
    {
        private int _tu;
        private int _mau;
        public int Tu
        {
            get { return _tu; }
            set { _tu = value; }
        }
        public int Mau
        {
            get { return _mau; }
            set
            {
                if (value == 0)
                    Console.WriteLine("Phan so khong ton");
                else if (value < 0)
                {
                    _mau = -value;
                    Tu = -Tu;
                }
                else _mau = value;
            }
        }

        // constructor
        public PhanSo() { }
        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau;
        }
        // nhap phan so
        public void NhapPhanSo()
        {
            Console.Write("Nhap tu: ");
            Tu = int.Parse(Console.ReadLine());
            int mau;
            do
            {
                Console.Write("Nhap mau: ");
                mau = int.Parse(Console.ReadLine());
            } while (mau == 0);
            Mau = mau;
            RutGonPhanSo();
        }
        // rut gon phan so
        public int Gcd(int a, int b)
        {
            if (b == 0) return a;
            return Gcd(b, a % b);
        }
        public void RutGonPhanSo()
        {
            int ucln = Gcd(Tu, Mau);
            Tu /= ucln;
            Mau /= ucln;
        }
        // xuat phan so
        public void XuatPhanSo()
        {
            Console.Write("{0}/{1} ", Tu, Mau);
        }
        // overide toan tu + - * /
        public static PhanSo operator + (PhanSo a, PhanSo b)
        {
            PhanSo tong = new PhanSo();
            tong.Tu = a.Tu * b.Mau + a.Mau * b.Tu;
            tong.Mau = a.Mau * b.Mau;
            tong.RutGonPhanSo();
            return tong;
        }
        public static PhanSo operator - (PhanSo a, PhanSo b)
        {
            PhanSo hieu = new PhanSo();
            hieu.Tu = a.Tu * b.Mau - a.Mau * b.Tu;
            hieu.Mau = a.Mau * b.Mau;
            hieu.RutGonPhanSo();
            return hieu;
        }
        public static PhanSo operator * (PhanSo a, PhanSo b)
        {
            PhanSo tich = new PhanSo();
            tich.Tu = a.Tu * b.Tu;
            tich.Mau = a.Mau * b.Mau;
            tich.RutGonPhanSo();
            return tich;
        }
        public static PhanSo operator / (PhanSo a, PhanSo b)
        {
            PhanSo thuong = new PhanSo();
            thuong.Tu = a.Tu * b.Mau;
            thuong.Mau = a.Mau * b.Tu;
            thuong.RutGonPhanSo();
            return thuong;
        }

        // overider toan tu > <
        public static bool operator > (PhanSo a, PhanSo b)
        {
            bool status = false;
            if (a.Tu * b.Mau > a.Mau * b.Tu)
                status = true;
            return status;
        }
        public static bool operator < (PhanSo a, PhanSo b)
        {
            bool status = false;
            if (a.Tu * b.Mau < a.Mau * b.Tu)
                status = true;
            return status;
        }
    }
}
