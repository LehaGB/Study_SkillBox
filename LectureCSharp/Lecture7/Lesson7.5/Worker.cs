using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._5
{
    // 7.5 Описание членов структуры: индексаторы
    struct Worker
    {
        // Должность
        public string Position { get; set; }

        // Зарплата
        public int Salary { get; set; }

        // Имя
        public string FirstName { get; set; }

        // Вывод данных о сотруднике
        public string Print()
        {
            return $"Должность: {Position} Зарплата: {Salary} Имя: {FirstName}";
        }

        // Создание сотрудника
        public Worker(string Position, int Salary, string FirstName)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.FirstName = FirstName;
        }
    }
}
