using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8._2
{
    /// <summary>
    /// Создать частотный словарь.
    /// </summary>
    class Example5_Dictionary
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(r.Next(20));
            }

            var dictionary = new Dictionary<int, int>();

            foreach (var e in list)
            {
                if (!dictionary.ContainsKey(e)) dictionary.Add(e, 0);
                dictionary[e]++;
            }
            foreach (var e in dictionary)
            {
                Console.WriteLine($"{e.Key, 3} встречается {e.Value, 4} p.");
            }
            Console.ReadLine();
        }
    }
}
