using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class Example_005
    {
        //Ветвление(if-else)
        static void Main(string[] args)
        {
            //Заказчик просит написать программу которая, будет генерировать два случайных числа.
            //из диапозона от -10 до 10 после чего должно быть введено:
            //1.1 Максимальное из чисел.
            //1.2 Минимальное из чисел.
            //2. Добавить в прорамму возможность определения равенства чисел
            // и вывода соответствующего вывода на экран.
            //3. Добавить возможность вывода данных с клавиатуры.


            Random random = new Random();

            int firstNumber = random.Next(-10, 11);
            int secondNumber = random.Next(-10, 11);

            Console.WriteLine("Пункт 1 вариант 3");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Максимальное число = {firstNumber}");
                Console.WriteLine($"Минимальное число = {secondNumber}");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"Максимальное число = {secondNumber}");
                Console.WriteLine($"Минимальное число = {firstNumber}");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
            Console.ReadLine();
        }
    }
}
