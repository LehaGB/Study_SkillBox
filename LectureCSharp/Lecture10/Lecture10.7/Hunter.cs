using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._7
{
    class Hunter : Hero, IRampage
    {
        public override void Motto()
        {
            Console.WriteLine($"\n{this.Name} Охота началась!\n");
        }


        // Создание охотника.
        public Hunter(string Name, byte Level, uint HitPoint) :
            base(Name, Level, HitPoint)
        {
            this.Cherge = 3;
        }


        // Создание охотника с автопараметрами.
        public Hunter() : this("", 1, 0)
        {

        }


        //// Бонусный выстрел.
        //public uint HeadShot()
        //{
        //    return (Hunter.randomize.Next(4) != 0) ?
        //        this.Attack(Target) :
        //        this.Attack(Target) + (uint)Hunter.randomize.Next(10, 20);
        //}



        // Интерфейс (IRampage)
        public int Cherge { get; set; }

        public void Recherge()
        {
            this.Cherge = 3;
        }

        public void UltraAttack(Hero Target)
        {
            for (int i = 0; i < this.Cherge; i++)
            {
                Target.Attacked(10);
            }
            this.Cherge = 0;
        }
    }
}
