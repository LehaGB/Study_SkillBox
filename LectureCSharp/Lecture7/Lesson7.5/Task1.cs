using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._5
{
    // 7.5 Описание членов структуры: индексаторы
    class Task1
    {
        static void Main(string[] args)
        {
            Staff3();
            Console.ReadKey();
        }
        public static void Staff()
        {
            Repository1 db1 = new Repository1(
                new Worker("Должность_1", 10000, "Имя_1"),
                new Worker("Должность_2", 10000, "Имя_2"),
                new Worker("Должность_3", 10000, "Имя_3"),
                new Worker("Должность_4", 10000, "Имя_4"),
                new Worker("Должность_5", 10000, "Имя_5")
                );
            Console.WriteLine(db1[0].Print());

            db1[0] = new Worker("Должность_111", 10000, "Имя_17777");
            Console.WriteLine(db1[0].Print());
        }
        public static void Staff2()
        {
            Repository2 db2 = new Repository2(
                new Worker("Должность_1", 10000, "Имя_1"),
                new Worker("Должность_2", 10000, "Имя_2"),
                new Worker("Должность_3", 10000, "Имя_3"),
                new Worker("Должность_4", 10000, "Имя_4"),
                new Worker("Должность_5", 10000, "Имя_5")
                );
            Console.WriteLine(db2[3]);
        }

        public static void Staff3()
        {
            Repository3 db3 = new Repository3(
                new Worker("Должность_1", 10000, "Имя_1"),
                new Worker("Должность_2", 10000, "Имя_2"),
                new Worker("Должность_3", 10000, "Имя_3"),
                new Worker("Должность_4", 10000, "Имя_4"),
                new Worker("Должность_5", 10000, "Имя_5")
                );
            Console.WriteLine(db3[3]);
            Console.WriteLine(db3["6"]);
        }
    }
}
