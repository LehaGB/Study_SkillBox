using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._7
{
    //4.7 Цикл foreach
    class Example3
    {
        static void Main(string[] args)
        {
            string massage = "Я C#-разработчик";

            for (int i = 0; i < massage.Length; i++)
            {
                Console.Write($"{massage[i]} ");
            }
            Console.WriteLine();

            foreach (var c in massage)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
