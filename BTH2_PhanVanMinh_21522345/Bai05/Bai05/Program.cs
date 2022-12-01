using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyNhaDat quanLyNhaDat = new QuanLyNhaDat();
            // cau 2
            quanLyNhaDat.NhapDanhSachNhaDat();
            quanLyNhaDat.XuatDanhSachNhaDat();
            // cau 3
            quanLyNhaDat.TingTongGiaBan();
            // cau 4
            quanLyNhaDat.FiterListNhaDat();
            // cau 5
            quanLyNhaDat.searchNhaDat();
            Console.ReadLine();
        }
    }
}
/* test Data
3
1
Ho CHi Minh
1250000
150
2
Ha Noi
2345000
100
2019
10
3
Ha Noi
3125113
160
7
HA NOI
5000000
100
*/
