using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture6._4
{

    // 6.4 Работа с потоками: StreamWriter и StreamReader.

    class Example4
    {
        static void Main(string[] args)
        {
            string[] names = { "Юлия", "Ирина", "Светлана", "Екатерина", "Алиса" };

            string path = @"BinaryNames.dat";

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                // Записываем в файл значение каждого поля структуры.
                foreach ( var name in names)
                {
                    writer.Write(name);
                }
            }
            Console.WriteLine($"Файл {path} успешно создан.Нажмите Enter для продолжения...\n");
            Console.ReadLine();

            using(BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                // пока не достигнут конец файла
                // считываем каждое значение из файла
                while(reader.PeekChar() > -1)
                {
                    string name = reader.ReadString();
                    Console.WriteLine(name);
                }
            }
            Console.ReadKey();
        }
    }
}
