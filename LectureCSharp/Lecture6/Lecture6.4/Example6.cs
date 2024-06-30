using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lecture6._4
{

    // 6.4 Работа с потоками: StreamWriter и StreamReader.

    class Example6
    {
        static void Main(string[] args)
        {
            string source = "voina-i-mir.txt";
            string compressed = "voina-i-mir.zip";

            using (FileStream ss = new FileStream(source, FileMode.OpenOrCreate))
            {
                // Поток для записи сжатого файла
                using (FileStream ts = File.Create(compressed))
                {
                    // Поток архивации
                    using (GZipStream cs = new GZipStream(ts, CompressionMode.Compress))
                    {
                        ss.CopyTo(cs);  // Копируем байты из одного потока в другой.
                        Console.WriteLine("Сжатые файла {0} завершено. Было {1} стало {2}", source, ss.Length,
                            ts.Length);
                    }
                }
            }


            // Поток для чтения из зжатого файла
            using (FileStream ss = new FileStream(compressed, FileMode.OpenOrCreate))
            {
                // Поток длязаписи восстоновленного файла
                using (FileStream ts = File.Create($"{source}_txt"))
                {
                    using (GZipStream ds = new GZipStream(ss, CompressionMode.Decompress))
                    {
                        ds.CopyTo(ts);
                        Console.WriteLine($"{source} восстоновлен");
                        Console.WriteLine("Сжатые файла {0} завершено. Было {1} стало {2}", source, ss.Length,
                              ts.Length);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
