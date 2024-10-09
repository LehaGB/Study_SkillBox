using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._7
{
    class Warrior : Hero, IRampage
    {
        // Девиз игрока(воина).
        public override void Motto()
        {
            Console.WriteLine($"\n{this.Name} Мой молот готов служить всезнающему!\n");
        }

        // Защита от дамага.
        uint blckDamage;



        // Создание воина.
        public Warrior(string Name, byte Level, uint HitPoint) :
            base(Name, Level, HitPoint)
        {
            this.blckDamage = 2;
            this.Cherge = 5;
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


        // Интерфейс (IRampage)
        public int Cherge { get; set; }

        public void Recherge()
        {
            this.Cherge = 5;
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
