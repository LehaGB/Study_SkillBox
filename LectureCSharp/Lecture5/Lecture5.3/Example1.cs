using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5._3
{
    //5.3 Перегрузка методов
    class Example1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            Fill(arr);
            Print(arr);
            Console.ReadKey();


            Fill(arr, 10);
            Print(arr);
            Console.ReadKey();

            Fill(arr, -10, 0);
            Print(arr);
            Console.ReadKey();

            Fill(arr, 10, 1, 30);
            Print(arr);
            Console.ReadKey();

        }


        //Метод, заполняющий массив Col
        static void Fill(int[] col)
        {
            Random r = new Random();

            for (int i = 0; i < col.Length; i++)
            {
                col[i] = r.Next(100);
            }
        }


        //Метод, заполняющий первых Count элементов массива col
        static void Fill(int[] col, int count)
        {
            Random r = new Random();

            for (int i = 0; i < count; i++)
            {
                col[i] = r.Next(100);
            }
        }


        //Метод, заполняющий массив Col числами из диапазона Bottom до Upper
        static void Fill(int[] col, int bottomRange, int upperRange)
        {
            Random r = new Random();

            for (int i = 0; i < col.Length; i++)
            {
                col[i] = r.Next(bottomRange, upperRange);
            }
        }


        //Метод, заполняющий первых Count элементов массива col числами из диапазона Bottom до Upper
        static void Fill(int[] col, int count, int bottomRange, int upperRange)
        {
            Random r = new Random();

            for (int i = 0; i < count; i++)
            {
                col[i] = r.Next(bottomRange, upperRange);
            }
        }


        //Метод вывода массива в консоль
        static void Print(int[] col)
        {
            for (int i = 0; i < col.Length; i++)
            {
                Console.Write($"{col[i]} ");
            }
            Console.WriteLine();
        }
    }
}
