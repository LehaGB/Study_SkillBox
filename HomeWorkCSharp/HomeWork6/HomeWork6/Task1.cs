using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Task1
    {
        /*
        Создайте справочник «Сотрудники».
        Разработайте для предполагаемой компании программу,
        которая будет добавлять записи новых сотрудников в файл.
        Файл должен содержать следующие данные:
        ID
        Дату и время добавления записи
        Ф. И. О.
        Возраст
        Рост
        Дату рождения
        Место рождения
         */

        static string file = "data.txt";
        static int n;

        static void Main(string[] args)
        {
            ReadWrite();
        }


        /// <summary>
        /// Добавление сотрудника в файл
        /// </summary>
        private static void AddingData()
        {
            bool appendExistingFile = true;
            using (StreamWriter streamWriter = new StreamWriter(file, appendExistingFile))
            {
                char key = '1';
                do
                {
                    string note = string.Empty;
                    Console.Write("\nВведите свой ID: ");
                    note += $"{Console.ReadLine()} ";

                    string data = DateTime.Now.ToShortDateString();
                    Console.WriteLine($"Дата записи: {data} ");
                    note += $"{data} ";

                    string now = DateTime.Now.ToShortTimeString();
                    Console.WriteLine($"Время записи: {now} ");
                    note += $"{now} ";

                    Console.Write("Введите Ф.И.О: ");
                    note += $"{Console.ReadLine()} ";

                    Console.Write("Скоько вам лет?: ");
                    note += $"{Console.ReadLine()} ";

                    Console.Write("Введите свой рост: ");
                    note += $"{Console.ReadLine()} ";

                    Console.Write("Введите дату рождения: ");
                    note += $"{Console.ReadLine()} ";

                    Console.Write("Введите место рождения: ");
                    note += $"город {Console.ReadLine()} ";

                    streamWriter.WriteLine(note);

                    Console.Write("\nВыход -> 0, Хотите продолжить -> 1, посмотреть информацию -> 2: ");

                    key = Console.ReadKey(true).KeyChar;

                } while (char.ToLower(key) == '1');
            }
        }


        /// <summary>
        /// Выводим информацию о сотрудниках с файла
        /// </summary>
        private static void ReadingData()
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("\nТакой файл не найден, давайте создадим его и добавим в него сотрудника");
                Console.WriteLine("Намите Enter для продолжения.....");
                Console.ReadLine();
                AddingData();
            }
            else if (File.Exists(file))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line;
                        Console.WriteLine();
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    Console.Write("\nВведите: 0 -> Выход, 1 -> добавить сотрудника, 2 -> чтение файла, 3 -> удаление: ");
                }
                catch (Exception)
                {
                    Console.Write("\nНажмите ещё раз 2, для вывода информации о сотрудниках: ");
                }
            }
        }

        /// <summary>
        /// Метод удаления файла
        /// </summary>
        private static void Remove()
        {
            File.Delete(file);
            Console.WriteLine("Файл успешно удален....");
            Console.Write("\nВведите: 0 -> Выход, 1 -> добавить сотрудника, 2 -> чтение файла: ");
        }


        /// <summary>
        /// Метод информации 
        /// </summary>
        private static void ReadWrite()
        {
            Console.Write("Введите: 0 -> Выход, 1 -> добавить сотрудника, 2 -> чтение файла, 3 -> удаление: ");

            try
            {
                while (true)
                {
                    n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 0:
                            Console.WriteLine("\nВыход из программы:");
                            Console.WriteLine("Нажмите любую клавишу.....");
                            break;
                        case 1:
                            AddingData();
                            break;
                        case 2:
                            ReadingData();
                            break;
                        case 3:
                            Remove();
                            break;
                        default:
                            Console.WriteLine("\nВы ввели некорректно, программа будет закрыта");
                            Console.WriteLine("Нажмите Enter....");
                            break;
                    }
                }
            }
            catch
            {
                Thread.Sleep(1500);
                return;
            }
        }
    }
}
