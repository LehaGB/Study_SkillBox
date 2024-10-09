using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._7
{
    // 10.7 Абстракции, интерфейсы
    class Program
    {
        static void Main(string[] args)
        {
            Druid druid = new Druid("Druid", 1, 500);

           Console.WriteLine(druid.ToString());

            List<IRampage> rampages = new List<IRampage>()
            {
                new Hunter(),
                new Warrior(),
            };

            foreach (var item in rampages)
            {
                item.UltraAttack(druid);
                Console.WriteLine(druid.ToString());
                druid.Treatment();
            }



            foreach (var item in rampages)
            {
                item.Recherge();
            }


            foreach (var item in rampages)
            {
                item.UltraAttack(druid);
                Console.WriteLine(druid.ToString());
                druid.Treatment();
            }

            Console.ReadLine();
        }
    }
}
