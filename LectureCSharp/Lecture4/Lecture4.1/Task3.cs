using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._1
{
    //Одномерные массивы и инициализация.
    class Task3
    {
        //Задача № 3
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("В массиве из 10 чисел вычислить, сколько раз встречается введенное число");

            int[] numbs = new int[10];
            Console.Write("\nСгенерированный массив: ");
            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = random.Next(10);
                Console.Write($"{numbs[i]} ");
            }
            Console.WriteLine();
            Console.Write("\nКакое число ищем: ");
            int n = int.Parse(Console.ReadLine());

            int find = 0;

            for (int i = 0; i < numbs.Length; i++)
            {
                if (numbs[i] == n)
                {
                    find++;
                }
            }
            Console.WriteLine($"\nЭлемент '{n}' найден: {find} раз. ");
            Console.ReadKey();
        }
    }
}
