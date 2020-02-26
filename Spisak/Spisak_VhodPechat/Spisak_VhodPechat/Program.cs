using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisak_VhodPechat
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ",num));

            //Сума на списък
            int sum = num.Sum();
            Console.WriteLine($"sum={sum}");

            //Минимален елемент
            int min = num.Min();
            Console.WriteLine($"min={min}");
            //Максимален елмент
            int max = num.Max();
            Console.WriteLine($"max={max}");

            //средно аритметично
            double avg = num.Average();
            Console.WriteLine($"avg={avg}");

            //Сортиране на списък
            Console.WriteLine("Сортиране на списък ");
            num.Sort();
            Console.WriteLine(string.Join(" ",num));

            //Обръщане на елементи на списък
            Console.WriteLine("Обръщане на елементи на списък");
            num.Reverse();
            Console.WriteLine(string.Join(" ", num));

            //Брой на елементи на списък
            Console.WriteLine("Брой на елементи на списък");
            int brElSpisak = num.Count;
            Console.WriteLine(brElSpisak);

            //Добавяне на елемент в края на списъка
            Console.WriteLine("Добавяне на елемент в края на списъка");
            num.Add(111);
            Console.WriteLine(string.Join(" ", num));

            //Изтриване на конкретна стойност от списък
            num.Remove(6);
            Console.WriteLine(string.Join(" ", num));

            //Изтриване на  стойност от списък по индекс
            num.RemoveAt(0);
            Console.WriteLine(string.Join(" ", num));

            //Вмъкване на елемент на конкретна позциция
            num.Insert(1,222);
            Console.WriteLine(string.Join(" ", num));

        }
    }
}
