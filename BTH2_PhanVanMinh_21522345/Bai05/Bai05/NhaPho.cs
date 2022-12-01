using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class NhaPho : KhuDat
    {
        private int _namXayDung;
        public int NamXayDung { get { return _namXayDung; } set { _namXayDung = value; } }

        private int _soTang;
        public int SoTang { get { return _soTang; } set { _soTang = value; } }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap nam xay dung: ");
            NamXayDung = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tang: ");
            SoTang = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Nam xay dung: {0}", NamXayDung);
            Console.WriteLine("So tang: {0}", SoTang);
        }
    }
}
