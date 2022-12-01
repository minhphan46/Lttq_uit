using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    public enum Loai { KhuDat, NhaPho, ChungCu };
    internal class KhuDat
    {
        public Loai Loai { get; set; }
        private string _diaDiem;
        public string DiaDiem { get { return _diaDiem; } set { _diaDiem = value; } }

        private long _giaBan;
        public long GiaBan { get { return _giaBan; } set { _giaBan = value; } }

        private double _dienTich;
        public double DienTich { get { return _dienTich; } set { _dienTich = value; } }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap thong tin: ");
            Console.WriteLine("Nhap dia diem: ");
            DiaDiem = Console.ReadLine();
            Console.WriteLine("Nhap gia ban: ");
            GiaBan = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dien tich: ");
            DienTich = long.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            //Console.WriteLine("Thong tin Khu Da la: ");
            Console.WriteLine("Dia diem: " + DiaDiem);
            Console.WriteLine("Gia ban: {0}", GiaBan);
            Console.WriteLine("Dien tich: {0}", DienTich);
        }
    }
}
