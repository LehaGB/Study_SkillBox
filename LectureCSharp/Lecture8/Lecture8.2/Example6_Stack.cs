using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8._2
{
    /// <summary>
    /// Stack
    /// </summary>
    class Example6_Stack
    {
        static void Main(string[] args)
        {
            // Арифметическое выражение.
            //string expression = "( ( 2 + 2 ) * ( 2 ) )";
            //Console.WriteLine($"Ожидаемый результат: {(( 2 + 2 ) * 2)}");

            string expression = "( ( 9 + ( 4 * 6 ) ) / 10 )";
            Console.WriteLine($"Ожидаемый результат: {((9.0 + (4 * 6)) / 10)}");

            //string expression = "((1 + (2 * 3)) ^ 4)";
            //Console.WriteLine($"Ожидаемый результат: {Math.Pow(1 + (2 * 3), 4)}");

            // Разбор арифметическое выражения на состовляющие.
            var expressionArray = expression.Replace('(', ' ').Trim().Split(' ');

            Stack<double> numbers = new Stack<double>();  // Стек для хранение чисел.
            Stack<string> operations = new Stack<string>();  // Стек для хранения операций.

            foreach (var e in expressionArray)  // просмотр состовляющих арифметического выражения.
            {
                double n;  // вспомогательное число.
                if (string.IsNullOrEmpty(e))  // игнорируем пустые элементы.
                {
                    continue;
                }
                // Если expressionArray число, то добавляем его в стек чисел.
                if (double.TryParse(e, out n))
                {
                    numbers.Push(n);
                    continue;
                }
                // Если expressionArray операция, то добавляем его в стек с операциями.
                if(@"+/*-^".IndexOf(e) > -1)
                {
                    operations.Push(e);
                    continue;
                }

                // Закрывающиеся скобка - призыв к действию.
                if(e == ")")
                {
                    double n1 = numbers.Pop();  // Извлекаем два числа.
                    double n2 = numbers.Pop();  // из стека с числами.
                    string operetion = operations.Pop();

                    // Выполняем операцию и результат кладем в стек с числами.
                    switch (operetion)
                    {
                        case "+":
                            numbers.Push(n2 + n1);
                            break;
                        case "-":
                            numbers.Push(n2 - n1);
                            break;
                        case "*":
                            numbers.Push(n2 * n1);
                            break;
                        case "/":
                            numbers.Push(n2 / n1);
                            break;
                        case "^":
                            numbers.Push(Math.Pow(n2,n1));
                            break;
                    }
                    
                }
                
            }
            Console.WriteLine($"Фактический результат: {numbers.Pop()}");
            Console.ReadLine();

        }
    }
}
