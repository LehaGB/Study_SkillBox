using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class ExampleSwitch
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня: ");
            int dayIndex = int.Parse(Console.ReadLine());

            switch (dayIndex)
            {
                case 1:
                    Console.WriteLine("Понидельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Вщскресенье");
                    break;
                default:
                    Console.WriteLine("На планете Земля в неделе семь дней");
                    break;
            }
            Console.ReadLine();
        }
    }
}
