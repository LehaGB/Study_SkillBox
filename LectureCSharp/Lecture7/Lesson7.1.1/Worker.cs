using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._1._1
{
    /// <summary>
    /// Структура описывающая хозяина домашнего питомца
    /// </summary>
    public struct Worker
    {

        // Конструктор
        public Worker(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        //Имя 
        public string Name;


        //Возраст
        public int Age;
    }
}
