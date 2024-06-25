using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lecture5._2
{
    // Методы, что то делают и выдают результат(возвращают значение);
    class Example3
    {
        static void Main(string[] args)
        {
            string res = GetRandomString();
            Console.WriteLine(res);

            res = GetRandomHi();
            Console.WriteLine(res);

            res = GetPath();
            Console.WriteLine(res);

            Console.ReadKey();
        }


        // Метод генерации строки из набора случайных символов.
        static string GetRandomString()
        {
            return Guid.NewGuid().ToString();
        }


        // Метод возвращает случайное приветствие.
        static string GetRandomHi()
        {
            Random r = new Random();

            string text = string.Empty;

            switch (r.Next(5))
            {
                case 0:
                    text = $"Привет!";
                    break;
                case 1:
                    text = $"Добрый день!";
                    break;
                case 2:
                    text = $"Приветствую тебя!";
                    break;
                case 3:
                    text = $"Рад тебя видеть!";
                    break;
                default:
                    text = $"Я так ждал тебя!";
                    break;
            }
            return text;
        }


        // Метод, возвращающий полный путь к текущему приложению.
        static string GetPath()
        {
            return Application.ExecutablePath;
        }
    }
}
