using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._5._1
{
    // Охотник.
    class Hunter : Hero
    {
        public override void Motto()
        {
            Console.WriteLine($"\n{this.Name} Охота началась!\n");
        }


        // Создание охотника.
        public Hunter(string Name, byte Level, uint HitPoint) :
            base(Name, Level, HitPoint)
        {

        }


        // Создание охотника с автопараметрами.
        public Hunter() : this("", 1, 0)
        {

        }


        // Бонусный выстрел.
        public uint HeadShot()
        {
            return (Hunter.randomize.Next(4) != 0) ?
                this.Attack() :
                this.Attack() + (uint)Hunter.randomize.Next(10, 20);
        }
    }
}
