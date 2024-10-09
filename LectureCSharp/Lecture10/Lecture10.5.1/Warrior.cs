using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._5._1
{

    // Воин.
    class Warrior : Hero
    {
        uint blckDamage = 2;
        public override void Motto()
        {
            Console.WriteLine($"\n{this.Name} Мой молот готов служить всезнающему!\n");
        }


        // Создание воина.
        public Warrior(string Name, byte Level, uint HitPoint) :
            base(Name, Level, HitPoint)
        {

        }


        // Создание воина с автопараметрами.
        public Warrior() : this("", 1, 0)
        {

        }


        // Метод, определяющий логику в случае атаки другим героем.
        public override void Attacked(uint damage)
        {
            base.Attacked(damage / blckDamage);
        }
    }
}
