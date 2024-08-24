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
    /// <param name="args">Queue</param>
    class Example2
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            // Enqueue - Добавляет объект в конец очереди.
            // Dequeue - Удаляет объект из наачала очереди и возвращает его.
            // Peek - Возвращает объект, находящийся в начале очереди и возвращает его, но не удаляет.
            // Count - Получает количество элементов, содержащийся в очереди.
            // Clear - Удаляет все объекты из очереди.

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(12);
            
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("============================");          

            Console.WriteLine($"queue.Dequeue = {queue.Dequeue()} - удаление "); // 1
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("============================");
            Console.WriteLine($"queue.Dequeue = {queue.Peek()} - возвращает, но не удаляет "); // 2
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
