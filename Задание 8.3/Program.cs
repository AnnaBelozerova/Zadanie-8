using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8._3
{   //Количество символов, строк, слов
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Задание.txt";

            int countChar = File.ReadAllText(path).Length;
            Console.WriteLine("Количество символов в файле: {0}", countChar);

            string[] line = File.ReadAllLines(path);
            Console.WriteLine("Количество строк в файле: {0}", line.Length);

            int countWord = 0;
            for (int i = 0; i < line.Length; i++)
            {
                countWord += line[i].Split(' ').Length;
            }
            
            Console.WriteLine("Количество слов в файле: {0}", countWord);
            Console.ReadKey();
            
        }
    }
}
