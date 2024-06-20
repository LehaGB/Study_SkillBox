using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._4
{
    //Для каждой строки матрицы A[4x4] найти сумму элементов.
    class Example4
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[,] a = new int[4, 4];

            Console.WriteLine("Исходная матрица A[4x4]: ");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.Next(1, 5);
                    sum += a[i, j];
                    Console.Write($"{a[i, j], 2}");
                }
                Console.WriteLine($" : {sum}");
            }
            Console.ReadKey();
        }
    }
}
