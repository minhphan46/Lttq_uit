using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05.Models
{
    internal class Khoa
    {
        private string _maNganh;
        public string MaNganh
        {
            get { return _maNganh; }
            set { _maNganh = value; }
        }
        private string _tenNganh;
        public string TenNganh
        {
            get { return _tenNganh; }
            set { _tenNganh = value; }
        }
        public Khoa(string maNganh, string tenNganh)
        {
            MaNganh = maNganh;
            TenNganh = tenNganh;
        }
        public override string ToString()
        {
            return TenNganh;
        }
    }
}
