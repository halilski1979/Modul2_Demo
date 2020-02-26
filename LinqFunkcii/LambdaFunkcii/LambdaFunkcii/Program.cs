using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunkcii
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 7, 3, 4, 9, 6 };
            
            nums =  nums.Where(num => num % 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(string.Join(" \n",nums));


            int count = nums.Count(x=>x%2==0);
            Console.WriteLine(count);



            int[] number = { 11, 99, 33, 55, 77, 44, 66, 22, 88 };
             var numbers = number.OrderBy(x => x).Take(3);
            Console.WriteLine(string.Join(" ",numbers));

            var numbers1 = number.OrderByDescending(y => y).Take(4);
            Console.WriteLine(string.Join(" ", numbers1));

            List<int> list = new List<int>() { 11, 99, 33, 55, 77, 44, 66, 22, 88 };
            list = list.Where(x => x > 50).Select(x=>x+2).ToList();
            Console.WriteLine(string.Join(" ", list));

            list = list.Select(x => x * 2).ToList();
            Console.WriteLine(string.Join(" ", list));


            //Взема числата, които не се повтарят
            int[] dist = { 1, 2, 2, 3, 4, 5, 6, -2, 2, 0, 15, 3, 1, 0, 6 };
            var dist1 = dist.Distinct().ToList();
            Console.WriteLine(string.Join(" ", dist1));

            //Слепване на два масива
            int[] firstM = { 1, 2, 3, 4, 5, 6,222 };
            int[] otherNums = { 7, 8, 9, 0,1111 };
            var firstMM = firstM.Concat(otherNums);
            Console.WriteLine(string.Join(" ", firstMM));

            





        }
    }
}
