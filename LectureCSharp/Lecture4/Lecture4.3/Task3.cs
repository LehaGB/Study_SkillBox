using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._3
{
    // 4.3 Вложенные циклы, операторы break и continue.
    class Task3
    {
        //Решение уравнения.
        static void Main(string[] args)
        {
            for(double a = 1; a < 500; a++)
            {
                for(double b = 1; b < 500; b++)
                {
                    if((2 * a * a * a + 3 * b * b) == 8337)
                    {
                        Console.WriteLine($"a = {a} b = {b}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
