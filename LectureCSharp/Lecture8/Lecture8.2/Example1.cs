using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8._2
{
    class Example1
    {
        /// <summary>
        /// 8.2 Использование других коллекций: Dictionary, HashSet, Stack, Queue
        /// </summary>
        /// <param name="args">Dictionary</param>
        static void Main(string[] args)
        {
            #region Dictionary
            Dictionary<string, string> pairs = new Dictionary<string, string>();

            //        ключ, значение
            // Add - добавляет указанные клю и значение в словарь.
            // Count - Возвращает число пар ключ-значение. содержащихся в словаре.
            // Clear - Удаляет все ключи и значения из словаря.
            // [] - Возвращает или задает значение, связанное с указаным ключом.
            // ContainsKey - Определяет, содержется ли указанный ключ в словаре.
            // Remove - Удаляет значение, с указанным ключом из словаря.
            // Keys - Возвращает коллекцию, содержащую ключи из словаря.
            // Values - Возвращает коллекцию, содержащую значения из словаря.

            pairs.Add("Учитель", "Teacher");
            pairs.Add("Проверка", "Check");
            pairs.Add("Компьютер", "Computer");
            pairs.Add("Автомобиль", "Car");

            Console.WriteLine("\npairs");
            foreach (KeyValuePair<string, string> e in pairs)
            {
                Console.Write($"{e} ");  // Вывод всех пар.
            }

            Console.WriteLine($"\n\npairs[\"Учитель\"] = {pairs["Учитель"]}");  // Teacher

            Console.WriteLine("\npairs.Keys - Все ключи словаря");
            foreach (var item in pairs.Keys)
            {
                Console.Write($"{item} ");  // Вывод всех ключей.
            }

            Console.WriteLine();

            Console.WriteLine("\npairs.Values - Все значения словаря");
            foreach (var item in pairs.Values)
            {
                Console.WriteLine($"{item} ");  // Вывод всех значений.
            }

            Console.WriteLine();

            Console.WriteLine("\nУдаление\"Учитель\"");
            pairs.Remove("Учитель");

            Console.WriteLine();

            Console.WriteLine("\npairs");
            foreach (KeyValuePair<string, string> e in pairs)
            {
                Console.Write($"{e}");
            }

            Console.WriteLine("\n");

            Console.Write($"Кол-во элементов в словаре: {pairs.Count} ");  // 3

            Console.WriteLine("\n");

            // Очистка коллекции
            pairs.Clear();


            Console.WriteLine("pairs.Clear() - выполнен успешно!");

            Console.WriteLine("\n");

            Console.Write($"Кол-во элементов в словаре: {pairs.Count} ");  // 0 

            Console.ReadLine();

            #endregion
        }
    }
}
