using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._4
{

    // 4.4 Двумерные массивы: использование, задание.

    class Example2
    {
        //Элементы одномерного массива А из 9 чисел построчно расположить в матрице В[3x3]
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[,] b = new int[3, 3];

            int counterA = 0;

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = a[counterA++];
                    Console.Write($"{b[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
