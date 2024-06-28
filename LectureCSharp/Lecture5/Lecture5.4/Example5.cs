using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5._4
{

    // 5.4 Понятие рекурсивной функции.

    class Example5
    {

        static int F(int N)
        {
            Console.WriteLine($"F{N}");
            return (N > 2) ? F(N - 1) + G(N - 2) : N;
        }
        

        static int G(int N)
        {
            Console.WriteLine($"G{N}");
            return (N > 2) ? G(N - 1) + F(N - 2) : N + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(F(6));
            Console.ReadKey();

            Console.WriteLine(F(8));

            Console.WriteLine(F(13));

            Console.ReadKey();
        }
    }
}
