using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5._4
{

    // 5.4 Понятие рекурсивной функции.

    class Example4
    {

        static void Find(char[] set, char[] word, int n)
        {
            if(n == word.Length)
            {
                foreach(var e in word)
                {
                    Console.Write(e);
                }
                Console.WriteLine();
                return;
            }


            char[] tWord = word;

            for (int i = 0; i < set.Length; i++)
            {
                tWord[n] = set[i];
                Find(set, tWord, n + 1);
            }
        }

        static void Main(string[] args)
        {
            char[] alphaBet = { '1', '2', '3', '4'};
            char[] currentWord = new char[4];
            Find(alphaBet, currentWord, 0);
            Console.ReadKey();
        }
    }
}
