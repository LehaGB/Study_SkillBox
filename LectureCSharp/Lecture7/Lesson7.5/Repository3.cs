using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._5
{
    struct Repository3
    {
        /// <summary>
        /// База данных сотрудников
        /// </summary>
        private Worker[] workers;

        // Идексаторное свойство
        public string this[int index]
        {
            get { return this.workers[index].Print(); }
        }


        public string this[string i]
        {
            get
            {
                switch (i)
                {
                    case "+": return "Плюс";
                    case "-": return "Минус";
                    case "*": return "Умножить";
                    default: return "что-то иное";
                }
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Args">Список сотрудников</param>
        public Repository3(params Worker[] Args)
        {
            workers = Args;
        }
    }
}
