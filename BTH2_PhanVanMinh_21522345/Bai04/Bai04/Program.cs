using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Program
    {
        public static PhanSo FindMaxElement(List<PhanSo> listPs)
        {
            PhanSo maxPs = new PhanSo();
            for(int i = 0; i < listPs.Count; i++)
            {
                if(i == 0 || maxPs < listPs[i]) { maxPs = listPs[i]; }
            }
            return maxPs;
        }
        public static List<PhanSo> SortPs(List<PhanSo> listPs)
        {
            for(int i = 0; i < listPs.Count; i++)
            {
                for(int j = 0; j < listPs.Count; j++)
                {
                    if(listPs[i] < listPs[j])
                    {
                        PhanSo tmp = listPs[i];
                        listPs[i] = listPs[j];
                        listPs[j] = tmp;
                    }
                }
            }
            return listPs;
        }
        public static void TinhToanPhanSo()
        {
            Console.WriteLine("Nhap phan so 1: ");
            PhanSo ps1 = new PhanSo();
            ps1.NhapPhanSo();
            Console.WriteLine("Nhap phan so 2: ");
            PhanSo ps2 = new PhanSo();
            ps2.NhapPhanSo();
            Console.Write("\nTong hai phan so la: ");
            (ps1 + ps2).XuatPhanSo();
            Console.Write("\nHieu hai phan so la: ");
            (ps1 - ps2).XuatPhanSo();
            Console.Write("\nTich hai phan so la: ");
            (ps1 * ps2).XuatPhanSo();
            Console.Write("\nThuong hai phan so la: ");
            (ps1 / ps2).XuatPhanSo();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // phan 1 : tinh tong hieu tich thuong hai phan so
            TinhToanPhanSo();
            // phan 2 :
            Console.Write("\nNhap so phan so: ");
            int n = int.Parse(Console.ReadLine());

            List<PhanSo> listPs = new List<PhanSo>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan so {0}: ", i);
                PhanSo temp = new PhanSo();
                temp.NhapPhanSo();
                listPs.Add(temp);
            }
            Console.WriteLine("Day phan so da nhap la: ");
            for (int i = 0; i < n; i++)
            {
                listPs[i].XuatPhanSo();
                Console.WriteLine();
            }
            
            // cau a
            PhanSo maxPs = FindMaxElement(listPs);
            Console.Write("Phan so lon nhat la: ");
            maxPs.XuatPhanSo();
            Console.WriteLine();

            // cau b
            List<PhanSo> sortList = SortPs(listPs);
            Console.WriteLine("Day phan so sau khi sort la: ");
            for (int i = 0; i < sortList.Count; i++)
            {
                sortList[i].XuatPhanSo();
            }
            Console.ReadLine();
        }
    }
}
/* test data
1
2
3
5
5
1
2
2
6
3
4
5
7
8
10
*/