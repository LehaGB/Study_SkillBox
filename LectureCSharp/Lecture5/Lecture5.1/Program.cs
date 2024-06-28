using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5._1
{
    // 5.1 Разделение логики: использование методов.
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Print("Текст в консоли");
            Delay();
        }


        //Прмиер 1. Вызов метода void HelloWorld()
        public static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }


        //Пример 2. Вызов метода void Print(string text)
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        //Пример 3. Вызов метода void Delay()
        public static void Delay()
        {
            Console.ReadKey();
        }
    }
}
