using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork7._1
{
    // Класс для работы с меню
    class MenuManager
    {
        private WorkerManager workerManager;

        public MenuManager(WorkerManager workerManager)
        {
            this.workerManager = workerManager;
        }

        public void ShowMenu()
        {
            Console.WriteLine("\nИз главного меню выбирите подпункт, какую работу вы бы хотели провести с файлом");
            Console.WriteLine("Загружаем меню....");
            Thread.Sleep(1000);

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Просмотреть все записи");
                Console.WriteLine("2. Просмотреть запись по ID");
                Console.WriteLine("3. Создать или добавить запись");
                Console.WriteLine("4. Удалить работника по ID");
                Console.WriteLine("5. Сортировка по датам");
                Console.WriteLine("6. Сортировка по фамилии");
                Console.WriteLine("7. Сортировка по ID");
                Console.WriteLine("8. Получение записей в выбранном диапазоне дат");
                Console.WriteLine("9. Выход из программы");

                Console.Write("\nВведите номер операции: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        workerManager.PrintWorkers();
                        break;
                    case "2":
                        Console.Write("Введите ID: ");
                        int id;
                        if (int.TryParse(Console.ReadLine(), out id))
                        {
                            Worker worker = workerManager.GetWorkerById(id);
                            if (worker.Id != 0)
                            {
                                Console.WriteLine($"{worker.Id} {worker.FullName} {worker.DateAdded} {worker.Age} " +
                                     $"{worker.Height} {worker.DateOfBirth:dd.MM.yyyy} {worker.PlaceOfBirth}");
                            }
                            else
                            {
                                Console.WriteLine("Работник с таким ID не найден.");
                            }
                        }
                        else
                        {
                            Console.WriteLine(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<");
                        }
                        break;
                    case "3":
                        workerManager.AddWorker();
                        break;
                    case "4":
                        Console.Write("Введите ID записи для удаления: ");
                        int idToDelete;
                        if (int.TryParse(Console.ReadLine(), out idToDelete))
                        {
                            workerManager.DeleteWorker(idToDelete);
                        }
                        else
                        {
                            Console.WriteLine(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<");
                        }
                        break;
                    case "5":
                        workerManager.SortByDateAdded();
                        break;
                    case "6":
                        workerManager.SortByFullName();
                        break;
                    case "7":
                        workerManager.SortById();
                        break;
                    case "8":
                        Console.Write("Введите начальную дату (гггг-мм-дд): ");
                        DateTime startDate;
                        if (DateTime.TryParse(Console.ReadLine(), out startDate))
                        {
                            Console.Write("Введите конечную дату (гггг-мм-дд): ");
                            DateTime endDate;
                            if (DateTime.TryParse(Console.ReadLine(), out endDate))
                            {
                                List<Worker> filteredWorkers = workerManager.GetWorkersByDateRange(startDate, endDate);
                                if (filteredWorkers.Count == 0)
                                {
                                    Console.WriteLine("Записи в указанном диапазоне дат не найдены.");
                                }
                                else
                                {
                                    Console.WriteLine("Отфильтрованные работники:");
                                    foreach (var worker in filteredWorkers)
                                    {
                                        Console.WriteLine($"ID: {worker.Id} Имя: {worker.FullName} Дата добавления: {worker.DateAdded}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine(">>>>>Некорректный формат даты. Используйте YYYY-MM-DD<<<<<\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine(">>>>>Некорректный формат даты. Используйте YYYY-MM-DD<<<<<\n");
                        }
                        break;
                    case "9":
                        Console.WriteLine("Выход из программы.....");
                        Console.WriteLine("Нажмите Enter.....");
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод.");
                        break;
                }
            }
        }
    }
}
