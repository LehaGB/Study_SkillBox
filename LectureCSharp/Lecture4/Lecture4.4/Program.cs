using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._4
{
    //4.4 Двумерные массивы: использование, задание
    class Program
    {
        static void Main(string[] args)
        {
            //задание двумерного массива, в котором 3 сторки и 4 столбца.
            int[,] matrix = new int[3, 4];

            matrix[1, 2] = 3;

            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rand.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
