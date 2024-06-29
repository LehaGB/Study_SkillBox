using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6._3
{

    // 6.3 Работа с файлами: класс File, FileInfo, Directory, DirectoryInfo.

    class Example2
    {
        static void Main(string[] args)
        {
            // using.System.IO;
            // Представляет статические методы для создания, копирования, удаления, пермещения и открытия.
            // а так же позволяет создовать объекты System.IO.FileStream

            FileInfo fileInfo = new FileInfo(@"D:\data2.txt");

            // Получает или задает атрибуты для текущего каталога.
            Console.WriteLine(fileInfo.Attributes);

            // Получает значение, показывающее, существует ли файл.
            Console.WriteLine(fileInfo.Exists);

            // Получет строку, содержащую расширения файла.
            Console.WriteLine(fileInfo.Extension);

            // Возвращает или задает значение, позволяющее определить, 
            // является ли текущий файл доступным только для чтения.
            Console.WriteLine(fileInfo.IsReadOnly);

            // Получает или задает время последнего доступа к текущему файлу или каталогу.
            Console.WriteLine(fileInfo.LastAccessTime);

            // Получает или задает время последней операции записи в текущий файл или кталог.
            Console.WriteLine(fileInfo.LastWriteTime);

            // Получает полный путь к файлу иил к каталогу.
            Console.WriteLine(fileInfo.FullName);

            // Вовращает имя файла.
            Console.WriteLine(fileInfo.Name);

            // Получает строку, представляющую полный путь к каталогу.
            Console.WriteLine(fileInfo.DirectoryName);

            Console.ReadKey();
        }
    }
}
