using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._1
{
    //Одномерные массивы и инициализация.
    class Task4
    {
        //Задача № 4
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

            int head = 0;                      // Указатель головного элеметна.
            int tail = numbs.Length - 1;      // Указатель хвостового элемента.

            bool flag = true;                 // Флаг, показывающий увеличивать позицию головного - flag = true.
                                              // или уменьшать позицию хвостового flag = false.

            while (head < tail)                // Пока "голова" меньше "хвоста"  
            {
                if (flag)                     // flag = true.
                {
                    if (numbs[head] == 1)     // Работа с головным элементом.
                    {
                        flag = false;
                    }
                    else
                    {
                        head++;
                    }
                }
                else
                {
                    if (numbs[tail] == 0)     // Работа с хвостовым элементом.
                    {
                        flag = true;
                    }
                    else
                    {
                        tail--;
                    }
                }
                if (numbs[head] == 1 && numbs[tail] == 0)
                {
                    int temp = numbs[head];
                    numbs[head] = numbs[tail];
                    numbs[tail] = temp;

                    head++;                                 // Сдвигаем голову.
                    tail--;                                 // Сдвигаем хвост.
                }
            }
            Console.Write("\nПолучившиеся массив: ");
            for (int i = 0; i < numbs.Length; i++)
            {
                Console.Write($"{numbs[i]} ");
            }
            Console.ReadKey();
        }
    }
}
