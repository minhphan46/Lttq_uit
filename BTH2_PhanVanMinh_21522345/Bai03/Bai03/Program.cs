using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so Hang : ");
            int hang = int.Parse(Console.ReadLine());
            Console.Write("Nhap so Cot : ");
            int cot = int.Parse(Console.ReadLine());
            MaTran matran = new MaTran(hang,cot);
            // cau a
            matran.nhapMaTran();
            matran.xuatMatran();
            // cua b
            Console.Write("Nhap so can tim trong ma tran : ");
            int x = int.Parse(Console.ReadLine());
            matran.timKiemPhanTu(x);
            // cau c
            matran.xuatSoNguyenTo();
            // cau d
            matran.timDongNhieuSoNguyenToNhat();

            Console.ReadLine();
        }
    }
}
/* test data
4
4
1
2
3
4
3
3
3
3
9
10
11
12
13
14
15
16
3
 */