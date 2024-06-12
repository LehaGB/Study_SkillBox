using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class ExampleFraction
    {
        static void Main(string[] args)
        {
            //Пользователь вводит два целых числа numerator и denominator,
            //которые являются числителем и знаменателем соответственно.
            //Нужно выяснить, можно ли сократить эту дробь,
            //и если можно , то на какое число.

            Console.Write("Введите numerator: ");
            double numerator = double.Parse(Console.ReadLine());

            Console.Write("Введите denominator: ");
            double denominator = double.Parse(Console.ReadLine());

            Console.WriteLine($"Исходная дробь {numerator} / {denominator}");

            double a = numerator, b = denominator;
            int count = 0;

            for (int i = 0; i < 100000; i++)
            {
                if (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                    Console.WriteLine($"{a} {b}");
                    count++;
                    break;
                }
                Console.WriteLine($" i = {i}");
            }

            Console.WriteLine($"count = {count}");

            Console.WriteLine($"Можно сократить на {a}");

            Console.WriteLine($"Сокращенная дрообь {numerator / a} / {denominator / a}");
            Console.ReadLine();
        }
    }
}
