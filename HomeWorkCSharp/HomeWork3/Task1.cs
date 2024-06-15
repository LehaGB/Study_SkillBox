using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Task1
    {
        //Задание 1. Приложение по определению чётного или нечётного числа.
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");

            int number = int.Parse(Console.ReadLine());

            if(number == 0)
            {
                Console.WriteLine("Вы ввели ноль");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Нечетное");
            }
            Console.ReadLine();
        }
    }
}
