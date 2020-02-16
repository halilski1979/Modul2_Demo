using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            double b = 5.00;
            double c = 5;
            decimal d = 5.00m;
            sbyte a1= 12;

            Console.WriteLine(a);
            Console.WriteLine($"{b}:f1");
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(a1);
        }
    }
}
