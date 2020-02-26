using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = (Console.ReadLine());
            int number;
            bool sussecs = Int32.TryParse(x, out number);
            if (sussecs)
            {
                var result = int.Parse(x);
                if (result>0)
                {
                    Console.WriteLine("x>0");
                }
                if (result<0)
                {
                    Console.WriteLine("x<0");
                }
                if (result==0)
                {
                    Console.WriteLine("x=0");
                }
            }
            
        }
    }
}
