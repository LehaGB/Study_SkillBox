using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._1
{
    /// <summary>
    /// Задание 1. Работа с листом
    /// Что нужно сделать
    /// Создайте лист целых чисел.
    //  Заполните лист 100 случайными числами в диапазоне от 0 до 100. 
    /// Выведите коллекцию чисел на экран.
    /// Удалите из листа числа, которые больше 25, но меньше 50. 
    /// Снова выведите числа на экран.
    /// </summary>
    class Program
    {
        List<int> listNumber = new List<int>();
        private int n = 100;
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Список рандомных чисел: ");
            Program pr = new Program();
            pr.Print();
        }


        /// <summary>
        /// Заполняем list случайными числами
        /// </summary>
        /// <returns>Список из 100 рандомных чисел</returns>
        private List<int> FillingListWithNumber()
        {       
            for(int i = 0; i < n; i++)
            {
                listNumber.Add(rnd.Next(0, 100));
            }
            return listNumber;
        }


        /// <summary>
        /// Сортируем список указаному условию
        /// </summary>
        /// <param name="minN">условие задачи, должно быть больше 25</param>
        /// <param name="maxN">условие задачи, должно быть меньше 50</param>
        /// <returns>Обновленный список</returns>
        private List<int> RemoveNumberList(int minN, int maxN)
        {
            Console.WriteLine("Обновленный список в диапозоне больше 25 и меньше 50: ");
            List<int> newListNumber = new List<int>();
            listNumber = FillingListWithNumber();
            for (int i = 0; i < n; i++)
            {
                if(listNumber[i] > minN && listNumber[i] < maxN)
                {
                    newListNumber.Add(listNumber[i]);
                }
                else
                {
                    continue;
                }
            }
            return newListNumber;
        }


        /// <summary>
        /// Выводим на экран
        /// </summary>
        private void Print()
        {
            listNumber = FillingListWithNumber();

            foreach (var item in listNumber)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n\nНажмите Enter для продолжения....");
            Console.ReadLine();

            listNumber = RemoveNumberList(25, 50);
            foreach (var item in listNumber)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        }
    }
}
