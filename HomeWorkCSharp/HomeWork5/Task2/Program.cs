using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        /// <summary>
        /// Разбиваем предложение на пробелы.
        /// </summary>
        /// <param name="inputPhrase">Входящее предложение</param>
        static void ReversWords(string inputPhrase)
        {
            string[] text = inputPhrase.Split(' ');
            string result = Reverse(inputPhrase);
            Console.Write($"Перевернутое предложение: {result}");

        }

        /// <summary>
        /// Разворачиваем предложение в обратной последовательности.
        /// </summary>
        /// <param name="text">Входящее предложение</param>
        /// <returns>Развернутое предложение</returns>
        static string Reverse(string text)
        {
            string reversed = String.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }
            return reversed;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();

            ReversWords(text);

            Console.ReadKey();
        }
    }
}
