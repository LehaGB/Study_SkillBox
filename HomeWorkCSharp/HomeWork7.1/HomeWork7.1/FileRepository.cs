using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7._1
{
    public class FileRepository : IFileRepository
    {
        public List<Worker> LoadWorkersFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<Worker>();
            }

            List<Worker> workers = new List<Worker>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 7 && int.TryParse(parts[0], out int id))
                {
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
                    workers.Add(worker);
                }
            }
            return workers;
        }
        public void SaveWorkersToFile(string filePath, List<Worker> workers)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var worker in workers)
                {
                    string line = $"{worker.Id};{worker.DateAdded};{worker.FullName};" +
                        $"{worker.Age};{worker.Height};{worker.DateOfBirth:yyyy-MM-dd};{worker.PlaceOfBirth}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}
