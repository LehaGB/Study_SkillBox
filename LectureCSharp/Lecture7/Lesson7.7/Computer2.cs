﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._7
{
    public struct Computer2
    {

        /// <summary>
        /// Имя компьютера
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        private bool condition;


        /// <summary>
        /// Индикатор состояния
        /// </summary>
        public int indicator 
        {
            get { return this.condition ? 1 : 0; }
        }


        /// <summary>
        /// Создание компьютера
        /// </summary>
        /// <param name="Title">Имя компьютера</param>
        public Computer2(string Title)
        {
            this.Title = Title;
        }

        public void Power()
        {
            if (this.condition)
            {
                this.PowerOff();
                this.condition = false;
            }
            else
            {
                this.PowerOn();
                this.condition = true;
            }
        }
        /// <summary>
        /// Загрузка биос
        /// </summary>
        private void ActivanionBIOS()
        {
            Console.WriteLine($"{this.Title} | Activanion BiOS...");
        }

        /// <summary>
        /// Загрузка ОС
        /// </summary>
        private void ActivanionOS()
        {
            Console.WriteLine($"{this.Title} | Activanion OS...");
        }

        /// <summary>
        /// Приветствие
        /// </summary>
        private void Greeting()
        {
            Console.WriteLine($"{this.Title} | Hello...");
        }

        /// <summary>
        /// Выгрузка BIOS
        /// </summary>
        private void DeactivanionBIOS()
        {
            Console.WriteLine($"{this.Title} | Deactivanion BIOS...");
        }

        /// <summary>
        /// Выгрузка ОС
        /// </summary>
        private void DeactivanionOS()
        {
            Console.WriteLine($"{this.Title} | Deactivanion OS...");
        }

        /// <summary>
        /// Прощание
        /// </summary>
        private void Parting()
        {
            Console.WriteLine($"{this.Title} | Bye...");
        }

        /// <summary>
        /// Включение
        /// </summary>
        public void PowerOn()
        {
            this.ActivanionBIOS();
            this.ActivanionOS();
            this.Greeting();
            this.Calculation();
        }

        /// <summary>
        /// Выключение
        /// </summary>
        public void PowerOff()
        {
            this.Parting();
            this.DeactivanionOS();
            this.DeactivanionBIOS();
        }

        /// <summary>
        /// Меттод демонстрирующий работу
        /// </summary>
        private void Calculation()
        {
            Console.WriteLine($"\n{this.Title} | Calculation...\n");
        }
    }
}
