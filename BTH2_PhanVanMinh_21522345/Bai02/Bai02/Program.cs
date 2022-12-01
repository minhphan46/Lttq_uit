using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhap duong dan thu muc");
            string folderRootPath = Console.ReadLine();
            if (Directory.Exists(folderRootPath))
            {
                string[] filePaths = Directory.GetFiles(folderRootPath);
                string[] folderPaths = Directory.GetDirectories(folderRootPath);

                long totalFileLenght = 0;
                long totalDirLenght = 0;

                Console.WriteLine("\n Directory of " + folderRootPath);
                Console.WriteLine();
                if (folderPaths.Length != 0)
                {
                    for (int i = 0; i < folderPaths.Length; i++)
                    {
                        DirectoryInfo folder = new DirectoryInfo(folderPaths[i]);
                        Console.Write(folder.CreationTime + "\t  ");
                        Console.Write("<DIR> \t");
                        Console.WriteLine(folder.Name);
                        totalDirLenght += DirSize(folder);
                    }
                }
                if (filePaths.Length != 0)
                {
                    for (int i = 0; i < filePaths.Length; i++)
                    {
                        FileInfo file = new FileInfo(filePaths[i]);
                        Console.Write(file.CreationTime + "\t  ");
                        if(file.Length < 10000) Console.Write("{0:n0}\t\t", file.Length);
                        else Console.Write("{0:n0}\t", file.Length);
                        Console.WriteLine(file.Name);
                        totalFileLenght += file.Length;
                    }
                }
                Console.Write("\t\t{0} File(s)\t" , filePaths.Length);
                Console.WriteLine("{0:n0} bytes\t", totalFileLenght);
                Console.Write("\t\t{0} Dir(s)\t" , folderPaths.Length);
                Console.WriteLine("{0:n0} bytes\t", totalDirLenght);
            }
            else
            {
                Console.Write("Khong tim thay thu muc");
            }
            Console.ReadLine();
        }
        // get size of directory
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
    }
}
