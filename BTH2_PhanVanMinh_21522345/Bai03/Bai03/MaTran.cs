using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class MaTran
    {
        private int _hang;
        private int _cot;
        private int[,] _maTranHaiChieu;
        public int Hang { 
            get { return _hang; } 
            set { _hang = value; } 
        }
        public int Cot { 
            get { return _cot; } 
            set { _cot = value; } 
        }
        public int[,] MaTranHaiChieu {
            get { return _maTranHaiChieu; }
        }

        public MaTran(int hang, int cot)
        {
            this.Hang = hang;
            this.Cot = cot;
            _maTranHaiChieu = new int[hang, cot];
        }
        // cau a : Nhập / xuất ma trận hai chiều các số nguyên
        public void nhapMaTran()
        {
            for(int i = 0; i < Hang; i++)
            {
                for(int j = 0; j < Cot; j++)
                {
                    Console.Write("Nhap gia tri [{0},{1}]: ", i, j);
                    _maTranHaiChieu[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void xuatMatran()
        {
            Console.WriteLine("Ma tran da nhap: ");
            for (int i = 0; i < Hang; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                    Console.Write("{0} \t", _maTranHaiChieu[i, j]);
                }
                Console.WriteLine();
            }
        }
        // cau b : Tìm kiếm một phần tử trong ma trận
        public void timKiemPhanTu(int x)
        {
            List <KeyValuePair<int,int>> findList = new List<KeyValuePair<int, int>> ();
            for (int i = 0; i < Hang; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                    if( x == _maTranHaiChieu[i, j])
                    {
                        findList.Add (new KeyValuePair<int, int>(i, j));
                    }
                }
            }
            if(findList.Count != 0)
            {
                Console.Write("So can tim o vi tri:");
                foreach(KeyValuePair<int, int> findPair in findList)
                    Console.Write(" [{0},{1}]", findPair.Key, findPair.Value);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Khong tim thay so can tim trong ma tran");
            }
        }
        // cau c: Xuất các phần tử là số nguyên tố
        public bool isPrime(int n)
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
        public void xuatSoNguyenTo()
        {
            Console.Write("Cac phan tu la so nguyen to la: ");
            for (int i = 0; i < Hang; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                    if (isPrime(_maTranHaiChieu[i, j]))
                        Console.Write("{0} ", _maTranHaiChieu[i, j]);
                }
            }
            Console.WriteLine();
        }
        // cau d: Cho biết dòng nào có nhiều số nguyên tố nhất
        public void timDongNhieuSoNguyenToNhat()
        {
            int maxRow = 0;
            int maxCount = 0;
            int count = 0;
            for (int i = 0; i < Hang; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                    if (isPrime(_maTranHaiChieu[i, j]))
                        count ++;
                }
                if(count > maxCount)
                {
                    maxCount = count;
                    maxRow = i;
                }
                count = 0;
            }
            Console.Write("Dong co nhieu so nguyen to nhat la: {0}", maxRow);
            Console.WriteLine();
        }
    }
}
