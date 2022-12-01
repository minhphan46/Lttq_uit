using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    internal class MonHoc
    {
        public string maMon;
        public string tenMon;

        public MonHoc(string maMon, string tenMon)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
        }

        public override string ToString()
        {
            return tenMon;
        }
    }
}
