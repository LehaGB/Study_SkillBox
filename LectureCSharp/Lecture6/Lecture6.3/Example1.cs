using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6._3
{

    // 6.3 Работа с файлами: класс File, FileInfo, Directory, DirectoryInfo.

    class Example1
    {
        static void Main(string[] args)
        {
            // using.System.IO;
            // Представляет статические методы для создания, копирования, удаления, пермещения и открытия.

            // Открывает файл, считывает все строки файла, затем закрывает его.
            Console.WriteLine("Пример 1: Использование переменной, открыть, считать, закрыть");
            string text = File.ReadAllText(@"D:\data2.txt");
            Console.WriteLine($"{text}");
            Console.WriteLine("===========================");


            // Открывает файл, считывает все строки файла, затем закрывает его.
            Console.WriteLine("Пример 2: Использование массива, открыть, считать, закрыть");
            string[] lines = File.ReadAllLines(@"D:\data2.txt");
            foreach (var line in lines)
            {
                Console.WriteLine($">>{line}<<");
            }
            Console.WriteLine("===========================");


            // Создает новый файл, записывает в него указанный массив строк и затем закрывает его.
            Console.WriteLine("Пример 3: Создание и записи файла");
            lines = new string[] { "один", "два", "три" };
            File.WriteAllLines(@"D:\data2.txt", lines);
            foreach (var e in lines)
            {
                Console.WriteLine($">>{e}<<");
            }
            Console.WriteLine("===========================");
            

            // Создает новый файл, записывает в негоуказанную строку, затем закрывает его
            // если целевой файл уже существует, то он будет переопределен.
            Console.WriteLine("Пример 4: Создание и записи файла");
            text = "Пример текста";
            File.WriteAllText(@"D:\data3.txt", text);
            Console.WriteLine($">>{text}<<");
            Console.WriteLine("===========================");


            // Копирует существующий файл в новый файл.
            // Перезапись файла с тем же именем не разрешена.
            Console.WriteLine("Пример 5: Копирование файла");
            File.Copy(@"D:\data3.txt", @"D:\newData3.txt");
            string[] strLines = File.ReadAllLines(@"D:\newData3.txt");
            foreach (var e in strLines)
            {
                Console.WriteLine($"newData3.txt = {e}");
            }
            Console.WriteLine("===========================");


            // Определяет, существует ли заданный файл.
            Console.WriteLine("Пример 6: Определяет, существует ли заданный файл");
            bool newData3 = File.Exists(@"D:\newData3.txt");
            Console.WriteLine($"newData3 = {newData3}");
            Console.WriteLine("===========================");


            // Удаляет указанный файл.
            Console.WriteLine("Пример 7: Удаляет указанный файл.");
            File.Delete(@"D:\newData3.txt");
            Console.WriteLine("===========================");


            // Определяет, существует ли заданный файл.
            Console.WriteLine("Пример 8: Определяет, существует ли заданный файл");
            bool newData = File.Exists(@"D:\newData3.txt");
            Console.WriteLine($"newData3 = {newData}");
            Console.WriteLine("===========================");


            // Перемещает заданный файл в новое местоположение и
            // разрешает переименование файла.
            //Console.WriteLine("Пример 9: Перемещает заданный файл");
            //File.Move(@"D:\data2.txt", @"C:\newData2.txt");
            //bool newData2 = File.Exists(@"C:\newData2.txt");
            //Console.WriteLine($"newData3 = {newData2}");
            //string[] strLines = File.ReadAllLines(@"C:\newData2.txt");
            //foreach (var e in strLines)
            //{
            //    Console.WriteLine($"newData3.txt = {e}");
            //}
            Console.ReadKey();
        }
    }
}
