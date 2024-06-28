using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6._1
{
    // 6.1 Встроенные методы. Класс Math и Convert, DateTime
    class Example1
    {
        // Класс Math
        static void Main(string[] args)
        {
            // Возвращает наименьшее целое число, котрое больше и равно заданному десятичному.
            Console.WriteLine(Math.Ceiling(1.2));  // 2
            Console.WriteLine(Math.Ceiling(-1.2));  // -1


            // Возвращает значение е, возведенное в указаную степень.
            Console.WriteLine(Math.Exp(2));  //e * e


            // Возвращает наибольшее целое число, котрое больше и равно заданному десятичному числу.
            Console.WriteLine(Math.Floor(1.2));  // 1
            Console.WriteLine(Math.Floor(-1.2));  // -2


            // Возвращает указанное число, возведенное в укзанную степень.
            Console.WriteLine(Math.Pow(4, 3));  // 4 * 4 * 
            Console.WriteLine(Math.Pow(2022, 2));  // 2022 * 2022


            // Округляет десятичное значение до указанного числа дробного разряда.
            Console.WriteLine(Math.Round(1.2345));    // 1
            Console.WriteLine(Math.Round(1.5345));    // 2
            Console.WriteLine(Math.Round(-1.5345));   // -2
            Console.WriteLine(Math.Round(-1.56789, 3));  // -1.568


            // Возвращает целое число, указывающее знак 8-разрядного целого числа со знаком.
            Console.WriteLine(Math.Sign(20));  // 1
            Console.WriteLine(Math.Sign(-20));  // -1

            int r = 2;
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"double s = {Math.Round(s, 3)}");
            Console.ReadKey();
        }
    }
}
