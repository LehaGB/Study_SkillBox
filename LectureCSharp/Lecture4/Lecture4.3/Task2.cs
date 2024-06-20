using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._3
{
    //4.3 Вложенные циклы, операторы break и continue
    class Task2
    {
        //Показать всевозиожные слова из алфавита S K I L
        static void Main(string[] args)
        {
            char[] symbols = { 'S', 'K', 'I', 'L' };
            int count = 1;

            for (int i = 0; i < symbols.Length; i++)
            {
                for(int j = 0; j < symbols.Length; j++)
                {
                    for(int k = 0; k < symbols.Length; k++)
                    {
                        Console.WriteLine($"{count++, 3}: {symbols[i]}{symbols[j]}{symbols[k]}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
