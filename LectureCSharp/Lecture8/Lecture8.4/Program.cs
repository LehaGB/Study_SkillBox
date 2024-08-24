using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lecture8._4
{
    /// <summary>
    /// 8.4 XML: Создание и чтение файлов
    /// </summary>
    class Program
    {
        // Метод сериализации Worker
        static void SerializeWorker(Worker ConcreteWorker, string path)
        {
            // Создаем сериализатор на основе указанного типа.
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            // Создаем поток для сохранения данных.
            Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // Запускаем процесс сериализации.
            xmlSerializer.Serialize(fStream, ConcreteWorker);

            // Закрываем поток.
            fStream.Close();
        }


        // Метод десиарилизации Worker
        static Worker DeserializeWorker(string path)
        {
            Worker tempWorker = new Worker();

            // Создаем сериализатор на основе указанного типа.
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            // Создаем поток для сохранения данных.
            Stream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            // Запускаем процесс десериализации.
            tempWorker = (Worker)xmlSerializer.Deserialize(fStream);

            // Закрываем поток.
            fStream.Close();

            return tempWorker;
        }


        // Метод сериализации List коллекция для сериализации путь к файлу
        static void SerializeWorkerList(List<Worker> ConcreteWorkerList, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));

            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            xmlSerializer.Serialize(stream, ConcreteWorkerList);

            stream.Close();
        }

        // Метод десериализации Worker.
        static List<Worker> DeserializeWorkerList(string path)
        {
            List<Worker> tempWorkerCol = new List<Worker>();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));

            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

            tempWorkerCol = xmlSerializer.Deserialize(stream) as List<Worker>;
            return tempWorkerCol;
        }

        static void Main(string[] args)
        {
            //Worker worker = new Worker("GEO", "Bill", "Gates", int.MaxValue, "Microsoft Corporation");
            //Console.WriteLine(worker.Print());

            //SerializeWorker(worker, "_bill.xml");

            //worker = DeserializeWorker("_satya.xml");
            //Console.WriteLine(worker.Print());

            List<Worker> list = new List<Worker>();

            for (int i = 0; i <= 5; i++)
            {
                list.Add(new Worker($"Имя_{i}", $"Фамилия_{i}", $"Должность_{i}", i * 1000, $"Департамент_{i}"));
            }

            SerializeWorkerList(list, "_listWorker.xml");

            list = DeserializeWorkerList("_listWorker.xml");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.LastName} {item.Position} {item.Salary} {item.Corpararion}");
            }
            Console.ReadLine();
        }
    }
    public struct Worker
    {
        // Должность
        public string Position { get; set; }

        // Зарплата
        public int Salary { get; set; }

        // Имя
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Corpararion { get; set; }

        // Вывод данных о сотруднике
        public string Print()
        {
            return $"Должность: {Position} Имя: {Name} Фамилия: {LastName}, Зарплата: {Salary} Место работы: " +
                $"{Corpararion}";
        }

        // Создание сотрудника
        public Worker(string Position, string Name, string LastName, int Salary, string Corpararion)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.Name = Name;
            this.LastName = LastName;
            this.Corpararion = Corpararion;
        }
    }
}
