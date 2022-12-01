using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    internal class SinhVien
    {
        public long maSoSinhVien;
        public string hoTen;
        public char gioiTinh;
        public NganhHoc nganhHoc;
        public List<MonHoc> listMonHoc = new List<MonHoc>();

        public SinhVien(long maSoSinhVien, string hoTen, char gioiTinh, NganhHoc nganhHoc, List<MonHoc> listMonHoc = null)
        {
            this.maSoSinhVien = maSoSinhVien;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.nganhHoc = nganhHoc;
            if(listMonHoc != null && listMonHoc.Count > 0)
                this.listMonHoc = listMonHoc;
        }
    }
}
