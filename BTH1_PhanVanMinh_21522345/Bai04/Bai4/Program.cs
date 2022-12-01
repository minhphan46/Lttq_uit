using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static int getNumOfDays(int thang, int nam)
        {
            try
            {
                return DateTime.DaysInMonth(nam, thang);
            }
            catch
            {
                Console.WriteLine("thang nam khong hop le.");
                return 0;
            }
            
        }
        static void Main(string[] args)
        {
            // nhap ngay, thang
            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            // lay so ngay cua thang
            int numOfDays = getNumOfDays(thang, nam);
            if(numOfDays != 0)
                Console.WriteLine("So ngay cua thang la: {0}", numOfDays);
        }
    }
}
