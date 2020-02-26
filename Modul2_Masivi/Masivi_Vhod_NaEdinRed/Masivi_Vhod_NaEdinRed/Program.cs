using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masivi_Vhod_NaEdinRed
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] num = Console.ReadLine().Split(' ').ToArray();

            

            Console.WriteLine("====FOR=====");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}]={num[i]}");
            }


            Console.WriteLine("====FOREACH=====");
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("====string.Join=====");
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
