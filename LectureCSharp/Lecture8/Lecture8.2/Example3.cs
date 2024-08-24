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
    /// <param name="args">Stack</param>
    class Example3
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            // Push - Вставляет объект как верхний элемете стека.
            // Pop - Удаляет и возвращает объект в верхней части стека.
            // Peek - Возвращает объект в верхней части стека без его удаления.
            // Count - Получает число элементов, содержащихся в стеке.
            // Clear - Удаляет все элемнты из стека.

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (var item in stack)
            {
                Console.Write($"{item} ");  // 5 4 3 2 1
            }
            Console.WriteLine("\n");

            Console.WriteLine($"stack.Pop = {stack.Pop()} - Удаление");  // 5
            foreach (var item in stack)
            {
                Console.Write($"{item} ");  // 4 3 2 1
            }
            Console.WriteLine("\n");

            Console.WriteLine($"stack.Pop = {stack.Peek()} - Возвращает, но не удаляет");  // 4
            foreach (var item in stack)
            {
                Console.Write($"{item} ");  // 4 3 2 1
            }
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
