using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class ChungCu : KhuDat
    {
        private int _tang;
        public int Tang { get { return _tang; } set { _tang = value; } }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap tang: ");
            Tang = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Tang: {0}", Tang);
        }
    }
}
