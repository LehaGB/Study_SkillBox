using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5._4
{

    // 5.4 Понятие рекурсивной функции.

    class Example2
    {
        // Число Фибанначи, с помощью рекурсии.
        static int Fib(int N)
        {
            return (N == 1 || N == 2) ? 1 : Fib(N - 1) + Fib(N - 2);
        }


        // Число Фибанначи, с помощью цикла.
        static int FibLoop(int N)
        {
            int a1 = 1;
            int a2 = 1;
            int t = a2;

            for (int i = 2; i < N; i++)
            {
                t = a1 + a2;
                a1 = a2;
                a2 = t;
            }
            return t;
        }


        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine($"Fib({i, 2}) = {Fib(i)}   {FibLoop(i)} ");
            }


            Console.ReadKey();
        }
    }
}
