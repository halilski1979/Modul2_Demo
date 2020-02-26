using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortiraneChasove
{
    class Program
    {
        static void Main(string[] args)
        {
            var chasove = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine(string.Join(" ",chasove));

            var result = chasove.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
