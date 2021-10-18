using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8._2
{
    class Program
    {   //Сумма чисел в файле
        static void Main(string[] args)
        {
            string path = "Задание.txt";
            Random random = new Random();
            long sum = 0;
            
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next());
                }
                sw.Close();
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine("Сумма чисел в файле равна {0}",sum);
            Console.ReadKey();
        }
    }
}
