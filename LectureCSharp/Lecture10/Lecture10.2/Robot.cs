using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._2
{
    class Robot
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Nickname">Название</param>
        /// <param name="Dislocation">Место дислокации</param>
        public Robot(string Nickname, string Dislocation)
        {
            this._Nickname = Nickname;
            this._Dislocation = Dislocation;
        }

        private string _Dislocation; // Дислокация


        /// <summary>
        /// Дислокация
        /// </summary>
        public string Dislocation 
        { 
            get { return this._Dislocation; } 
        }


        /// <summary>
        /// Кличка
        /// </summary>
        public string _Nickname { get; set; }
    }
}
