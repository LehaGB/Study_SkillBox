using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Task5
    {
        //Задание 5. Игра «Угадай число».
        static void Main(string[] args)
        {
            Random rand = new Random();

            int count = 1;
            int number = 0;
            string exit = "";

            Console.Write("Введите диапазон числа: ");
            int hiddenNumber = int.Parse(Console.ReadLine());

            int randomNumber = rand.Next(0, hiddenNumber);

            Console.WriteLine("\nПоробуйте угадать число!!!\n");
            
            while (true)
            {
                Console.Write("Введите число: ");
                exit = Console.ReadLine();
                bool result = int.TryParse(exit, out number);
                if (exit == "")
                {
                    Console.WriteLine($"\nЗагаданное число было: {randomNumber} ");
                    Console.WriteLine("\nНажмите Enter для выхода....");
                    break;
                }
                if (number > randomNumber)
                {
                    Console.WriteLine("\nВаше число, больше загаданного");
                }
                else if(number < randomNumber)
                {
                    Console.WriteLine("\nВаше число, меньше загаданного");
                }
                else
                {
                    Console.WriteLine($"\nПоздравляю, вы угадали, вам потребовалось попыток {count}");
                    Console.WriteLine("Нажмите Enter для выхода из игры....");
                    break;
                }
                count++;
            }
            Console.ReadKey();
        }
    }
}
