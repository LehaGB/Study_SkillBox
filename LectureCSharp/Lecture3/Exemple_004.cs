using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class Exemple_004
    {
        //Вывод на экран
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomIntResult = rnd.Next();  //Возвращает неотрицательное случайное число.
            Console.WriteLine($"Пример 1 randomIntResult = {randomIntResult}");

            randomIntResult = rnd.Next(100); //Возвращает неотрицательное случайное число.
                                             // on 0 до 100 не включительно.
            Console.WriteLine($"Пример 2 randomIntResult = {randomIntResult}");

            double randomDoubleResult = rnd.NextDouble() + rnd.Next(100);  //Возвращает случайное число с
                                                                           //плавающей запятой
                                                                           //которое больше или равно 0.0
                                                                           // и меньше 1.0

            Console.WriteLine($"Пример 3 randomIntResult = {randomDoubleResult}");

            Console.ReadLine();
        }
    }
}
