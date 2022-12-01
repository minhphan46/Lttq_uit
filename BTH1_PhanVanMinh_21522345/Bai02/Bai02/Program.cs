using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Program
    {
        static public bool isPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
        static long getSumOfPrime(int n)
        {
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                if(isPrime(i)) sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            // nhap n
            int n;
            do
            {
                Console.WriteLine("Nhap so nguyen duong n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            // tinh tong cac so nguyen to <n
            long sumOfPrime = getSumOfPrime(n);
            Console.WriteLine("Tong cac so nguyen to <n la: {0}", sumOfPrime);
        }
    }
}
