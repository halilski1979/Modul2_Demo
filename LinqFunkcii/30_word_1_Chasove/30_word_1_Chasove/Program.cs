using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_word_1_Chasove
{
    class Program
    {
        static void Main(string[] args)
        {
            var interval = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(", ",interval));
        }
    }
}
