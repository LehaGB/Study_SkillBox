using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5._4
{
    class Example3
    {

        public static string Number(int N)
        {
            return N < 10 ? N.ToString() : $"{Number(N / 10)} {N % 10}";
        }


        //Первернутые  числа с помощью рекурсии.
        public static string Numbers(int N)
        {
            return N < 10 ? N.ToString() : $"{N % 10} {Numbers(N / 10)} ";
        }
        static void Main(string[] args)
        {
            // Введите все цифры натурального числа N по одной
            Console.WriteLine($"{Number(1234654)} ");
            Console.WriteLine($"{Numbers(1234654)} ");
            Console.ReadKey();
        }
    }
}
