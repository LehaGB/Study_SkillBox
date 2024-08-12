using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork7
{
    #region Справочник сотрудников

    //Справочник сотрудников
    struct Worker
    {
       

        // Индивидуальный номер
        private int id;

        public int Id 
        {
            get 
            {
                return this.id;
            }
            set { this.id = value; }
        }

        // Дата записи
        private DateTime dateAdded;

        public DateTime DateAdded 
        {
            get { return this.dateAdded; }
            set { this.dateAdded = value; }
        }

        // Фамили, имя, отчество
        private string fullName;

        public string FullName 
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        // Возраст
        private int age;

        public int Age 
        {
            get { return this.age; }
            set { this.age = value; }
        }

        // Рост
        private int height;

        public int Height 
        {
            get { return this.height; }
            set { this.height = value; }
        }

        // Дата рождения
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        // Место рождения
        private string placeOfBirth;

        public string PlaceOfBirth 
        {
            get { return this.placeOfBirth; }
            set { this.placeOfBirth = value; }
        }

        ////Вывод данных о сотркуднике
        //public override string ToString()
        //{
        //    return $"ID: {Id}\n" +
        //           $"Дата добавления: {DateAdded:yyyy-MM-dd HH:mm:ss}\n" +
        //           $"ФИО: {FullName}\n" +
        //           $"Возраст: {Age}\n" +
        //           $"Рост: {Height}\n" +
        //           $"Дата рождения: {DateOfBirth:yyyy-MM-dd}\n" +
        //           $"Место рождения: {PlaceOfBirth}\n";
        //}

        //Вывод данных о сотркуднике
        public string Print()
        {
            return $"{Id} {DateAdded} {FullName} {Age} {Height} {DateOfBirth} город {PlaceOfBirth}";
        }

        public Worker(int Id, DateTime DateAdded, string Fullname, int Age, int Height,
            DateTime DateOfBirth, string PlaceOfBirth)
        {
            this.id = Id;
            this.dateAdded = DateAdded;
            this.fullName = Fullname;
            this.age = Age;
            this.height = Height;
            this.dateOfBirth = DateOfBirth;
            this.placeOfBirth = PlaceOfBirth;
        }
    }
    #endregion

    class  Repository
    {

        private string file = @"D:\temp\MyTest.txt";

        List<Worker> listWorkers = new List<Worker>();

        // Массив для хранения записей о работниках
        private Worker[] workers;

        // Счетчик текущего количества работников в массиве
        private int workerCount;

        public Repository()
        {
            workers = GetAllWorkers(file);
            workerCount = workers.Length;
        }

        #region Создание файла
        public void CreateFile(string file)
        {
            //Создаем файл.
            FileStream fileStream = File.Create(file);
            fileStream.Close();
        }
        #endregion


        #region Чтение из файла
        public Worker[] GetAllWorkers(string file)
        {
            Program program = new Program();

            // Проверка существования файла
            if (!File.Exists(file))
            {
                Console.WriteLine("Файла не существует...");
                Console.WriteLine("Давайте создадим его");
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadLine();

                CreateFile(file);

                // Если файла нет, вызываем главное меню
                program.MainMenu(file);
                return new Worker[0];
            }

            List<Worker> loadedWorkers = new List<Worker>();

            // Чтение данных из файла
            string[] lines = File.ReadAllLines(file);

            // Чтение данных из файла
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');

                if (parts.Length == 7 && int.TryParse(parts[0], out int id))
                {

                    // Проверяем на дубликат ID:
                    if (loadedWorkers.Any(w => w.Id == id))
                    {
                        Console.WriteLine($"Ошибка: дубликат ID в строке {i + 1}");
                        Console.WriteLine("Удалите дублирующие ID работника....");
                        Console.WriteLine("Нажмите Enter для продолжения....");
                        Console.ReadLine();

                        DeleteRecord();

                        return new Worker[0];
                    }

                    Worker worker = new Worker
                    {
                        Id = id,
                        DateAdded = DateTime.Parse(parts[1]),
                        FullName = parts[2],
                        Age = int.Parse(parts[3]),
                        Height = int.Parse(parts[4]),
                        DateOfBirth = DateTime.Parse(parts[5]),
                        PlaceOfBirth = parts[6]
                    };
                    // Добавляем работника в список
                    loadedWorkers.Add(worker);
                }
            }
            // Обновляем workerCount:
            workerCount = loadedWorkers.Count;

            // Обновляем global список workers
            this.workers = loadedWorkers.ToArray();

            return workers;
        }
        #endregion


        #region Создать или добавить запись сотрудника 
        public  void AddingData(string file)
        {
            int id = 0;
            DateTime dateAdded = DateTime.Now;
            string fullName = string.Empty;
            int age = 0;
            int height = 0;
            DateTime dateOfBirth = DateTime.MinValue;
            string placeOfBirth = string.Empty;

            //  Считываем  данные  из  файла  одного  раза
            Worker[] workers = GetAllWorkers(file); 

            Console.WriteLine("\nВведите информацию о работнике:");

            //  Цикл, который повторяется, пока не будет введен уникальный  ID
            try
            {
                while (true)
                {
                    Console.Write("Введите ID: ");
                    id = int.Parse(Console.ReadLine());

                    //  Проверка  на  существование  ID  в  списке  workers
                    if (!workers.Any(w => w.Id == id))
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
                dateAdded = DateTime.Now;

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

                // Добавление новой записи в массив
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

                // Добавляем работника в массив workers
                workers = workers.Append(worker).ToArray();

                //  Обновляем  global  список  workers  после  добавления  записи:
                this.workers = workers;

                // Обновляем workerCount
                workerCount = workers.Length;
            }
            catch
            {
                Console.WriteLine(">>>>Некорретный ввод, пожалуйста, будте внимательны при вводе<<<<");
                Console.WriteLine("Перезапускаю меню....");
                Thread.Sleep(5000);
                Console.WriteLine("Нажмитет Enter......");             
                Console.ReadLine();
                return;
            }
            //  Сохраняем  данные  в  файл:
            SaveData(file);
        }
        #endregion


        #region Сохраниение записи
        private void SaveData(string file)
        {
            List<string> lines = new List<string>();

            using (StreamWriter writer = new StreamWriter(file, false))
            {
                foreach (var worker in workers)
                {
                    string line = $"{worker.Id};{worker.DateAdded};{worker.FullName};" +
                        $"{worker.Age};{worker.Height};{worker.DateOfBirth};{worker.PlaceOfBirth}";

                    Console.WriteLine($"\nЗаписываем строку: {line}");
                    writer.WriteLine(line);
                }
                // Выводим путь к файлу перед записью
                Console.WriteLine("\nСохраняем в файл: " + file);
                writer.Close();
                //  Обновляем  global  список  workers  после  записи  данных
                workers = GetAllWorkers(file);
            }
            Thread.Sleep(2000);
            // Записываем данные
            Console.WriteLine("\nДанные записаны в файл!");
            Console.WriteLine("\nЗагружаем меню....");
            Thread.Sleep(2000);
        }
        #endregion


        #region Посмотреть все записи 
        public void PrintWorker(string file)
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("Файл не существует или пустой... ");
                Console.WriteLine("Давайте сначала создадим запись, выберете нужный пнкт...");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            else if (workers.Length == 0)
            {
                Console.WriteLine("Файл пустой....");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            else
            {
                this.listWorkers = GetAllWorkers(file).ToList();
                foreach (var worker in listWorkers)
                {
                    Console.WriteLine($"{worker.Id} {worker.FullName} {worker.DateAdded} {worker.Age} " +
                        $"{worker.Height} {worker.DateOfBirth:dd.MM.yyyy} {worker.PlaceOfBirth}");
                };
            }

        }
        #endregion


        #region Просмотр работника по ID
        public void PrintWorkerById()
        {
            int id = 0;
            if (workers.Length == 0)
            {
                Console.WriteLine("Файл пустой, для начала добавте в него сотрудника, выбрав нужный" +
                    " подпункт в меню...");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            while (true)
            {
                Console.Write("Введите ID: ");
                if(int.TryParse(Console.ReadLine(), out id))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<");
                }
            }
           
            Worker worker = workers.FirstOrDefault(w => w.Id == id);
            if(worker.Id == id)
            {
                Console.WriteLine($"{worker.Id} {worker.FullName} {worker.DateAdded} {worker.Age} " +
                         $"{worker.Height} {worker.DateOfBirth:dd.MM.yyyy} {worker.PlaceOfBirth}");
            }
            else
            {
                // Работник с таким ID не найден
                Console.WriteLine("\nРаботник с таким ID не найден.");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
        }
        #endregion


        #region Метод для получения записи о работнике по ID
        public Worker GetWorkerById(int id)
        {
            // Чтение данных из файла
            Worker[] workers = GetAllWorkers(file);

            // Поиск записи по ID
            foreach (Worker worker in workers)
            {
                if (worker.Id == id)
                {
                    return worker;
                }
            }
            // Запись не найдена
            return new Worker();
        }
        #endregion


        #region Удаление работника по ID
        public void DeleteRecord()
        {
            int id = 0;
            Worker[] workers = GetAllWorkers(file);

            if (workers.Length == 0)
            {
                Console.WriteLine("Удалять нечего, так как файл пустой....");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            Console.Write("\nВведите ID записи для удаления: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    break;
                }
                else
                {
                    Console.Write(">>>>>Некорректный ввод, будте внимательней при вводе<<<<<\n");
                }
            }
            int indexToRemove = Array.IndexOf(workers, workers.FirstOrDefault(w => w.Id == id));
            if (indexToRemove != -1)
            {

                // Обновляем workerCount перед созданием tempWorkers
                workerCount--;

                this.workers = workers;

                Worker[] tempWorkers = new Worker[workerCount];
                for (int i = 0, j = 0; i < workers.Length; i++)
                {
                    if (i != indexToRemove)
                    {
                        tempWorkers[j] = workers[i];
                        j++;
                    }
                }
                workers = tempWorkers;
                File.WriteAllLines(file, workers.Select(w => $"{w.Id};" +
                $"{w.DateAdded};{w.FullName};{w.Age};{w.Height};{w.DateOfBirth};{w.PlaceOfBirth}"));

                this.workers = GetAllWorkers(file);

                Console.WriteLine("\nЗапись успешно удалена.");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine($"\nЗапись с ID {id} не найдена.");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
        }
        #endregion


        #region Удаление файла
        public void Remove(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
                Console.WriteLine("Файл успешно удален....");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();

                workers = new Worker[0];
                workerCount = 0;
                return;
            }
            else if (!File.Exists(file))
            {
                Console.WriteLine("Такого файла не существует...");
                Console.WriteLine("Начните с создания записи(рекомендуется)");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }

        }
        #endregion


        #region Сортировка по Фамилии
        public void SortByLastName()
        {

            // Проверяем, есть ли данные
            if (workers.Length == 0)
            {
                Console.WriteLine("Нет данных для сортировки.");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            if (workers.Length == 1)
            {
                Console.WriteLine("В файлк всего одна запись.");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            // Сортируем массив workers по фамилии (предполагаем, что фамилия разделена пробелом)
            this.workers = workers.OrderBy(w => w.FullName.Split(' ')[0]).ToArray();

            Console.WriteLine("Данные отсортированы по фамилии."); // Логирование

            // Сохраняем отсортированные данные в файл
            SaveData(file);
            Console.WriteLine("Данные записаны в файл!");
        }
        #endregion


        #region Сортировка по ID
        public void SortById()
        {

            // Проверяем, есть ли данные
            if (workers.Length == 0)
            {
                Console.WriteLine("Сортировать нечего, так как файл пустой....");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            if (workers.Length == 1)
            {
                Console.WriteLine("В файле всего онда запись....");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            else
            {
                // Сортируем массив workers по фамилии (предполагаем, что фамилия разделена пробелом)
                this.workers = workers.OrderBy(w => w.Id).ToArray();
            }
            // Сохраняем отсортированные данные в файл
            SaveData(file);
        }
        #endregion


        #region Метод сортировки по датам записи
        public void SortWorkersByDateAdded()
        {
            if (workers.Length == 0)
            {
                Console.WriteLine("Сортировать нечего, так как файл пустой....");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            if (workers.Length == 1)
            {
                Console.WriteLine("В файле всего одна запись, сортировка бесмысленна....");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            else
            {
                // Сортировка по возрастанию
                workers = workers.OrderBy(worker => worker.DateAdded).ToArray();
            }           
            SaveData(file); 
            Console.WriteLine("Работники отсортированы по дате добавления и сохранены в файл.");
        }
        #endregion


        #region Метод для получения записей в выбранном диапазоне дат
        public void GetWorkersByDateRange()
        {
            if (workers.Length == 0)
            {
                Console.WriteLine("Мы не можем получить записи в выбранном " +
                    "диапазоне дат, так как файл пустой....");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }
            if (workers.Length == 1)
            {
                Console.WriteLine("В файле всего одна запись");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
                return;
            }

            // Получаем начальную и конечную даты от пользователя
            Console.Write("Введите начальную дату (гггг-мм-дд): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите конечную дату (гггг-мм-дд): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            // Прочитать данные из файла в массив объектов Worker
            Worker[] allWorkers = GetAllWorkers(file);

            // Фильтровать массив по дате добавления (DateAdded) и сортировать по возрастанию
            Worker[] filteredWorkers = allWorkers
                .Where(worker => worker.DateAdded >= startDate && worker.DateAdded <= endDate)
                .OrderBy(worker => worker.DateAdded) // Сортировка по возрастанию
                .ToArray();

            // Выводим отфильтрованные данные в консоль
            Console.WriteLine("Отфильтрованные работники:");
            foreach (var worker in filteredWorkers)
            {
                Console.WriteLine($"ID: {worker.Id} Имя: {worker.FullName} Дата добавления: {worker.DateAdded}");
            }
        }
        #endregion
    }


    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            string file = @"D:\temp\MyTest.txt";
            program.MainMenu(file);
            
            Console.ReadKey();
        }

        #region Главное меню
        public void MainMenu(string file)
        {
            Repository rep = new Repository();
            Console.WriteLine("\nИз главного меню выбирите подпункт, какую работу вы бы хотели провести с файлом");
            Console.WriteLine("Загружаем меню....");
            Thread.Sleep(1000);
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Просмотреть все записи");
                Console.WriteLine("2. Просмотреть одну запись");
                Console.WriteLine("3. Создать или добавить запись");
                Console.WriteLine("4. Удалить запись");
                Console.WriteLine("5. Сортировка по датам");
                Console.WriteLine("6. Сортировка по фамилии");
                Console.WriteLine("7. Сортировка по ID");
                Console.WriteLine("8. Получение записей в выбранном диапазоне дат");
                Console.WriteLine("9. Удалить файл");
                Console.WriteLine("10. Выход из программы");

                Console.Write("\nВведите номер операции: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        rep.PrintWorker(file);
                        break;
                    case "2":
                        rep.PrintWorkerById();
                        break;
                    case "3":
                        rep.AddingData(file);
                        break;
                    case "4":
                        rep.DeleteRecord();
                        break;
                    case "5":
                        rep.SortWorkersByDateAdded();
                        break;
                    case "6":
                        rep.SortByLastName();
                        break;
                    case "7":
                        rep.SortById();
                        break;
                    case "8":
                        rep.GetWorkersByDateRange();
                        break;
                    case "9":
                        rep.Remove(file);
                        break;
                    case "10":
                        Console.WriteLine("Выход из программы.....");
                        Console.WriteLine("Нажмите Enter.....");
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод.");
                        break;
                }
            }
        }
        #endregion
    }
}
