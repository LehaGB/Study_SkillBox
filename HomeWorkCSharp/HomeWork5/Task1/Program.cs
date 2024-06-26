﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {


        static string[] SplitText(string text)
        {
            string[] subs = text.Split(' ');
            return subs;
        }


        static void Print(string text)
        {
            string[] newString = SplitText(text);
            foreach (var e in newString)
            {
                Console.WriteLine($"{e}");
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();

            Console.WriteLine();

            SplitText(text);
            Print(text);

            Console.ReadKey();

        }
    }
}
