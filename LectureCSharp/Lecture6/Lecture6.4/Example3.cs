using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture6._4
{

    // 6.4 Работа с потоками: StreamWriter и StreamReader.

    class Example3
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("db.csv", Encoding.Unicode))
            {
                while (!sr.EndOfStream)
                {
                    var c = sr.Read();
                    Console.WriteLine($"{c} - {(Char)c}");
                }
            }
            Console.WriteLine();


            using (StreamReader sr = new StreamReader("db.csv", Encoding.Unicode))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
