using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture6._4
{

    // 6.4 Работа с потоками: StreamWriter и StreamReader.

    class Example2
    {
        static void Main(string[] args)
        {
            // Требуется создать файл - аналог записной книжки.
            // В файле хранится:
            // Имя автора записи
            // Дата
            // Описание заметки

            using (StreamWriter sw = new StreamWriter("data.csv", true, Encoding.Unicode))
            {
                char key = 'д';

                do
                {
                    string note = string.Empty;
                    Console.Write("\nВведите имя автора записи: ");
                    note += $"{Console.ReadLine()}\t";

                    string now = DateTime.Now.ToShortTimeString();
                    Console.WriteLine($"Время заметки {now}");
                    note += $"{now}\t";

                    Console.Write("Введите описание заметки: ");
                    note += $"{Console.ReadLine()}\t";
                    sw.WriteLine(note);
                    Console.Write("Продолжить н/д\n");
                    key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == 'д');
            }


            // Чтение
            using (StreamReader sr = new StreamReader("data.csv", Encoding.Unicode))
            {
                string line;
                Console.WriteLine($"{"Автор",15} {" Время",8}  {"Описание"}");

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('\t');
                    Console.WriteLine($"{data[0],15} {data[1],8}  {data[2]}");
                }
            }
            Console.ReadKey();
        }
    }
}
