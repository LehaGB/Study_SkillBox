using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Task4
    {
        //Задание 4. Наименьший элемент в последовательности
        static void Main(string[] args)
        {
            Console.Write("Введите длину последовательности: ");
            int number = int.Parse(Console.ReadLine());

            int element = 0;
            int minNumber = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                element = int.Parse(Console.ReadLine());
                if(element < minNumber)
                {
                    minNumber = element;
                }
            }
            Console.WriteLine(minNumber);
            Console.ReadKey();
        }
    }
}
