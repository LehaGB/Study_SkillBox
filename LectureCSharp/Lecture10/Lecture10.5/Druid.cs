using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._5
{
    class Druid
    {
        static uint defIndexName;
        static Random randomize;
        static List<string> dbName;

        // Правильно всего - это делать инициализацию static полей в конструкторе.
        static Druid()
        {
            defIndexName = 1;
            dbName = new List<string>();
            randomize = new Random();
        }

        byte level;
        uint hitPoint;
        uint maxHitPoint;



        // Имя.
        public string Name { get; set; }


        // Уровень.
        public byte Level
        {
            get { return this.level; }
        }


        // Запас здоровья.
        public uint HitPoint
        {
            get { return this.hitPoint; }
        }


        // Создание героя.
        public Druid(string Name, byte Level, uint HitPoint)
        {

            if (Name == string.Empty || Druid.dbName.Contains(Name))
            {
                Name = $"{Guid.NewGuid().ToString().Substring(0, 5)} #{Druid.defIndexName++}";
            }


            this.Name = Name;
            Druid.dbName.Add(Name);
            this.level = Level;

            HitPoint = HitPoint != 0 ? HitPoint : (uint)Druid.randomize.Next(100, 400);
            this.hitPoint = HitPoint;
            this.maxHitPoint = HitPoint;
        }


        // Создание героя с автопараметрами.
        public Druid() : this("", 1, 0)
        {

        }


        // Метод, определяющий логику лечения.
        public void Treatment(uint Hp = 10)
        {
            Hp = (uint)(Hp * 1.5);
            if (this.hitPoint == 0)
            {
                Console.WriteLine($"Лечение невозможно, {this.Name} в таверне");
            }
            else
            {
                this.hitPoint = this.hitPoint + Hp <= this.maxHitPoint ? this.hitPoint + Hp :
                    this.maxHitPoint;
            }
        }


        // Лечение.
        public uint Heal()
        {
            return (uint)Druid.randomize.Next(5, 10);
        }


        // Метод, определяющий логику атаки.
        public uint Attack()
        {
            return 10;
        }


        // Метод, определяющий логику в случае атаки другим героем.
        public void Attacked(uint damage)
        {
            if (this.hitPoint == 0)
            {
                this.Tavern();
            }
            else
            {
                if (this.hitPoint - damage <= 0)
                {
                    this.hitPoint = 0;
                    this.Die();
                }
                else
                {
                    this.hitPoint -= damage;
                }
            }
        }


        // Информация о герое.
        public string HeroInformation()
        {
            return String.Format("Name: {0, 10} | Level: {1, 4} | HitPoint: {2, 6} | Type{3, 13}",
                this.Name,
                this.Level,
                this.HitPoint,
                this.GetType().Name
                );
        }


        // Логика отправки героя в таверну.
        private void Die()
        {
            Console.WriteLine($"У {this.Name} критический уровень запаса здоровья");
            this.Tavern();
        }


        // Информация о нахождении в таверне.
        private void Tavern()
        {
            Console.WriteLine($"Герой {this.Name} в таверне");
        }
    }
}
