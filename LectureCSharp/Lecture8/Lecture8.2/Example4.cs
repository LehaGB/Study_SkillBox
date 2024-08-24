using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8._2
{
    /// <summary>
    /// 8.2 Использование других коллекций: Dictionary, HashSet, Stack, Queue
    /// </summary>
    /// <param name="args">HashSet</param>
    class Example4
    {
        static void Main(string[] args)
        {

            // Add - Добавляет элемент в коллекцию.
            // Remove - Удаляет указанный элемент из коллекции.
            // Contains - Определяет, содержется ли указанный элемет в коллекции.
            // UnionWith - Изменяет текущий объект так, чтобы он содержал все элементы, имеющиеся в нем или 
            //              в указанной коллекции либо как в нем, так и в указанной коллекции.
            // IntersectWith -Изменяет текущий объект так, чтобы он содержал только элементы,
            //              имеются в этом объекте и указанной коллекции.
            // ExceptWith - Удаляет все элемнты в указаной коллекции из текущего объекта.
            // IsSubsetOf - Определяет, является ли объект подмножеством указанной коллкции.
            // IsSupersetOf - Определяет, является ли объект супермножеством указанной коллкции.
            // IsProperSubsetOf - Определяет, является ли объект строгим подмножеством указанной коллкции.
            // IsProperSupersetOf - Определяет, является ли объект строгим супермножеством указанной коллкции.

            HashSet<int> hashSet = new HashSet<int>( new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 5});

            Console.WriteLine("hashSet 1 : ");
            foreach (var item in hashSet)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n\nЭлемент '3' присутствует в hashSet: {hashSet.Contains(3)}");
            Console.WriteLine($"Элемент '20' присутствует в hashSet: {hashSet.Contains(20)}\n");

            Console.ReadLine();

            Console.WriteLine("hashSet 2 :");

            HashSet<int> hashSet2 = new HashSet<int> { 1, 3, 5, 7, 9, 11, 15 };
            foreach (var item2 in hashSet2)
            {
                Console.Write($"{item2} ");
            }

            hashSet.UnionWith(hashSet2);

            Console.WriteLine("\n\nhashSet после UnionWith");
            foreach (var item in hashSet)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();

            hashSet.ExceptWith(new int[] { 3, 5, 15 });

            Console.WriteLine("\n\nhashSet после hashSet.ExceptWith(new int[] { 3, 5, 15 })");

            foreach (var item in hashSet)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        }
    }
}
