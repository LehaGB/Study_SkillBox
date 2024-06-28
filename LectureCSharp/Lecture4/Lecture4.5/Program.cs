using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._5
{

    //4.5 Многомерные массивы: использование, задание.

    class Program
    {
        static void Main(string[] args)
        {
            int[,,] matrix3D = new int[3, 4, 5];

            Console.WriteLine($"matrix3D.Rank = {matrix3D.Rank}");

            Console.WriteLine($"matrix3D.Length = {matrix3D.Length}");
            Console.WriteLine($"matrix3D.GetLength(0) = {matrix3D.GetLength(0)}");
            Console.WriteLine($"matrix3D.GetLength(1) = {matrix3D.GetLength(1)}");
            Console.WriteLine($"matrix3D.GetLength(2) = {matrix3D.GetLength(2)}");

            Random rand = new Random();

            for (int i = 0; i < matrix3D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix3D.GetLength(2); k++)
                    {
                        matrix3D[i, j, k] = rand.Next(10);
                        Console.Write($"{matrix3D[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            int[,,,] matrix3D2 = new int[3, 4, 5, 6];

            Console.WriteLine($"matrix3D2.Rank = {matrix3D2.Rank}");

            Console.WriteLine($"matrix3D2.Length = {matrix3D2.Length}");
            Console.WriteLine($"matrix3D2.GetLength(0) = {matrix3D2.GetLength(0)}");
            Console.WriteLine($"matrix3D2.GetLength(1) = {matrix3D2.GetLength(1)}");
            Console.WriteLine($"matrix3D2.GetLength(2) = {matrix3D2.GetLength(2)}");
            Console.WriteLine($"matrix3D2.GetLength(2) = {matrix3D2.GetLength(3)}");
            Console.WriteLine($"memory: {matrix3D2.Length * sizeof(int)}");


            for (int i = 0; i < matrix3D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix3D.GetLength(2); k++)
                    {
                        for (int m = 0; m < matrix3D2.GetLength(3); m++)
                        {
                            matrix3D2[i, j, k, m] = rand.Next(10);
                            Console.Write($"{matrix3D2[i, j, k, m]} ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
