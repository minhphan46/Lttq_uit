using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class Program
    {
        static int[,] generateArr(int n, int m)
        {
            int[,] arr = new int[n, m];
            Random random = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i,j] = random.Next(0,100);
                }
            }
            return arr;
        }
        // cau a: xuat ra ma tran
        static void printArr(int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j]+ "\t");
                }
                Console.WriteLine();
            }
        }
        // cau b: tim  phan tu lon nhat, nho nhat
        static int findMaxElenment(int[,] arr, int n, int m)
        {
            int max = -999999;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max < arr[i, j]) max = arr[i, j];
                }
            }
            return max;
        }
        static int findMinElenment(int[,] arr, int n, int m)
        {
            int min = 999999;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > arr[i, j]) min = arr[i, j];
                }
            }
            return min;
        }
        // cau c: tim dong co tong lon nhat
        static int timDongCoTongLonNhat(int[,] arr, int n, int m)
        {
            int maxRow = 0;
            int maxSum = -999999;
            for(int i = 0; i < n; i++)
            {
                int sum = 0;
                for(int j = 0; j < m; j++)
                {
                    sum += arr[i,j];
                }
                if(sum > maxSum)
                {
                    maxRow = i;
                    maxSum = sum;
                }
            }
            return maxRow;
        }
        // cau d: tinh tong cac so khong phai la so nguyen to
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
        static long tinhTongCacSoKhongLaSoNguyenTo(int[,] arr, int n, int m)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!isPrime(arr[i,j]))
                        sum += arr[i, j];
                }
            }
            return sum;
        }
        // cau e: xoa dong thu k trong ma tran
        static int[,] xoaDongThuKTrongMatran(int[,] arr, int n, int m, int k)
        {
            int[,] newArr = new int[n-1, m];
            for(int i = 0; i < n; i++)
            {
                if (i == k) continue;
                for(int j = 0; j < m; j++)
                {
                    if(i > k)
                    {
                        newArr[i-1, j] = arr[i, j];
                    }
                    else newArr[i, j] = arr[i, j];
                }
            }
            return newArr;
        }
        // cau f: xoa cot chua phan tu lon nhat trong ma tran
        static int[,] xoaCotChuaPhanTuLonNhat(int[,] arr, int n, int m)
        {
            int maxElement = findMaxElenment(arr, n, m);
            // tim cot co phan tu lon nhat
            int colunmOfMaxElement = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(arr[i, j] == maxElement)
                    {
                        colunmOfMaxElement = j;
                        break;
                    }
                }
            }
            // xoa cot
            int[,] newArr = new int[n, m - 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j == colunmOfMaxElement) continue;
                    if (j > colunmOfMaxElement)
                    {
                        newArr[i, j-1] = arr[i, j];
                    }
                    else newArr[i, j] = arr[i, j];
                }
            }
            return newArr;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int m = int.Parse(Console.ReadLine());

            // cau a
            int[,] arr = generateArr(n, m);
            Console.WriteLine("\nMa tran duoc khoi tao la: ");
            printArr(arr, n, m);

            // cau b
            int maxElenment = findMaxElenment(arr, n, m);
            Console.WriteLine("Phan tu lon nhat: {0}", maxElenment);
            int minElenment = findMinElenment(arr, n, m);
            Console.WriteLine("Phan tu nho nhat: {0}", minElenment);

            // cau c
            int maxRow = timDongCoTongLonNhat(arr, n, m);
            Console.WriteLine("Dong co tong lon nhat: {0}",maxRow);

            // cau d
            long tongKhongPhaiSoNguyenTo = tinhTongCacSoKhongLaSoNguyenTo(arr, n, m);
            Console.WriteLine("Tong cac so khong phai so nguyen to: {0}", tongKhongPhaiSoNguyenTo);

            // cau e
            Console.WriteLine("Nhap dong thu k de xoa: ");
            int k = int.Parse(Console.ReadLine());
            int[,] arrAfterDelete = xoaDongThuKTrongMatran(arr, n, m, k);
            Console.WriteLine("Ma tran sau khi xoa la: ");
            printArr(arrAfterDelete,n-1,m);

            // cau f
            int[,] arrAfterDeleteMaxColumn = xoaCotChuaPhanTuLonNhat(arr, n, m);
            Console.WriteLine("Ma tran sau khi xoa cot co phan tu lon nhat la: ");
            printArr(arrAfterDeleteMaxColumn, n, m-1);


            Console.ReadLine();
        }
    }
}
