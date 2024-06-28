using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._6
{
    // 4.6 Массив массивов.
    class Example2
    {
        // Написать программу, моделирующую получение показаний метеостанции.
        // Собирать и хранить информацию о температуре воздуха.
        // В период с 9 ч утра до 21 ч вечера каждые 5 минут.
        // В период с 21 ч вечера до 9 ч утра каждые 15 минут.
        // Используем зубчатые массивы.
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[][] dataTime = new int[24][];

            for (int j = 0; j < dataTime.Length; j++)
            {
                dataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            }

            for (int i = 0; i < dataTime.Length; i++)
            {
                Console.Write($"{i} ч. ");
                for (int k = 0; k < dataTime[i].Length; k++)
                {
                    dataTime[i][k] = rand.Next(20);
                    Console.Write($"{dataTime[i][k], 3} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
