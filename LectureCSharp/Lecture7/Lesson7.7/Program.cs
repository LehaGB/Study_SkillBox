using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer1 computer1 = new Computer1("Computer 1");

            computer1.PowerOn();
            Console.ReadKey();
        }
    }
}
