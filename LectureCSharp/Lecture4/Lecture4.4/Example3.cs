using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._4
{
    class Example3
    {
        //В матрице Z[3x3] кадждый элемент разделить на диагональный, стоящий в ом же столбце.
        static void Main(string[] args)
        {
            Random rand = new Random();

            double[,] z = new double[3, 3];

            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    z[i, j] = rand.Next(1, 10);
                    Console.Write($"{z[i, j], 6}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица Z[3x3] после преоброзования: ");

            for (int i = 0; i < z.GetLength(0); i++)
            {
                double div = z[i, i];
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    z[i, j] /= div;
                    Console.Write($"{Math.Round( z[i, j], 3), 6}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
