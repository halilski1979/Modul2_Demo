using System.Linq;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var interval = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.WriteLine(string.Join(", ", interval));
        }
    }
}
