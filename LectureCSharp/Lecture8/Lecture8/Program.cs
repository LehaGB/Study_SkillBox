using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    /// <summary>
    /// 8.1 Коллекции: пространство System.Collections.Generic, коллекция List
    /// </summary>
    class Program
    {   
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list[1] = 11;

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.ReadLine();
        }
    }
}
