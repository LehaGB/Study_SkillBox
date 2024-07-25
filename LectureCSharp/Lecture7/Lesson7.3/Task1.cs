using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._3
{
    // 7.3 Описание членов структуры: конструкторы
    class Task1
    {
        static void Main(string[] args)
        {
            Worker w = new Worker("Директор", "Иван");
            Console.WriteLine(w.Print());

            w = new Worker("Иван");
            Console.WriteLine(w.Print());
            Console.ReadKey();
        }
    }
}
