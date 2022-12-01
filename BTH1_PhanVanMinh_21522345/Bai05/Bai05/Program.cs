using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        static String dayOfWeek(int ngay, int thang, int nam)
        {
            try
            {
                DateTime dateTime = new DateTime(nam, thang, ngay);
                return dateTime.DayOfWeek.ToString();
            }
            catch
            {
                Console.WriteLine("Ngay khong hop le.");
                return "";
            }
        }
        static void Main(string[] args)
        {
            // nhap ngay, thang, nam
            Console.Write("Nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            // Lay thu trong tuan
            String thuTrongTuan = dayOfWeek(ngay, thang, nam);
            if(thuTrongTuan != "")
            {
                Console.WriteLine("Thu trong tuan: " + thuTrongTuan);
            }

        }
    }
}
