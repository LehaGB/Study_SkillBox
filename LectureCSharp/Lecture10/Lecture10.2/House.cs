using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10._2
{
    class House
    {
        private int _floorCount;  // Поле - кол-вщ этажей.
        private int _flatCount;  // Поле - кол-вщ квартир.
        private string _address;  // Поле - адрес.


        // Создание дома.
        public House(int floorCount, int flatCount, string address)
        {
            this._floorCount = floorCount;
            this._flatCount = flatCount;
            this._address = address;
        }

        // Кол-во этажей.
        public int FloorCount
        {
            get { return this._floorCount; }
        }


        // Кол-во квартир.
        public int FlatCount
        {
            get { return this._flatCount; }
        }


        // Адрес.
        public string Address
        {
            get { return this._address; }
        }
    }
}
