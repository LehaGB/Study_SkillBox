using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._3
{
    //4.3 Вложенные циклы, операторы break и continue
    class Program
    {
        //Рапечатать таблицу умножения.
        static void Main(string[] args)
        {
            for (int i = 2; i < 20; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
