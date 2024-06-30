using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lecture6._4
{

    // 6.4 Работа с потоками: StreamWriter и StreamReader.

    class Example1
    {
        static void Main(string[] args)
        {
            // dirs хранит  все каталоги диска C
            var dirs = new DirectoryInfo(@"D:\").GetDirectories();


            // Создание потока для работы с файлом c_dirs.txt.
            using (StreamWriter sw = new StreamWriter("c_dirs.txt"))
            {
                foreach  (DirectoryInfo dir in dirs)
                {
                    sw.WriteLine(dir.FullName);   // Записать текущее имя каталога в файл.
                    Console.WriteLine($">> {dir.FullName}");
                }
            }


            // Пток для чтения.
            using(StreamReader streamReader = new StreamReader("c_dirs.txt"))
            {
                // Пока поток не закончен.
                while (!streamReader.EndOfStream)
                {
                    Console.WriteLine(streamReader.ReadLine());
                }
            }
            Console.ReadKey();
        }
    }
}
