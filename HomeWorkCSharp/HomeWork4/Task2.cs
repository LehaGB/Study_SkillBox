using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewWork4
{
    class Task2
    {
        //Задание 2. Сложение матриц
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк 1-ой матрицы: ");
            int row1 = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов 1-ой матрицы: ");
            int col1 = int.Parse(Console.ReadLine());

            int[,] numbs1 = new int[row1, col1];

            Random rand = new Random();

            Console.WriteLine("\nСлучайная матрица: ");
            for (int i = 0; i < numbs1.GetLength(0); i++)
            {
                for (int j = 0; j < numbs1.GetLength(1); j++)
                {
                    numbs1[i, j] = rand.Next(10);
                    Console.Write($"{numbs1[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Введите количество строк 2-ой матрицы: ");
            int row2 = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов 2-ой матрицы: ");
            int col2 = int.Parse(Console.ReadLine());

            int[,] numbs2 = new int[row2, col2];

            Console.WriteLine("\nСлучайная матрица: ");
            for (int i = 0; i < numbs2.GetLength(0); i++)
            {
                for (int j = 0; j < numbs2.GetLength(1); j++)
                {
                    numbs2[i, j] = rand.Next(-10, 10);
                    Console.Write($"{numbs2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Введите количество строк 3-ой матрицы: ");
            int row3 = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов 3-ой матрицы: ");
            int col3 = int.Parse(Console.ReadLine());

            int[,] numbs3 = new int[row3, col3];

            Console.WriteLine("\nИсходная матрица: ");
            for (int i = 0; i < numbs3.GetLength(0); i++)
            {
                for (int j = 0; j < numbs3.GetLength(1); j++)
                {
                    numbs3[i, j] = numbs1[i, j] + numbs2[i, j];
                    Console.Write($"{numbs3[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
