using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Задание_8
{   //Показать папки в папке
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\1";
            string[] allFiles = Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories);            
            
            foreach (string d in allFiles)
            {
                Console.WriteLine(Path.GetFileName(d));
            }
            Console.ReadKey();            
        }
    }
}
