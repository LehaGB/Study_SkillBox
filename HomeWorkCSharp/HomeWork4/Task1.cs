using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewWork4
{
    class Task1
    {
        //Задание 1. Случайная матрица
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] numbs = new int[row, col];

            Random rand = new Random();
            int sum = 0;
            Console.WriteLine("Случайная матрица ");
            for (int i = 0; i < numbs.GetLength(0); i++)
            {
                for (int j = 0; j < numbs.GetLength(1); j++)
                {
                    numbs[i, j] = rand.Next(-10, 10);
                    Console.Write($"{numbs[i, j]} ");
                    sum += numbs[i, j];
                }
                Console.WriteLine();
            }
            Console.Write($"Общая сумма элементов матрицы = {sum} ");
            Console.ReadKey();
        }
    }
}
