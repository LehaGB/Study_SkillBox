using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._1._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Workers();
            DogsWorker();
            CatsWorker();
            Console.ReadKey();
        }
        public static void Workers()
        {
            Worker worker = new Worker("Robert", 5);
            Console.WriteLine($"Имя: {worker.Name}, Возраст: {worker.Age}");
            Console.WriteLine();
        }
        public static void DogsWorker()
        {
            Dogs dogs = new Dogs("Шарик", 3, "Чихуахуа");
            Console.WriteLine($"Кличка: {dogs.Name}, Возраст: {dogs.Age}, Порода: {dogs.Breed}");
            Console.WriteLine();
        }
        public static void CatsWorker()
        {
            Cats cats = new Cats("Барсик", 2, "Бельгийский");
            Console.WriteLine($"Кличка: {cats.Name}, Возраст: {cats.Age}, Порода: {cats.Breed}");
        }
    }
}
