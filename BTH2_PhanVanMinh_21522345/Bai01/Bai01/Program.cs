using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        static void PrintCalendar(string[,] calendar)
        {
            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    if (calendar[i, j] == null) calendar[i, j] = "";
                    Console.Write(calendar[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static string[,] SetCalendar(int thang, int nam, int numOfDays)
        {
            string[,] calendar = new string[7, 7];
            calendar[0, 0] = "Sun";
            calendar[0, 1] = "Mon";
            calendar[0, 2] = "Tue";
            calendar[0, 3] = "Web";
            calendar[0, 4] = "Thu";
            calendar[0, 5] = "Fri";
            calendar[0, 6] = "Sat";

            int count = 1;
            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (count > numOfDays) return calendar;
                    if ( i == 1 && j == 0)
                    {
                        DateTime dateTime = new DateTime(nam, thang, i);
                        if (dateTime.DayOfWeek == DayOfWeek.Sunday) j = 0;
                        if (dateTime.DayOfWeek == DayOfWeek.Monday) j = 1;
                        if (dateTime.DayOfWeek == DayOfWeek.Tuesday) j = 2;
                        if (dateTime.DayOfWeek == DayOfWeek.Wednesday) j = 3;
                        if (dateTime.DayOfWeek == DayOfWeek.Thursday) j = 4;
                        if (dateTime.DayOfWeek == DayOfWeek.Friday) j = 5;
                        if (dateTime.DayOfWeek == DayOfWeek.Saturday) j = 6;
                    }
                    calendar[i, j] = count.ToString();
                    count++;
                }
            }
            return calendar;
        }
        static int GetNumOfDays(int thang, int nam)
        {
            try
            {
                int numOfDays = DateTime.DaysInMonth(nam, thang);
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
            string[,] calendar = new string[7, 7];

            // nhap ngay, thang
            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            // lay so ngay cua thang
            int numOfDays = GetNumOfDays(thang, nam);
            if (numOfDays == 0)
            {
                Console.ReadLine();
                return;
            }
            // set gia tri calenda
            calendar = SetCalendar(thang, nam, numOfDays);
            // in calenda
            PrintCalendar(calendar);

            Console.ReadLine();
        }
    }
}
