using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        static public int[] generateArray(int n)
        {
            Random random = new Random();
            int[] newArr = new int[n];

            for(int i = 0; i < n; i++)
            {
                newArr[i] = random.Next(0, 100);
            }
            return newArr;
        }
        static public void printArray(int[] arr, int n)
        {
            Console.WriteLine(n + " elements of array:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        // cau a: tinh tong so le trong mang
        static public int SumOfOdd(int[] arr, int n)
        {
            int sum = 0;
            foreach (int x in arr) 
                if(x % 2 != 0)
                    sum += x;
            return sum;
        }
        // cau b: dem so nguyen to trong mang
        static public bool isPrime(int n)
        {
            if( n <= 1) return false;
            for (int i = 2; i*i <= n; i++)
            {
                if (n % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
        static public int PrimeCount(int[] arr, int n)
        {
            int count = 0;
            foreach (int x in arr)
                if (isPrime(x)) count++;
            return count;
        }
        // tim so chinh phuong nho nhat
        static public bool isSquareNum(int n)
        {
            for(int i = 0; i*i <= n; i++)
            {
                if (i * i == n) return true;
            }
            return false;
        }
        static public int MinSquareNum(int[] arr, int n)
        {
            int min = 1000000;
            foreach(int x in arr)
            {
                if(isSquareNum(x))
                    if(x < min) min = x;

            }
            return (min == 1000000)? -1 : min;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter num of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            arr = generateArray(n);
            printArray(arr, n);
            // cau a
            int sumOfOdd = SumOfOdd(arr, n);
            Console.WriteLine("Sum of odd elements: " + sumOfOdd);
            // cau b
            int primeCount = PrimeCount(arr, n);
            Console.WriteLine("Number of prime number: " + primeCount);
            // cau c
            int minSquareNum = MinSquareNum(arr, n);
            Console.WriteLine("Minimun square number:  " + minSquareNum);
        }
    }
}
