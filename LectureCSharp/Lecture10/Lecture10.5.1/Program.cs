using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Начальные характеристики\n");
            //Druid druid = new Druid("druid :", 1, 100);
            //druid.Motto();
            //Console.WriteLine(druid.HeroInformation());

            //Warrior warrior = new Warrior("warrior", 1, 100);
            //warrior.Motto();
            //Console.WriteLine(warrior.HeroInformation());

            //Hunter hunter = new Hunter("hunter", 1, 100);
            //hunter.Motto();
            //Console.WriteLine(hunter.HeroInformation());

            //Console.WriteLine("\nПосле атаки");

            //druid.Attacked(50);
            //Console.WriteLine(druid.HeroInformation());

            //warrior.Attacked(50);
            //Console.WriteLine(warrior.HeroInformation());

            //hunter.Attacked(50);
            //Console.WriteLine(hunter.HeroInformation());


            //Console.WriteLine("\nПосле лечения");

            //druid.Treatment(20);
            //Console.WriteLine(druid.HeroInformation());

            //warrior.Treatment(20);
            //Console.WriteLine(warrior.HeroInformation());

            //hunter.Treatment(20);
            //Console.WriteLine(hunter.HeroInformation());

            //Console.WriteLine();

            //Console.ReadKey();


            //Команда с полиморфизмом

            Random random = new Random();

            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < 8; i++)
            {
                switch (random.Next(3))
                {
                    case 0: heroes.Add(new Druid());
                        break;
                    case 1: heroes.Add(new Hunter());
                        break;
                    default: heroes.Add(new Warrior());
                        break;
                }
                Console.WriteLine(heroes[i]);


                // Проверка вплоть до иерархии.
                if (heroes[i] is Druid)
                {
                    (heroes[i] as Druid).Heal();
                }


                // Более точная проверка.
                if (heroes[i].GetType() == typeof(Druid))
                {
                    (heroes[i] as Druid).Heal();
                }

                heroes[i].Motto();
            }
            Console.ReadLine();
        }
    }
}
