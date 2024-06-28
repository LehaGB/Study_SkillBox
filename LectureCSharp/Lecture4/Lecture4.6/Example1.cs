using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._6
{
    // 4.6 Массив массивов.
    class Example1
    {
        static void Main(string[] args)
        {
            // Написать программу, моделирующую получение показаний метеостанции.
            // Собирать и хранить информацию о температуре воздуха.
            // В период с 9 ч утра до 21 ч вечера каждые 5 минут.
            // В период с 21 ч вечера до 9 ч утра каждые 15 минут.

            Random rand = new Random();

            int[,] dataTime = new int[24, 12];

            for (int i = 0; i < dataTime.GetLength(0); i++)
            {
                Console.Write($"{i,3}ч. ");
                for (int j = 0; j < dataTime.GetLength(1); j++)
                {
                    if(i >= 9 && i < 21)
                    {
                        dataTime[i, j] = rand.Next(20);
                    }
                    else
                    {
                        dataTime[i, j] = (j < 4) ? rand.Next(20) : 0;

                    }
                    Console.Write($"{dataTime[i, j],3} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
