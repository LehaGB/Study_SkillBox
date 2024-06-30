using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture6._4
{

    // 6.4 Работа с потоками: StreamWriter и StreamReader.

    class Example5
    {
        static void Main(string[] args)
        {

            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            // Запись в файл.
            using (FileStream fileStream = new FileStream(@"note.txt", FileMode.OpenOrCreate))
            {
                // Преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                // Запись массива байтов в файл
                fileStream.Write(array, 0, array.Length);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Byte: {array[i]} ");
                }
            }


            // Чтение из файла.
            using (FileStream fileStream = File.OpenRead(@"note.txt"))
            {
                // Преобразуем строку в байты
                byte[] array = new byte[fileStream.Length];

                // Считывам данные
                fileStream.Read(array, 0, array.Length);

                // Декодируем байты в строку
                text = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст: {text}");

            }
            Console.ReadKey();
        }
    }
}
