using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8._6
{
    /// <summary>
    /// 8.5 JSON: Создание и чтение файлов
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.JsonListWorker();
        }

        #region Worker
        public void JsonWorkerCreate()
        {
            Worker worker = new Worker("Bill", "Geits", "CEO", int.MaxValue, "Microsoft Corporation");
            Console.WriteLine(worker.Print());

            string json = JsonConvert.SerializeObject(worker);

            File.WriteAllText("_bill.json", json);
            Console.WriteLine();

           // json = File.ReadAllText("_satya.json");

            worker = JsonConvert.DeserializeObject<Worker>(json);
            Console.WriteLine(worker.Print());
            Console.ReadLine();
        }
        #endregion


        public void JsonListWorker()
        {
            List<Worker> list = new List<Worker>();
            for (int i = 0; i <= 5; i++)
            {
                list.Add(new Worker($"Имя_{i}", $"Фамилия_{i}", $"Должность_{i}", i * 1000, $"Департамент_{i}"));
            }
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText("_listWorker.json", json);

            json = File.ReadAllText("_listWorker.json");
            list = JsonConvert.DeserializeObject<List<Worker>>(json);
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
            return $"Имя: {Name} Фамилия: {LastName}, Должность: {Position}, Зарплата: {Salary} Место работы: " +
                $"{Corpararion}";
        }

        // Создание сотрудника
        public Worker(string Name, string LastName, string Position, int Salary, string Corpararion)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.Name = Name;
            this.LastName = LastName;
            this.Corpararion = Corpararion;
        }
    }
}
