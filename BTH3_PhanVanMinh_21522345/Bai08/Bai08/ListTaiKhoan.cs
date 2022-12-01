using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    internal class ListTaiKhoan
    {
        public List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();
        public ListTaiKhoan()
        {

        }
        public int getSTT(int soTaiKhoan)
        {
            for(int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (listTaiKhoan[i].SoTaiKhoan == soTaiKhoan)
                {
                    return i;
                }
            }
            return 0;
        }
        public bool isExit(int soTaiKhoan)
        {
            foreach (TaiKhoan item in listTaiKhoan)
            {
                if (item.SoTaiKhoan == soTaiKhoan)
                {

                    return true;
                }
            }
            return false;
        }
        public void addTaiKhoan(int soTaiKhoan, string ten, string diaChi, decimal soTien)
        {
            TaiKhoan tk = new TaiKhoan(soTaiKhoan,ten,diaChi,soTien);
            listTaiKhoan.Add(tk);
        }
        public void updateTaiKhoan(int soTaiKhoan, string ten, string diaChi, decimal soTien)
        {
            int i = getSTT(soTaiKhoan);
            listTaiKhoan[i] = new TaiKhoan(soTaiKhoan, ten, diaChi, soTien);
        }
        public bool removeTaiKhoan(int soTaiKhoan)
        {
            foreach (TaiKhoan item in listTaiKhoan)
            {
                if (item.SoTaiKhoan == soTaiKhoan)
                {
                    listTaiKhoan.Remove(item);
                    return true;
                }
            }
            return false;
        }
    }
}
