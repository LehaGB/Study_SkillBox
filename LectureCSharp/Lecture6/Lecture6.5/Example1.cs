using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6._5
{

    // 6.5 Расширенная работа со строками: StringReader и StringWriter; изменяемые строки: StringBuilder

    class Example1
    {
        static void Main(string[] args)
        {
            // Проблема string
            string s1 = "Првет";
            string s2 = s1.Insert(2, "и");
            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
            Console.WriteLine("Объем выделенной памяти");
            Console.WriteLine($"s1 = {s1.Length * 2} байт, s2 = {s2.Length * 2} байт");

            Console.WriteLine("====================================");

            // StringBuilder // Представляет изменяемую строку символов.
            StringBuilder sb1 = new StringBuilder("Првет");
            Console.WriteLine($"\nДлина sb1 = {sb1.Length}");
            Console.WriteLine($"Вместимость sb1 = {sb1.Capacity}");

            Console.WriteLine("====================================");

            StringBuilder sb2 = new StringBuilder(100);
            Console.WriteLine($"\nДлина sb2 = {sb2.Length}");
            Console.WriteLine($"Вместимость sb2 = {sb2.Capacity}");
            Console.WriteLine("====================================");

            // Добавляет копию строки к данному экземпляру.
            sb2.Append("Один");
            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = { sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.WriteLine("====================================");

            // Добавляет к данному экземпляру строку, возвращаемую в результате обработки
            // строки составного формата.
            sb2.AppendFormat("{0} {1}", "Два", " Три");
            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = { sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.WriteLine("====================================");

            // Добавляет знак завершения строки по умолчанию в конец.
            sb2.AppendLine(".");
            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = { sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.WriteLine("====================================");

            // Добавляет копию указанной строки, и знак завершения строки по умолчанию в конец
            // текущего объекта.
            sb2.AppendLine("Четыре");
            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = { sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.WriteLine("====================================");

            // Удаляет указанный диапазон символов из данного экземпляра.
            sb2.Remove(14, 4);
            Console.WriteLine($"После удаления sb2 = {sb2}");
            Console.WriteLine("====================================");
            Console.ReadKey();
        }
    }
}
