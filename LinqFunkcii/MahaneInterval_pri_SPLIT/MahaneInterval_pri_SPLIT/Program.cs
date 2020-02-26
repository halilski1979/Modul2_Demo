using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahaneInterval_pri_SPLIT
{
    class Program
    {
        static void Main(string[] args)
        {
            var linia = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(string.Join(",", linia));
        }
    }
}
