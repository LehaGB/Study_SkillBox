using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7._1
{
    public interface IFileRepository
    {
        List<Worker> LoadWorkersFromFile(string filePath);
        void SaveWorkersToFile(string filePath, List<Worker> workers);
    }
}
