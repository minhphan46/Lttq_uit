using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    internal class NganhHoc
    {
        public string maNganh;
        public string tenNganh;
        public NganhHoc(string maNganh, string tenNganh)
        {
            this.maNganh = maNganh;
            this.tenNganh = tenNganh;
        }

        public override string ToString()
        {
            return this.tenNganh;
        }
    }
}
