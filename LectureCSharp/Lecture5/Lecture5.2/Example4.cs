using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lecture5._2
{
    // 5.2 Параметры методов, модификаторы параметров, возвращение значений.
    // Методы, с агруметами, что то делают и возвращают результат.
    class Example4
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetRandomString(5));
            Console.WriteLine(GetRandomString(10));
            Console.WriteLine(GetRandomString(15));


            Console.WriteLine(GetPath(true));     // С учетом имени файла.
            Console.WriteLine(GetPath(false));    // Без с учетом имени файла.
            Console.WriteLine();

            int[] col = { 1, 3, 5, 7, 9 };
            foreach (var e in col)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();

            int[] inverseCol = Inverse(col);
            foreach (var item in inverseCol)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Метод генерации строки из набора случайных символов.
        /// </summary>
        /// <param name="count">Количество символов</param>
        /// <returns>Случайная строка</returns>
        static string GetRandomString(int count)
        {
            return Guid.NewGuid().ToString().Substring(0, count);
        }

        /// <summary>
        /// Метод, возвращающий полный путь к текущему приложению.
        /// </summary>
        /// <param name="fileName">Проверяем true или false</param>
        /// <returns>Путь к приложению</returns>
        static string GetPath(bool fileName)
        {
            return fileName ? Application.ExecutablePath : Application.StartupPath;
        }

        
        /// <summary>
        /// Метод, возвращающий максимальное из двух чисел.
        /// </summary>
        /// <param name="valuue1">Целое число</param>
        /// <param name="valuue2">Целое число</param>
        /// <returns>Максимальное из двух чисел</returns>
        static int Max(int valuue1, int valuue2)
        {
            return valuue1 > valuue2 ? valuue1 : valuue2;
        }

        /// <summary>
        /// Метод, принимающий массив целых чисел и возвращает массив с противоположным знаком.
        /// </summary>
        /// <param name="args">Массив целых чисел</param>
        /// <returns>Массив целых чисел, с противоположным знаком</returns>
        static int[] Inverse(int[] args)
        {
            int[] t = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                t[i] = -args[i];
            }
            return t;
        }
    }
}
