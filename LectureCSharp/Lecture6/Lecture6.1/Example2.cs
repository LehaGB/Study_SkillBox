using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6._1
{
    // DataTime, TimeSpan

    class Example2
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2024, 06, 28, 20, 11, 00);
            Console.WriteLine($"{date}");


            Console.WriteLine(date.ToShortTimeString());   // Получение только времени
            Console.WriteLine(date.ToShortDateString());   // Получение только даты


            DateTime newDate = date.AddDays(10);
            Console.WriteLine($"{newDate}");


            TimeSpan span = newDate - date;
            Console.WriteLine($"{span}");
            Console.WriteLine($"{span.TotalMinutes}");
            Console.WriteLine($"{span.TotalDays}");

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("===========================================");

            // Запоминаем текущее время
            date = DateTime.Now;

            double sum = 0;

            for (int i = 0; i <= 1_000_000; i++)
            {
                sum += i;
            }
            Console.WriteLine($"sum = {sum}");


            // Вычитаем из текущего времени, запомнившее время 
            // и выводим результат работы прораммы в милисекундах
            TimeSpan timeSpan = DateTime.Now.Subtract(date);
            Console.WriteLine($"timeSpan.TotalMilliseconds = {timeSpan.TotalMilliseconds}");
            Console.ReadKey();
        }
    }
}
