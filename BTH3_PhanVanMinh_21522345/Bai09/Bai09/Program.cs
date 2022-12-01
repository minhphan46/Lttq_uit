using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GetData.Instance.GetNganhHocs();
            GetData.Instance.GetMonHocs();
            GetData.Instance.GetSinhViens();
            Application.Run(new Form1());
        }
    }
}
