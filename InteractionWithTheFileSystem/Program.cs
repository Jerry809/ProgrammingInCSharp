using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionWithTheFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dir = Directory.GetCurrentDirectory();
            
            //string file = Path.Combine(dir, "Sample.txt");
            //string content = "hello world";

            //// 寫入
            //File.WriteAllText(file, content);

            //// 讀取
            //string read = File.ReadAllText(file);

            //// output : hello world
            //Console.WriteLine(read);
             
            // 我的文件路徑
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // 取得我的文件底下的檔案(不包括子目錄)
            foreach (string item in Directory.GetFiles(path))
            {
                // item = 檔案路徑
                Console.WriteLine(Path.GetFileName(item));
            }

            // 會將path1檔案重新命名後搬移到path2
            var path1 = @"D:\Folder\A1\temp.txt";
            var path2 = @"D:\Folder\B2\temp.txt";
            //File.Move(path1, path2);

            var info = new FileInfo(path1);
            
            // 取得檔案大小
            Console.WriteLine("{0}kb", info.Length / 1024);
            // 取得資料夾路徑(不包含檔案)
            Console.WriteLine(info.DirectoryName);
            // 取得檔案名稱
            Console.WriteLine(info.Name);
            // 取得資料夾路徑含檔案名稱
            Console.WriteLine(info.FullName);
            // 複製檔案至指定路徑
            info.CopyTo(@"D:\Folder\B2\temphi.txt");


        }
    }
}
