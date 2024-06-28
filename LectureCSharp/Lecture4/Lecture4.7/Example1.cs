using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._7
{
    // 4.7 Цикл foreach.
    class Example1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сформировать массив из N случайных чисел от -5 до 5");

            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();

            int[] numbs = new int[n];

            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = rand.Next(-5, 6);
            }
            foreach (var item in numbs)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
