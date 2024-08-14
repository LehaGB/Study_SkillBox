using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект FileRepository для работы с файлом
            IFileRepository fileRepository = new FileRepository();

            // Создаем объект WorkerManager для работы с данными о работниках
            WorkerManager workerManager = new WorkerManager(fileRepository);

            // Создаем объект MenuManager для работы с меню
            MenuManager menuManager = new MenuManager(workerManager);

            // Запускаем меню
            menuManager.ShowMenu();
        }
    }
    // Структура Worker
    #region Справочник сотрудников
    public struct Worker
    {
        // Индивидуальный номер
        public int Id { get; set; }

        // Дата записи
        public DateTime DateAdded { get; set; }

        // Фамили, имя, отчество
        public string FullName { get; set; }

        // Возраст
        public int Age { get; set; }

        // Рост
        public int Height { get; set; }
        
        // Дата рождения
        public DateTime DateOfBirth { get; set; }
        
        // Место рождения
        public string PlaceOfBirth { get; set; }

        ////Вывод данных о сотркуднике
        //public string Print()
        //{
        //    return $"{Id} {DateAdded} {FullName} {Age} {Height} {DateOfBirth} город {PlaceOfBirth}";
        //}

        public Worker(int id, DateTime dateAdded, string fullName, int age, int height, 
            DateTime dateOfBirth, string placeOfBirth)
        {
            this.Id = id;
            this.DateAdded = dateAdded;
            this.FullName = fullName;
            this.Age = age;
            this.Height = height;
            this.DateOfBirth = dateOfBirth;
            this.PlaceOfBirth = placeOfBirth;
        }
    }
    #endregion

}
