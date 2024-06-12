using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class ExampleFor
    {
        static void Main(string[] args)
        {
            //Заказчик просит вас написать программу, в которой
            //пользователь может ввести два целых числа start и end
            //Программма должна вывести таблицу квадратов чисел от start до end

            Console.Write("Введите start: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Введите end: ");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i,4}^2 = {i * i}");
            }
            Console.ReadLine();
        }
    }
}
