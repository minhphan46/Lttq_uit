using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class QuanLyNhaDat
    {
        public List<KhuDat> listKhuDat = new List<KhuDat>();
        public int numOfList = 0;

        public long sumOfKhuDat = 0;
        public long sumOfNhaPho = 0;
        public long sumOfChungCu = 0;

        // cau 2: Nhập xuất danh sách các thông tin (Khu đất, Nhà phố, Chung Cư) cần quản lý.
        public void NhapDanhSachNhaDat()
        {
            Console.Write("Nhap so thong tin can quan ly: ");
            numOfList = int.Parse(Console.ReadLine());
            for(int i = 0; i < numOfList; i++)
            {
                Console.WriteLine("Chon loai can nhap: ");
                Console.WriteLine("1: Khu dat");
                Console.WriteLine("2: Nha pho");
                Console.WriteLine("3: Chung cu");
                int option = int.Parse(Console.ReadLine());

                if(option == 1)
                {
                    KhuDat khuDat = new KhuDat();
                    khuDat.Loai = Loai.KhuDat;
                    khuDat.Nhap();
                    listKhuDat.Add(khuDat);
                }
                else if (option == 2)
                {
                    NhaPho nhaPho = new NhaPho();
                    nhaPho.Loai = Loai.NhaPho;
                    nhaPho.Nhap();
                    listKhuDat.Add(nhaPho);
                }
                else if (option == 3)
                {
                    ChungCu chungCu = new ChungCu();
                    chungCu.Loai = Loai.ChungCu;
                    chungCu.Nhap();
                    listKhuDat.Add(chungCu);
                }
                else
                {
                    Console.WriteLine("Nhap sai loai, nhap lai");
                    i--;
                }
            }
        }
        public void XuatDanhSachNhaDat()
        {
            Console.WriteLine("\nDanh sach da nhap la: ");
            for (int i = 0; i < numOfList; i++)
            {
                if (listKhuDat[i].Loai == Loai.KhuDat)
                {
                    Console.WriteLine("Thong tin Khu Dat la: ");
                    listKhuDat[i].Xuat();
                    Console.WriteLine();
                }
                else if (listKhuDat[i].Loai == Loai.NhaPho)
                {
                    Console.WriteLine("Thong tin Nha Pho la: ");
                    ((NhaPho)listKhuDat[i]).Xuat();
                    Console.WriteLine();
                }
                else if (listKhuDat[i].Loai == Loai.ChungCu)
                {
                    Console.WriteLine("Thong tin Chung Cu la: ");
                    ((ChungCu)listKhuDat[i]).Xuat();
                    Console.WriteLine();
                }
            }
        }

        // cau 3: Xuất tổng giá bán cho 3 loại (Khu đất, Nhà phố, Chung Cư) của công ty Đại Phú.

        public void TingTongGiaBan()
        {
            for (int i = 0; i < numOfList; i++)
            {
                if (listKhuDat[i].Loai == Loai.KhuDat)
                {
                    sumOfKhuDat += listKhuDat[i].GiaBan;
                }
                else if (listKhuDat[i].Loai == Loai.NhaPho)
                {
                    sumOfNhaPho += listKhuDat[i].GiaBan;
                }
                else if (listKhuDat[i].Loai == Loai.ChungCu)
                {
                    sumOfChungCu += listKhuDat[i].GiaBan;
                }
            }
            Console.WriteLine("Tong gia ban cua Khu Dat la : {0}", sumOfKhuDat);
            Console.WriteLine("Tong gia ban cua Nha Pho la : {0}", sumOfNhaPho);
            Console.WriteLine("Tong gia ban cua Chung Cu la : {0}", sumOfChungCu);
        }

        // cau 4: Xuất danh sách các khu đất có diện tích > 100m2 hoặc là nhà phố mà có diện tích >60m2 và năm xây dựng >= 2019 (nếu có).
        public void FiterListNhaDat()
        {
            Console.WriteLine("\nDanh sach khu dat hoac nha pho thoa yeu cau la: ");
            for (int i = 0; i < numOfList; i++)
            {
                if (listKhuDat[i].Loai == Loai.KhuDat && listKhuDat[i].DienTich > 100)
                {
                    Console.WriteLine("Thong tin Khu Dat la: ");
                    listKhuDat[i].Xuat();
                    Console.WriteLine();
                }
                else if (listKhuDat[i].Loai == Loai.NhaPho && listKhuDat[i].DienTich > 60 && ((NhaPho)listKhuDat[i]).NamXayDung >= 2019  )
                {
                    Console.WriteLine("Thong tin Nha Pho la: ");
                    ((NhaPho)listKhuDat[i]).Xuat();
                    Console.WriteLine();
                }
            }
        }

        // cau 5: Nhập vào các thông tin cần tìm kiếm (địa điểm, giá, diện tích). Xuất thông tin danh sách tất cả các nhà phố hoặc chung cư phù hợp yêu cầu.
        public void searchNhaDat()
        {
            Console.WriteLine("\nNhap Thong tin can tim kiem: ");
            Console.Write("Dia diem: ");
            string diaDiem = Console.ReadLine();
            Console.Write("Gia: ");
            long gia = long.Parse(Console.ReadLine());
            Console.Write("Dien tich: ");
            double dienTich = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDanh sach Chung cu hoac nha pho thoa yeu cau la: ");
            for (int i = 0; i < numOfList; i++)
            {
                if (listKhuDat[i].Loai == Loai.NhaPho)
                {
                    if(    listKhuDat[i].DiaDiem.ToLower() == diaDiem.ToLower() 
                        && listKhuDat[i].GiaBan <= gia
                        && listKhuDat[i].DienTich >= dienTich)
                    {
                        Console.WriteLine("Thong tin Nha pho la: ");
                        ((NhaPho)listKhuDat[i]).Xuat();
                        Console.WriteLine();
                    }
                }
                else if (listKhuDat[i].Loai == Loai.ChungCu)
                {
                    if (listKhuDat[i].DiaDiem.ToLower() == diaDiem.ToLower()
                        && listKhuDat[i].GiaBan <= gia
                        && listKhuDat[i].DienTich >= dienTich)
                    {
                        Console.WriteLine("Thong tin Chung cu la: ");
                        ((ChungCu)listKhuDat[i]).Xuat();
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
