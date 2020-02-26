using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortReverseMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {3,4,1,22,11,-4,3,-11,-5,0,6 };

            int sum = a.Sum();
            Console.WriteLine(sum);

            //Сортиране на масив
            Array.Sort(a);

            Console.WriteLine(string.Join(" ",a));

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            //Обръщане на масив
            Array.Reverse(a);
            Console.WriteLine(string.Join("|",a));
        }
    }
}
