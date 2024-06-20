using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._1
{
    //Одномерные массивы и инициализация.
    class Task2
    {
        //Задача № 2
        static void Main(string[] args)
        {
            Console.WriteLine("Сформировать массив N случайных чсисел.Подсчитать количество четных чисел");

            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[] numbs = new int[n];

            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = random.Next(10);
            }

            int evenElement = 0;

            for (int i = 0; i < numbs.Length; i++)
            {
                if (numbs[i] % 2 == 0)
                {
                    evenElement++;
                }
            }
            for (int i = 0; i < numbs.Length; i++)
            {
                Console.Write($"{numbs[i]} ");
            }
            Console.Write($"\nчетных чисел = {evenElement}");
            Console.ReadKey();
        }
    }
}
