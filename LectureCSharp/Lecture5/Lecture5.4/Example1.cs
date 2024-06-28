using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture5._4
{
    // 5.4 Понятие рекурсивной функции.
    class Example1
    {
        static void NotInfinity(int count)
        {
            Console.WriteLine("O_- ");
            Thread.Sleep(100);
            count = count - 1;
            if(count > 0)        //Базовый случай(условие выхода, когда нужно выйти из рекурсии).
            {
                NotInfinity(count);
            }
        }
        static void Main(string[] args)
        {
            NotInfinity(20);
            Console.ReadKey();
        }
    }
}
