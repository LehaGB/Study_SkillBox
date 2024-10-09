using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._2
{
    class Cat
    {
        /// <summary>
        /// Создание экземпляра котика
        /// </summary>
        /// <param name="Nickname">Кличка</param>
        /// <param name="Breed">Порода</param>
        public Cat(string Nickname, string Breed)
        {
            this.Nickname = Nickname;
            this.breed = Breed;
        }

        // Порода
        private string breed;


        // Свойство, описывающее кличку.
        public string Nickname { get; set; }  // Состояние


        // Свойство, описывающее породу.
        public string Breed
        {
            get { return this.breed; }  // Повидение
        }

        // Метод, определяющий логику игры котика.
        public void ToPlay()
        {
            Console.WriteLine($"{this.Nickname} играет...");
        }

        // Метод, определяющий логику сна котика.
        public void ToSleep()
        {
            Console.WriteLine($"{this.Nickname} спит...");
        }

        // Метод, определяющий логику питания котика.
        public void ToEat()
        {
            Console.WriteLine($"{this.Nickname} кушает...");
        }

        // Мяуканье котика.
        public void ToMew()
        {
            Console.WriteLine($"Мяу!");
        }
    }
}
