using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._5._1
{
    class Druid : Hero
    {
        public override void Motto()
        {
            Console.WriteLine($"\n{this.Name} Благословляю всех!\n");
        }


        // Создание друида.
        public Druid(string Name, byte Level, uint HitPoint) :
            base(Name, Level, HitPoint)
        {

        }


        // Создание друида с автопараметрами.
        public Druid() : this("", 1, 0)
        {

        }


        // Метод, определяющий логику лечения.
        public new void Treatment(uint Hp = 10)
        {
            Hp = (uint)(Hp * 1.5);
            base.Treatment(Hp);
        }


        // Лечение.
        public uint Heal()
        {
            return (uint)Druid.randomize.Next(5, 10);
        }
    }
}
