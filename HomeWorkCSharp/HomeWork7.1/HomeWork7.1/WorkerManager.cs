using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7._1
{
    // Класс для работы с данными о работниках
    public class WorkerManager
    {
        private string filePath = @"D:\temp\MyTest.txt";
        private IFileRepository fileRepository;
        private List<Worker> workers;

        public WorkerManager(IFileRepository fileRepository)
        {
            this.fileRepository = fileRepository;
            workers = fileRepository.LoadWorkersFromFile(filePath);
        }


        // Добавление нового работника
        public void AddWorker()
        {
            Console.WriteLine("\nВведите информацию о работнике:");

            int id = GetUniqueID();
            DateTime dateAdded = DateTime.Now;
            string fullName = GetValidFullName();
            int age = GetValidAge();
            int height = GetValidHeight();
            DateTime dateOfBirth = GetValidDateOfBirth();
            string placeOfBirth = GetValidPlaceOfBirth();

            var worker = new Worker
            {
                Id = id,
                DateAdded = dateAdded,
                FullName = fullName,
                Age = age,
                Height = height,
                DateOfBirth = dateOfBirth,
                PlaceOfBirth = placeOfBirth
            };

            workers.Add(worker);
            fileRepository.SaveWorkersToFile(filePath, workers);
            Console.WriteLine("\nЗапись успешно добавлена!");
        }


        // Удаление работника по ID
        public void DeleteWorker(int id)
        {
            Worker workerToDelete = workers.FirstOrDefault(w => w.Id == id);
            if (workers.Any(w => w.Id == id))
            {
                // Удаляем работника с помощью .RemoveAll()
                workers.RemoveAll(w => w.Id == id);


                fileRepository.SaveWorkersToFile(filePath, workers);
                Console.WriteLine("\nЗапись успешно удалена.");
            }
            else
            {
                Console.WriteLine($"\nЗапись с ID {id} не найдена.");
            }
        }

        // Поиск работника по ID
        public Worker GetWorkerById(int id)
        {
            return workers.FirstOrDefault(w => w.Id == id);
        }


        // Вывод всех работников
        public void PrintWorkers()
        {
            if (workers.Count == 0)
            {
                Console.WriteLine("В файле нет записей.");
                return;
            }

            Console.WriteLine("Все работники:");
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Id} {worker.FullName} {worker.DateAdded} {worker.Age} " +
                    $"{worker.Height} {worker.DateOfBirth:dd.MM.yyyy} {worker.PlaceOfBirth}");
            }
        }

        // Сортировка по ID
        public void SortById()
        {
            workers = workers.OrderBy(w => w.Id).ToList();
            fileRepository.SaveWorkersToFile(filePath, workers);
            Console.WriteLine("Работники отсортированы по ID и сохранены в файл.");
        }

        // Сортировка по дате добавления
        public void SortByDateAdded()
        {
            workers = workers.OrderBy(w => w.DateAdded).ToList();
            fileRepository.SaveWorkersToFile(filePath, workers);
            Console.WriteLine("Работники отсортированы по дате добавления и сохранены в файл.");
        }

        // Сортировка по фамилии
        public void SortByFullName()
        {
            workers = workers.OrderBy(w => w.FullName).ToList();
            fileRepository.SaveWorkersToFile(filePath, workers);
            Console.WriteLine("Работники отсортированы по фамилии и сохранены в файл.");
        }

        // Получение записей в выбранном диапазоне дат
        public List<Worker> GetWorkersByDateRange(DateTime startDate, DateTime endDate)
        {
            return workers.Where(w => w.DateAdded >= startDate && w.DateAdded <= endDate)
                .OrderBy(w => w.DateAdded)
                .ToList();
        }


        // Вспомогательные методы для ввода данных
        private int GetUniqueID()
        {
            int id;
            while (true)
            {
                Console.Write("Введите ID: ");
                if (int.TryParse(Console.ReadLine(), out id) && !workers.Any(w => w.Id == id))
                {
                    Console.WriteLine("С таким ID записи нету, можно записывать....");
                    Console.WriteLine("Нажмитет Enter......");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Работник с таким ID уже существует. Попробуйте другой Id.");
                    Console.WriteLine("Нажмитет Enter......");
                    Console.ReadLine();
                }
            }
            return id;
        }

        private string GetValidFullName()
        {
            string fullName;
            while (true)
            {
                Console.Write("Введите Ф.И.О: ");
                fullName = Console.ReadLine();

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
                else
                {
                    Console.WriteLine(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<");
                    Console.WriteLine("Ф.И.О. должны содержать хотя бы одну букву.\n");
                }
            }
            return fullName;
        }

        private int GetValidAge()
        {
            int age;
            while (true)
            {
                Console.Write("\nВведите свой возраст (целое число): ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break;
                }
                else
                {
                    Console.Write(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<\n");
                }
            }
            return age;
        }

        private int GetValidHeight()
        {
            int height;
            while (true)
            {
                Console.Write("\nВведите свой рост(см): ");
                if (int.TryParse(Console.ReadLine(), out height))
                {
                    break;
                }
                else
                {
                    Console.Write(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<\n");
                }
            }
            return height;
        }

        private DateTime GetValidDateOfBirth()
        {
            DateTime dateOfBirth;
            while (true)
            {
                Console.Write("\nВведите дату рождения (YYYY-MM-DD): ");
                if (DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(">>>>>Некорректный формат даты рождения. Используйте YYYY-MM-DD<<<<<\n");
                }
            }
            return dateOfBirth;
        }

        private string GetValidPlaceOfBirth()
        {
            string placeOfBirth;
            while (true)
            {
                Console.Write("\nВведите место рождения: ");
                placeOfBirth = Console.ReadLine();

                if (string.IsNullOrEmpty(placeOfBirth))
                {
                    Console.WriteLine(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<");
                    Console.WriteLine("Строка не можеть быть пустой...\n");
                }
                else if (placeOfBirth.Any(char.IsDigit))
                {
                    Console.WriteLine(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<\n");
                }
                else if (placeOfBirth.Any(char.IsLetter))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<");
                    Console.WriteLine("Название города не содержат цифры.\n");
                }
            }
            return placeOfBirth;
        }
    }
}

