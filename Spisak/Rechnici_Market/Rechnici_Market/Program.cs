using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnici_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, double> market = new Dictionary<double, double>();

            while (true)
            {
                var linia = Console.ReadLine().Split(' ');
                string produkt = linia[0];
                double price = double.Parse(linia[1]);
                double quantity = double.Parse(linia[2]);

                if (produkt=="stocked")
                {
                    break;
                }

                
            }

        }
    }
}
