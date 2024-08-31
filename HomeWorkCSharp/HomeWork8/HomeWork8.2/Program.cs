using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork8._2
{
    /*
     * Задание 2. Телефонная книга
     * Что нужно сделать:
     * 1.Пользователю итеративно предлагается вводить в программу номера телефонов и ФИО их владельцев. 
     * 2.В процессе ввода информация размещается в Dictionary, 
     *          где ключом является номер телефона, 
     *          а значением — ФИО владельца. Таким образом, у одного владельца может быть несколько номеров телефонов. 
     *          Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки. 
     *3.Далее программа предлагает найти владельца по введенному номеру телефона. 
     *          Пользователь вводит номер телефона и ему выдаётся ФИО владельца. 
     *          Если владельца по такому номеру телефона не зарегистрировано, 
     *          программа выводит на экран соответствующее сообщение.
     */
    class Program
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        string phoneNumber;
        private static string fullName;
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в телефонную книгу!\n");

            Program program = new Program();
            program.Menu();
        }
        private void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Добавить контакт");
                Console.WriteLine("2. Найти контакт");
                Console.WriteLine("3. Вывести все контакты");
                Console.WriteLine("4. Добавить второй номер");
                Console.WriteLine("5. Выйти");

                Console.Write("Введите номер действия: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        FindContact();
                        break;
                    case "3":
                        PrintAllContacts();
                        break;
                    case "4":
                        Console.Write("Введите имя владельца для добавления второго номера: ");
                        string name = Console.ReadLine();
                        AddSecondNumber(name);
                        break;
                    case "5":
                        Console.WriteLine("Выход их программы...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }


        /// <summary>
        /// Добавить контакт
        /// </summary>
        private void Add()
        {
            while (true)
            {
                Console.WriteLine("\nНажмите пробел, затем Enter для завершения ввода номера телефона");
                Console.Write("Введите номер телефона: ");

                phoneNumber = Console.ReadLine();
 
                if (phoneNumber != null && phoneNumber.EndsWith(" "))
                {
                    break;
                }
                if (!Regex.IsMatch(phoneNumber, @"^([\d.,-]+)$"))
                {
                    Console.WriteLine("\nНомер телефона должен содержать только цифры. Попробуйте снова.");
                    continue;
                }

            }
            while (true)
            {
                Console.Write("Введите ФИО: ");
                fullName = Console.ReadLine();
                if (dic.ContainsKey(phoneNumber))
                {
                    Console.WriteLine("Контакт с таким номером уже существует.");
                }
                if (string.IsNullOrEmpty(fullName))
                {
                    Console.WriteLine(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<");
                    Console.WriteLine("Строка не можеть быть пустой...\n");
                }
                else if (fullName.Any(char.IsDigit))
                {
                    Console.WriteLine(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<");
                    Console.WriteLine("Ф.И.О. не должны содержать цифры.\n");
                }
                else if (fullName.Any(char.IsLetter))
                {
                    break;
                }
            }
            dic.Add(phoneNumber, fullName);
        }


        /// <summary>
        /// Найти контакт
        /// </summary>
        public void FindContact()
        {
            Console.Write("Введите номер телефона для поиска: ");
            string phoneNumber = Console.ReadLine();
            phoneNumber = phoneNumber.TrimEnd();

            foreach (var key in dic.Keys)
            {
                string formattedKey = key.TrimEnd();
                if (formattedKey == phoneNumber)
                {
                    dic.TryGetValue(key, out string name);
                    Console.WriteLine($"Владелец: {name}");
                    return;
                }
            }
            Console.WriteLine("\nКонтакт с таким номером не найден.");
        }


        /// <summary>
        /// Вывести все контакты
        /// </summary>
        public void PrintAllContacts()
        {
            Console.WriteLine("Все контакты:");
            if (dic.Count == 0)
            {
                Console.WriteLine("Телефонная книга пуста.");
            }
            else
            {
                foreach (var contact in dic)
                {
                    Console.WriteLine($"Номер: {contact.Key}, Имя: {contact.Value}");
                }
            }
        }


        /// <summary>
        /// Добавить второй номер
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        public void AddSecondNumber(string name)
        {
            Console.WriteLine($"Добавление второго номера для {fullName}");

            while (true)
            {
                Console.Write("Введите номер: ");
                string phoneNumber = Console.ReadLine();

                if (phoneNumber != null && phoneNumber.EndsWith(" "))
                {
                    break;
                }
                if (!Regex.IsMatch(phoneNumber, @"^([\d.,-]+)$"))
                {
                    Console.WriteLine("Номер телефона должен содержать только цифры. Попробуйте снова.");
                    continue;
                }
                if (dic.ContainsKey(phoneNumber))
                {
                    string existingOwner = dic[phoneNumber];
                    if (existingOwner == name)
                    {
                        Console.WriteLine("Этот номер уже принадлежит данному владельцу.");
                    }
                    else
                    {
                        Console.WriteLine("Этот номер уже принадлежит другому владельцу.");
                    }
                }
                else
                {
                    dic.Add(phoneNumber, name);
                    Console.WriteLine("Номер добавлен.");
                    return;
                }
            }
        }

    }
}
