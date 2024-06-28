using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._3
{

    // 4.3 Вложенные циклы, операторы break и continue.

    class Task4
    {
        // break, continue.
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                for (int j = 0; j < 10; j++)
                {
                    
                    Console.Write($"({i} {j}) ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"count = {count}");
            Console.ReadKey();
        }
    }
}
