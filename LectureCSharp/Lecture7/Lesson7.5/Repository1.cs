using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._5
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    struct Repository1
    {
        /// <summary>
        /// База данных сотрудников
        /// </summary>
        private Worker[] workers;

        // Идексаторное свойство
        public Worker this[int index]
        {
            get { return workers[index]; }
            set { workers[index] = value; }
        }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Args">Список сотрудников</param>
        public Repository1(params Worker[] Args)
        {
            workers = Args;
        }
    }
}
