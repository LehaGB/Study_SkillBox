using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6._3
{

    // 6.3 Работа с файлами: класс File, FileInfo, Directory, DirectoryInfo.

    class Example3
    {

        static void GetDir(string path, string trim = "")
        {
            // Получаем информацию о текущем каталоге.
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            // Перебераем все подкаталоги текущего каталога.
            foreach (var item in directoryInfo.GetDirectories())
            {
                // Выводим информацию о каталоге.
                Console.WriteLine($"{trim}{item.Name}");

                // Запускаем просмотр вложенного каталога.
                GetDir(item.FullName, trim + "   ");
            }

            // Перебираем все файлы текущего каталога.
            foreach (var item in directoryInfo.GetFiles())
            {
                // Выводим информацию о них
                Console.WriteLine($"{trim}{item.Name}");
            }
        }

        static void Main(string[] args)
        {
            GetDir(@"D:\Study_SkillBox");
            Console.ReadKey();
        }
    }
}
