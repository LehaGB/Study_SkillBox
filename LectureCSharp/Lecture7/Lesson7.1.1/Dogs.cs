using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._1._1
{
    /// <summary>
    /// Описание собаки
    /// </summary>
    public struct Dogs
    {

        public Dogs(string Name, int Age, string Breed)
        {
            this._name = Name;
            this._age = Age;
            this._breed = Breed;
        }

        //Кличка 
        private string _name;

        /// <summary>
        /// Свойство для доступа к кличке
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        //Возраст
        private int _age;

        /// <summary>
        /// Свойство для доступа к информации о возросте
        /// </summary>
        public int Age
        {
            get { return this._age; }
        }


        //Порода
        private string _breed;

        /// <summary>
        /// Свойство для доступа к информации о породе
        /// </summary>
        /// <returns>Порода</returns>
        public string Breed
        {
            get { return this._breed; }
        }
    }
}
