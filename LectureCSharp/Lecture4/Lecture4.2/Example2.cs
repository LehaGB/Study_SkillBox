using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._2
{
    // 4.2 Основные методы работы с одномерными массивами
    class Example2
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Массив из N элементов состоит из нулей и едениц.\nПоставить нули в начало," +
                "а еденицы - в конец");

            Console.Write("Количество элементов: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbs = new int[n];

            Console.Write("Исходный массив: ");
            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = random.Next(0, 2);
                Console.Write($"{numbs[i]} ");
            }

            Array.Sort(numbs);

            Console.Write("\nПолучившиеся массив: ");
            for (int i = 0; i < numbs.Length; i++)
            {
                Console.Write($"{numbs[i]} ");
            }
            Console.ReadKey();
        }
    }
}
