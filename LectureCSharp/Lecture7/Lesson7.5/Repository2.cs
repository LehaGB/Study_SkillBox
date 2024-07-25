using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._5
{
    struct Repository2
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


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Args">Список сотрудников</param>
        public Repository2(params Worker[] Args)
        {
            workers = Args;
        }
    }
}
