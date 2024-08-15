using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Просмотреть все записи");
                Console.WriteLine("2. Просмотреть одну запись");
                Console.WriteLine("3. Создать запись");
                Console.WriteLine("4. Удалить запись");
                Console.WriteLine("5. Загрузить записи в выбранном диапазоне дат");
                Console.WriteLine("6. Добавить запись");
                Console.WriteLine("7. Выход");

                Console.Write("Введите номер операции: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        repository.ViewAllRecords();
                        break;
                    case "2":
                        Console.Write("Введите ID записи: ");
                        int id = int.Parse(Console.ReadLine());
                        repository.ViewRecord(id);
                        break;
                    case "3":
                        repository.CreateRecord();
                        break;
                    case "4":
                        repository.DeleteRecord();
                        break;
                    case "5":
                        repository.LoadRecordsByDateRange();
                        break;
                    case "6":
                        repository.AddRecord();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод.");
                        break;
                }
            }
        }
    }

    // Структура для хранения информации о работнике
    public struct Worker
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                   $"Дата добавления: {DateAdded:yyyy-MM-dd HH:mm:ss}\n" +
                   $"ФИО: {FullName}\n" +
                   $"Возраст: {Age}\n" +
                   $"Рост: {Height}\n" +
                   $"Дата рождения: {DateOfBirth:yyyy-MM-dd}\n" +
                   $"Место рождения: {PlaceOfBirth}\n";
        }
    }
    // Класс репозитория для работы с записями о работника   
    public class Repository
    {
        private string filePath = "workers.txt"; // Имя файла для хранения данных
        private Worker[] workers; // Массив для хранения записей о работниках
        private int workerCount; // Счетчик текущего количества работников в массиве

        // Загрузка данных из файла
        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                workerCount = lines.Length / 7; // Определяем количество записей
                workers = new Worker[workerCount]; // Создаем массив нужного размера

                for (int i = 0; i < workerCount; i++)
                {
                    workers[i] = new Worker
                    {
                        Id = int.Parse(lines[i * 7]),
                        DateAdded = DateTime.Parse(lines[i * 7 + 1]),
                        FullName = lines[i * 7 + 2],
                        Age = int.Parse(lines[i * 7 + 3]),
                        Height = double.Parse(lines[i * 7 + 4]),
                        DateOfBirth = DateTime.Parse(lines[i * 7 + 5]),
                        PlaceOfBirth = lines[i * 7 + 6]
                    };
                }
            }
            else
            {
                workers = new Worker[0]; // Инициализируем пустой массив при первом запуске
                workerCount = 0;
            }
        }
        // Сохранение данных в файл
        private void SaveData()
        {
            List<string> lines = new List<string>();
            foreach (var worker in workers)
            {
                lines.AddRange(new string[]
                {
                worker.Id.ToString(),
                worker.DateAdded.ToString(),
                worker.FullName,
                worker.Age.ToString(),
                worker.Height.ToString(),
                worker.DateOfBirth.ToString(),
                worker.PlaceOfBirth
                });
            }

            File.WriteAllLines(filePath, lines);
        }
        // Просмотр всех записей
        public void ViewAllRecords()
        {
            LoadData();
            if (workerCount == 0)
            {
                Console.WriteLine("В репозитории нет записей.");
                return;
            }

            for (int i = 0; i < workerCount; i++)
            {
                Console.WriteLine(workers[i]);
                Console.WriteLine("-" + 20);
            }
        }
        // Просмотр одной записи по ID
        public void ViewRecord(int id)
        {
            LoadData();
            var worker = workers.FirstOrDefault(w => w.Id == id);
            if (worker.Id != 0)
        {
                Console.WriteLine(worker);
            }
            else
            {
                Console.WriteLine($"Запись с ID {id} не найдена.");
            }
        }
        // Создание новой записи
        public void CreateRecord()
        {
            LoadData();

            Console.Write("Введите ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Введите дату рождения (YYYY-MM-DD): ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите место рождения: ");
            string placeOfBirth = Console.ReadLine();

            // Добавление новой записи в массив
            Worker[] tempWorkers = new Worker[workerCount + 1];
            for (int i = 0; i < workerCount; i++)
            {
                tempWorkers[i] = workers[i];
            }
            tempWorkers[workerCount] = new Worker
            {
                Id = id,
                DateAdded = DateTime.Now,
                FullName = fullName,
                Age = age,
                Height = height,
                DateOfBirth = dateOfBirth,
                PlaceOfBirth = placeOfBirth
            };
            workers = tempWorkers; // Заменяем старый массив новым
            workerCount++;

            SaveData();
            Console.WriteLine("Запись успешно создана.");
        }

        // Удаление записи по ID
        public void DeleteRecord()
        {
            LoadData();

            Console.Write("Введите ID записи для удаления: ");
            int id = int.Parse(Console.ReadLine());

            int indexToRemove = Array.IndexOf(workers, workers.FirstOrDefault(w => w.Id == id));
            if (indexToRemove != -1)
            {
                Worker[] tempWorkers = new Worker[workerCount - 1];
                for (int i = 0, j = 0; i < workerCount; i++)
                {
                    if (i != indexToRemove)
                    {
                        tempWorkers[j] = workers[i];
                        j++;
                    }
                }
                workers = tempWorkers;
                workerCount--;
                SaveData();
                Console.WriteLine("Запись успешно удалена.");
            }
            else
            {
                Console.WriteLine($"Запись с ID {id} не найдена.");
            }
        }
        // Загрузка записей в выбранном диапазоне дат
        public void LoadRecordsByDateRange()
        {
            LoadData();

            Console.Write("Введите начальную дату (YYYY-MM-DD): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите конечную дату (YYYY-MM-DD): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            foreach (var worker in workers.Where(w => startDate <= w.DateAdded && w.DateAdded <= endDate))
            {
                Console.WriteLine(worker);
                Console.WriteLine("-" + 20);
            }
        }
        // Добавление записи 
        public void AddRecord()
        {
            LoadData(); // Загружаем данные из файла

            Console.Write("Введите ID: ");
            int id = int.Parse(Console.ReadLine());

            // Проверяем, не существует ли уже записи с таким ID
            if (workers.Any(w => w.Id == id))
            {
                Console.WriteLine($"Запись с ID {id} уже существует.");
                return;
            }

            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Введите дату рождения (YYYY-MM-DD): ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите место рождения: ");
            string placeOfBirth = Console.ReadLine();

            Worker newWorker = new Worker
            {
                Id = id,
                DateAdded = DateTime.Now,
                FullName = fullName,
                Age = age,
                Height = height,
                DateOfBirth = dateOfBirth,
                PlaceOfBirth = placeOfBirth
            };

            // Добавляем новую запись в массив
            Worker[] tempWorkers = new Worker[workerCount + 1];
            for (int i = 0; i < workerCount; i++)
            {
                tempWorkers[i] = workers[i];
            }
            tempWorkers[workerCount] = newWorker;
            workers = tempWorkers; // Заменяем старый массив новым
            workerCount++;

            SaveData(); // Сохраняем изменения в файл
            Console.WriteLine("Запись успешно добавлена.");
        }
    }
}



