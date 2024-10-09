using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ролик 1. Понятие класса, объекта, экземпляра класса.


            // Создание котиков.
            Cat cat1 = new Cat("Барсик", "Русская голубая кошка");
            Cat cat2 = new Cat("Мурзик", "Майн-кун");
            Cat cat3 = new Cat("Белка", "Манчкин");

            // Создание домов.
            House house1 = new House(18, 182, "г.Смоленск, ул.Ленина, д. 1");
            House house2 = new House(18, 182, "п.Запрудная, ул.Пролетарский проспект, д. 2");

            // Создание робота.
            Robot robot = new Robot("С-ЗРО", "Звездные воины");

            Console.WriteLine($"Кличка: {cat1.Nickname} Порода: {cat1.Breed}");
            Console.WriteLine($"Кличка: {cat2.Nickname} Порода: {cat2.Breed}");
            Console.WriteLine($"Кличка: {cat3.Nickname} Порода: {cat3.Breed}");
            Console.WriteLine("=============");

            Console.WriteLine($"Кол-во этажей: {house1.FloorCount} " +
                $"Кол-во квартир: {house1.FlatCount} Адрес: {house1.Address}");
            Console.WriteLine($"Кол-во этажей: {house2.FloorCount} " +
                $"Кол-во квартир: {house2.FlatCount} Адрес: {house2.Address}");
            Console.WriteLine("=============");

            Console.WriteLine($"Имя робота: {robot._Nickname} Дислокация: {robot.Dislocation}");
            Console.ReadLine();
        }
    }
}
