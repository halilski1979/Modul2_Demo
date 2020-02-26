using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogomerenMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деклариране на двумерен масив

            int[,] A = new int[2,3];

            int[,] B = { {1,2,3 }, {4,5,6 }, };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"A[{i},{j}]=");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Печат на масив
            for (int i = 0; i < 2; i++)
            {
                double sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(A[i,j] + " ");
                    sum += A[i, j];
                }
                double avg = sum / 3;

                Console.WriteLine($"ave={avg}");
            }

            int brRed = A.GetLength(0);
            Console.WriteLine($"brRed={brRed}");

            int brKol = A.GetLength(1);
            Console.WriteLine($"brRed={brKol}");
        }
    }
}
