using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._1
{
    class Task1
    {
        //Одномерные массивы и инициализация.

        //Задача № 1
        static void Main(string[] args)
        {
            Console.WriteLine("Сформировать массив из N случаных чисел от -5 до 5");

            //Решение.

            Console.Write("Введите n: ");                // Приглашение ко вводу числа.
            int n = int.Parse(Console.ReadLine());       // Ввод числа с клавиатуры.

            Random random = new Random();                // Инициализация генерации псевдослучайных чисел

            int[] numbs = new int[n];                    // Объявление и инициализация массива.

            for (int i = 0; i < numbs.Length; i++)       //
            {                                            //
                numbs[i] = random.Next(-5, 6);           // Заполнение массива.
            }                                            //

            for (int i = 0; i < numbs.Length; i++)       //
            {                                            //
                Console.WriteLine($"{numbs[i]}");            // Вывод массива экран.
            }                                            //
            Console.ReadKey();
        }
    }
}
