using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture5._2
{
    //5.2 Параметры методов, модификаторы параметров, возвращение значений
    // Методы с аргументами.
    class Example2
    {
        static void Main(string[] args)
        {
            Hi("Илон");
            ApplauseAndOvations("Огого!", "Ёёёёууу!", 30);
            Pause(5);
        }


        //Метод откладывающий закрытие консоли на Interval секунд.
        static void Pause(int interval)
        {
            Thread.Sleep(interval * 1000);
        }


        //Вывод персонифицированного приветствия в консоль.
        static void Hi(string name)
        {
            Random r = new Random();

            string text = string.Empty;

            switch (r.Next(5))
            {
                case 0:
                    text = $"Привет, {name}!";
                    break;
                case 1:
                    text = $"Добрый день, {name}!";
                    break;
                case 2:
                    text = $"Приветствую тебя, {name}!";
                    break;
                case 3:
                    text = $"Рад тебя видеть, {name}!";
                    break;
                default:
                    text = $"Я так ждал тебя, {name}!";
                    break;
            }
            Console.WriteLine(text);
        }


        //Упорядочный бепорядок на экране нужное количество раз.
        static void ApplauseAndOvations(string text1, string text2, int count)
        {
            Random r = new Random();

            int max = new int[] { text1.Length, text2.Length }.Max();

            for (int i = 0; i < count; i++)
            {
                int posX = r.Next(Console.WindowWidth - max);         // Получение ширины консоли.
                int posY = r.Next(Console.WindowHeight);        // Получения высоты консоли.
                Console.SetCursorPosition(posX, posY + 1);          // Установка курсора в случайную позицию экрана.

                //Если 0, вывод text1, если 1 то вывод text2
                Console.Write(r.Next(2) == 0 ? text1 : text2);    // Вывод одного из радостных сообщений.
            }
        }
    }
}
