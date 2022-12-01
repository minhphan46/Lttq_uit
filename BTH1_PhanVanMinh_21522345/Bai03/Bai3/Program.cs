using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static bool checkValidDate(int ngay, int thang, int nam)
        {
            try
            {
                // tao mot doi tuong dateTime (nam, thang, ngay)
                DateTime checkDate = new DateTime(nam, thang, ngay);
                // in ra man hinh neu ngay hop le
                Console.Write("{0:d}", checkDate);
                Console.WriteLine(" la ngay hop le\n");
                return true;
            }
            catch
            {
                // in ra man hinh neu ngay khong hop le
                Console.Write("{0}/{1}/{2}", ngay, thang, nam);
                Console.Write(" La ngay khong hop le\n");
            }
            return false;
        }
        static void Main(string[] args)
        {
            // nhap ngay thang nam
            Console.Write("Nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            // kiem tra ngay co hop le hay khong
            checkValidDate(ngay, thang, nam);

            Console.ReadLine();
        }
    }
}
