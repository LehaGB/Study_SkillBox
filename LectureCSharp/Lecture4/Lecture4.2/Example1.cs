using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4._2
{

    // 4.2 Основные методы работы с одномерными массивами.

    class Example1
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 5, 2, 5, 4, 6, 5, 7, 6, 8, 6, 9, 5, 1 };

            Console.Write("Исходный массив: ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            //Получает общее число элементов во всех измерениях массива.
            Console.WriteLine($"data.Length = {data.Length}");

            //Выполняет поиск указаного объекта внутри всего обномерного массива и возвращает
            // его индекс первого вхождения.
            int result = Array.IndexOf(data, 5);
            Console.WriteLine($"Array.IndexOf(data, 5) = {result}");

            result = Array.LastIndexOf(data, 5);  //Возвращает последнее вхождение элемента в массиве.
            Console.WriteLine($"Array.LastIndexOf(data, 5) = {result}");

            int rank = data.Rank;  // Получает ранг (число измерений) массива.
            Console.WriteLine($"data.Rank = {rank}");

            Array.Sort(data);  //Сортирует элементы во всем массиве.

            Console.Write("\nМассив после применения Array.Sort(data): ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            Array.Reverse(data);
            Console.Write("\nМассив после применения Array.Reverse(data): ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            //Задает для диапазона элементов в массиве значение, предусмотренное по умолчанию.
            Array.Clear(data, 7, 3);
            Console.Write("\nМассив после применения Array.Clear(data, 7, 3): ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            int[] copyData = new int[20];

            //Копирует диапазон элементов массива (data), начиная с заданного индекса 2
            //источника, и вставляет его в другой массив (copyData), начиная с заданного 
            //индекса (10) назанчения.5 - количество копируемых эелементов
            Array.ConstrainedCopy(data, 2, copyData, 10, 5);

            Console.WriteLine("Массив copyData: ");
            for (int i = 0; i < copyData.Length; i++)
            {
                Console.Write($"{copyData[i]} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
