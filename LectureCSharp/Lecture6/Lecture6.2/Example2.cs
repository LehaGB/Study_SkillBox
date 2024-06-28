using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6._2
{
    class Example2
    {
        static void Main(string[] args)
        {
            char c = 'c';

            // Показывает, относится ли указанный символ Юникода к категории десятичных цифр.
            bool n = Char.IsDigit(c);
            Console.WriteLine($"n = {n}");

            // Показывает, относится ли указанный символ Юникода к категории букв Юникода.
            bool s = Char.IsLetter(c);
            Console.WriteLine($"s = {s}");

            Console.WriteLine();

            char[] symbols = "symbols".ToCharArray();
            foreach (var item in symbols)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            string str = new String(symbols);
            foreach (var item in str)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
