using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture6._5
{

    // 6.5 Расширенная работа со строками: StringReader и StringWriter; изменяемые строки: StringBuilder

    class Example2
    {
        static void Main(string[] args)
        {
            // using System.IO;
            // Реализует объект System.IO.TextWriter для записи сведений в строку.
            // Сведения хранятся в базовом System.Text.StringBuilder.

            StringBuilder sb = new StringBuilder(100);
            string s = "Ролик 5. Расширенная работа со строками: StringReader и StringWriter;" +
                "изменяемые строки: StringBuilder";
            sb.Append(s);
            Console.WriteLine($"{sb}");

            using(StringWriter sw = new StringWriter(sb))
            {
                sw.Write("!!!");
            }
            Console.WriteLine($"{sb}");

            // Реализует System.IO.StringReader считывает данные из строки.
            using(StringReader sr = new StringReader(s))
            {
                char[] buf = new char[s.Length];
                sr.ReadBlock(buf, 0, buf.Length);
                foreach (var e in buf)
                {
                    Console.Write($"{e}");
                }
            }
            Console.ReadKey();
           
        }
    }
}
