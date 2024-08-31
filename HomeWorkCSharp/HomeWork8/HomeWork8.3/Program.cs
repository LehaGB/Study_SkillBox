using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork8._3
{
    /// <summary>
    /// Задание 3. Проверка повторов
    /// Пользователь вводит число. 
    /// Число сохраняется в HashSet коллекцию. 
    /// Если такое число уже присутствует в коллекции, 
    /// то пользователю на экран выводится сообщение, 
    /// что число уже вводилось ранее. Если числа нет, то появляется сообщение о том, 
    /// что число успешно сохранено. 
    /// </summary>
    class Program
    {
        HashSet<int> hashSet = new HashSet<int>();

        private int num;

        private bool flag = true;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Menu();
        }


        /// <summary>
        /// Добавляем число в коллекцию
        /// </summary>
        private void ADdHashSetNumber()
        {
            bool n;
            while (true)
            {
                Console.Write("\nВведите число: ");
                
                if (n = int.TryParse(Console.ReadLine(), out num))
                {
                    if (CheckingNumbers())
                    {
                        hashSet.Add(num);
                        Console.WriteLine($"\nЧисло {num} успешно сохранено");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nТакое число уже вводилось ранее");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\nНекорректный ввод...");
                    break;
                }               
            }
        }


        /// <summary>
        /// Проверяем, есть ли такое число в HashSet
        /// </summary>
        /// <returns>Да или Нет</returns>
        private bool CheckingNumbers()
        {
            foreach (var item in hashSet)
            {
                if (hashSet.Contains(num))
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        }


        /// <summary>
        /// Удаление числа
        /// </summary>
        private void RemoveHashSetNumber()
        {
            Console.Write("\nВведите число, которе хотите удалить: ");
            int removeNumber = int.Parse(Console.ReadLine());
            if (hashSet.Contains(removeNumber))
            {
                hashSet.Remove(removeNumber);
                Console.WriteLine($"\nЧисло {removeNumber} успешно удалено!");
            }
            else
            {
                Console.WriteLine("\nТакого числа в коллекции нету...");
            }
        }

        /// <summary>
        /// Вывод на экран
        /// </summary>
        private void Print()
        {
            if(hashSet.Count == 0)
            {
                Console.WriteLine("\nСписок пуст");
            }
            else
            {
                Console.Write("\nСписок чисел: ");
                foreach (var item in hashSet)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Главное меню
        /// </summary>
        private void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nВыбирите действия");
                Console.WriteLine("1. Добавить число");
                Console.WriteLine("2. Удалить число");
                Console.WriteLine("3. Посмотреть все числа");
                Console.WriteLine("4. Выход\n");

                Console.Write("Введите номер действия: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ADdHashSetNumber();
                        break;
                    case "2":
                        RemoveHashSetNumber();
                        break;
                    case "3":
                        Print();
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("\nНекорректный ввод...");
                        break;
                }
            }
        }
    }
}
