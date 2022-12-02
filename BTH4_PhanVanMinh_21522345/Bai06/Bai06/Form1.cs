using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string pathNguon = "C:\\Users\\Administrator\\Desktop\\nguon";
        public string pathDich = "C:\\Users\\Administrator\\Desktop\\dich";
        public string fileName = "sourceFile.txt";
        public int luachon = 0;
        private void btnNguon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chọn copy folder không?", "Lựa chọn", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        luachon = 0;
                        FolderBrowserDialog fbd = new FolderBrowserDialog();
                        fbd.SelectedPath = pathNguon;
                        fbd.Description = "Choose source folder path";

                        if (fbd.ShowDialog() == DialogResult.OK)
                        {
                            if (fbd.SelectedPath == pathDich)
                            {
                                MessageBox.Show("Đường dẫn nguồn giống đường dẫn đich");
                                return;
                            }
                            pathNguon = fbd.SelectedPath;
                            tbNguon.Text = pathNguon;
                        }
                    }
                    break;
                case DialogResult.No:
                    {
                        luachon = 1;
                        OpenFileDialog ofd = new OpenFileDialog();
                        ofd.Title = "Open";
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            fileName = ofd.FileName;
                            //filenames = ofd.SafeFileName;
                            tbNguon.Text = fileName;
                        }
                    }
                    break;
                default:
                    break;
            }        
        }

        private void btnDich_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = pathDich;
            fbd.Description = "Choose destination folder path";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (fbd.SelectedPath == pathNguon)
                {
                    MessageBox.Show("Đường dẫn nguồn giống đường dẫn đich");
                    return;
                }
                pathDich = fbd.SelectedPath;
                tbDich.Text = pathDich;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if( luachon == 0)
            {
                DirectoryInfo dNguon = new DirectoryInfo(pathNguon);
                pbCopy.Minimum = 0;
                pbCopy.Maximum = DirLength(new DirectoryInfo(pathNguon));
                pbCopy.Value = 0;
                pbCopy.Value = 0;
                pbCopy.Step = 1;
                CopyFolder(pathNguon, pathDich);
            }
            else
            {            
                pbCopy.Minimum = 0;
                pbCopy.Maximum = 1;
                pbCopy.Step = 1;
                pbCopy.Value = 0;
                var name = Path.GetFileName(fileName);
                var destination = Path.Combine(pathDich, name);
                File.Copy(fileName, destination, true);
                pbCopy.PerformStep();
            }
            if(pbCopy.Value == pbCopy.Maximum)
            {
                //MessageBox.Show("Copy thành công");
            }
        }
        public static int DirLength(DirectoryInfo d)
        {
            int l = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                l++;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                l += DirLength(di);
            }
            return l;
        }
        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }
        public void CopyFolder(string sourceFolder, string destFolder)
        {
            try
            {
                if (!Directory.Exists(destFolder))
                    Directory.CreateDirectory(destFolder);
                string[] files = Directory.GetFiles(sourceFolder);
                foreach (string file in files)
                {
                    string name = Path.GetFileName(file);
                    string dest = Path.Combine(destFolder, name);
                    File.Copy(file, dest, true);
                    pbCopy.PerformStep();
                }
                string[] folders = Directory.GetDirectories(sourceFolder);
                foreach (string folder in folders)
                {
                    string name = Path.GetFileName(folder);
                    string dest = Path.Combine(destFolder, name);
                    CopyFolder(folder, dest);
                    pbCopy.PerformStep();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
}
