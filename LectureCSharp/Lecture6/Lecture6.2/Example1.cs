using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6._2
{

    /// <summary>
    /// 6.2 Работа со строками: статический класс String, методы экземпляров
    /// </summary>
    class Example1
    {
        static void Main(string[] args)
        {
            string str = "Visual lausiV";
            Console.WriteLine($"str = {str}");

            // Возвращает индекс с отсчетом от нуля до первого вхождения указанного символа 
            // Юникода в данной строке.Если элемент найден возвращает 1, иначе -1.
            Console.WriteLine($"str.IndexOf('i') = {str.IndexOf('i')}");

            // Возвращает позицию индекса сотсчетом от нуля последнего вхождения указанного
            // символа Юникода в пределах этого экземпляра.
            Console.WriteLine($"str.LastIndexOf('i') = {str.LastIndexOf('i')}");

            // Отсчитываемое от нуля значение индекса параметра value, если этот знак найден.
            // в противном случае - значение = -1.
            Console.WriteLine($"str.LastIndexOf('z') = {str.LastIndexOf('z')}");

            // Возвращает новую строку, в которой указаная строка вставляется в указанной позиции
            // индекса в данном экземпляре.
            string s = str.Insert(str.IndexOf(' ') + 1, "C# ");
            Console.WriteLine($"s = {s}");

            // Возвращает новую строку, в которой были удалены все символы с указанной позиции.
            Console.WriteLine($"str.Remove(6) = {str.Remove(6)}");

            // Возвращает новую строку, в которой были удалены все символы с указанной позиции
            // count элементов.
            Console.WriteLine($"str.Remove(6, 3) = {str.Remove(6, 3)}");

            // Возвращает новую строку, в которой все вхождения заданного знака Юникода в текущем 
            // экземпляре заменены другим знаком Юникода.
            Console.WriteLine($"str.Replace('a', 'z') = {str.Replace('a', 'z')}");

            // Извлекает подстроку из данного экземпляра.Подстрока начинается в указанном положении
            // символов и продолжается до конца строки.
            Console.WriteLine($"str.Substring(4) = {str.Substring(4)}");

            // Возвращает новую строку в верхнем регистре.
            Console.WriteLine($"{str.ToUpper()}");

            // Возвращает новую строку в нижнем регистре.
            Console.WriteLine($"{str.ToLower()}");

            // Удаляет все начальные и конечные символы-разделители из текущего объекта System.String
            // str.Trim(); 

            // Удаляет все конечные символы-разделители из текущего объекта System.String
            // str.TrimEnd(); 

            // Удаляет все начальные символы-разделители из текущего объекта System.String
            // str.TrimStart(); 

            // Разбивает строку на подстроки в зависимости от символов в массиве.
            string[] array = "1 2 3 4,5 6;7 8 9;10".Split(' ', ',', ';');
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            string test = null;
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");  // true

            test = String.Empty;
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");  // true

            test = "Skill";
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");  // false

            Console.ReadKey();
        }
    }
}
