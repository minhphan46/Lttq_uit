using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loadingButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FontFamily.Families.Length; i++)
            {
                fontTextBox.SelectionFont = new Font(FontFamily.Families[i].Name, 12, FontStyle.Regular);
                fontTextBox.SelectedText = "  " + FontFamily.Families[i].Name + "\r\n";
            }
        }
    }
}
