using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Task3
    {
        //Задание 3. Проверка простого числа.
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            bool simple = true;
            while(i <= n / 2)
            {
                if (n % i == 0)
                {
                    simple = false;
                }
                i++;
            }
            if (simple)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            Console.ReadLine();
        }
    }
}
