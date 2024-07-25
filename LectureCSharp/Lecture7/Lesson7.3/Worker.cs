using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._3
{
    // 7.3 Описание членов структуры: конструкторы
    struct Worker
    {
        /// <summary>
        /// Должность.
        /// </summary>
        public string Position;


        /// <summary>
        /// Зарплата.
        /// </summary>
        public int Salary;


        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName;


        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName;


        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime DateOfBirth;


        public string Print()
        {
            return $"Должность: {Position} Зарплата: {Salary} Имя: {FirstName} Фамилия: {LastName}" +
                $"Дата рождения: {DateOfBirth.ToShortDateString()}";
        }


       /// <summary>
       /// Коструктор
       /// </summary>
       /// <param name="Position"></param>
       /// <param name="Salary"></param>
       /// <param name="FirstName"></param>
       /// <param name="LastName"></param>
       /// <param name="DateOfBirth"></param>
        public Worker(string Position, int Salary, string FirstName, string LastName, DateTime DateOfBirth)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
        }


        /// <summary>
        /// Конструкторы v 2.0
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Salary"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        public Worker(string Position, int Salary, string FirstName, string LastName) :
            this(Position, Salary, FirstName, LastName, new DateTime(1980, 2, 4))
        {

        }


        /// <summary>
        /// Конструкторы v 2.0
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Salary"></param>
        /// <param name="FirstName"></param>
        public Worker(string Position, int Salary, string FirstName) :
            this(Position, Salary, FirstName, String.Empty, new DateTime(1980, 2, 4))
        {

        }


        /// <summary>
        /// Конструкторы v 2.0
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="FirstName"></param>
        public Worker(string Position, string FirstName) :
            this(Position, 0, FirstName, String.Empty, new DateTime(1980, 2, 4))
        {

        }


        /// <summary>
        /// Конструкторы v 2.0
        /// </summary>
        /// <param name="FirstName"></param>
        public Worker(string FirstName) :
          this(string.Empty, 0, FirstName, String.Empty, new DateTime(1980, 2, 4))
        {
            this.Salary = 10000;
        }
    }
}
