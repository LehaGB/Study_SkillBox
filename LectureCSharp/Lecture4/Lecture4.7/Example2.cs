using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._7
{
    // 4.7 Цикл foreach.
    class Example2
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[][] dataTime = new int[24][];

            for (int j = 0; j < dataTime.Length; j++)
            {
                dataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            }

            foreach (int[] array in dataTime)
            {
                foreach (var item in array)
                {
                    Console.Write($"{item, 3}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
