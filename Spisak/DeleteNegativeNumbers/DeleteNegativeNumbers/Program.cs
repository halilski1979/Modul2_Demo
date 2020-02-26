using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            List<int> num = new List<int> {-2,-3,4,1,0,4,-11 };
            //Сортиране на списък
            num=num.OrderBy(x=>x).ToList();
            Console.WriteLine(string.Join(" ", num));

            //Сортиране в низходящ ред
            num = num.OrderByDescending(y=>y).ToList();
            Console.WriteLine(string.Join(" ", num));


            //Изтриване на отрицателни числа
            num.RemoveAll(x=>x<0);
            Console.WriteLine(string.Join(" ",num));

           
            //Печат на четни числа
            Console.WriteLine(string.Join(" ",num.Where(x=>x%2==0)));


            //Сбор на четни числа
            foreach (var item in num)
            {
                if (item%2==0)
                {
                     s+= item;
                }
            }
            




            //Сортиране на речник
            Dictionary<int, string> person = new Dictionary<int, string>
            {
                { 2,"Halil" },
                { 0,"Asen"},
                { 5,"Petar" },
                {2,"Ivan" },
                { 3,"Halil"}
            } ;


            Dictionary<int, string> sortedDict = person.OrderBy(p => p.Value).ThenBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value);
            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
