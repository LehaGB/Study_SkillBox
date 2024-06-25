using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5._2
{
    //5.2 Параметры методов, модификаторы параметров, возвращение значений
    // Методы, что делают.
    class Example1
    {
        static void Main(string[] args)
        {
            Hi();
            ApplauseAndOvations();
            Pause();
        }

        //Метод задержки закрытия консоли.
        static void Pause()
        {
            Console.ReadKey();
        }


        //Вывод приветствия в консоль.
        static void Hi()
        {
            Console.WriteLine("Привет!");
        }


        //Беспорядок в консоли.
        static void ApplauseAndOvations()
        {
            Random r = new Random();

            for (int i = 0; i < r.Next(30, 50); i++)
            {
                int posX = r.Next(Console.WindowWidth - 5);         // Получение ширины консоли.
                int posY = r.Next(Console.WindowHeight - 1);        // Получения высоты консоли.
                Console.SetCursorPosition(posX, posY + 1);          // Установка курсора в случайную позицию экрана.

                //Если 0, вывод Ура, если 1 то вывод Ууу
                Console.Write(r.Next(2) == 0 ? "Ура!" : "Ууу!");    // Вывод одного из радостных сообщений.
            }
        }

      
    }
}
