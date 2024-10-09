using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._7
{
    // Ультра атака
    interface IRampage
    {
        // Количество зарядов.
        int Cherge { get; set; }


        // Логика перезарядки.
        void Recherge();


        /// <summary>
        /// Логика ультра атаки.
        /// </summary>
        /// <param name="Target">Цель для атаки</param>
        void UltraAttack(Hero Target);
    }
}
