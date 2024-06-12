using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Щербаков Алексей";
            int age = 39;
            string mail = "mail.ru@Mail.ru";
            double programmingScores = 3.5;
            int mathScores = 4;
            int physicsScores = 3;
            double amountPoints = programmingScores + mathScores + physicsScores;
            double averageScore = amountPoints / 3;

            Console.WriteLine($"Ф.И.О = {fullName}");
            Console.WriteLine($"Возраст = {age} лет");
            Console.WriteLine($"Почта = {mail}");
            Console.WriteLine($"Баллы по программированию = {programmingScores} балла");
            Console.WriteLine($"Баллы по математике = {mathScores} балла");
            Console.WriteLine($"Баллы по физике = {physicsScores} балла");
            Console.WriteLine($"Сумма баллов = {amountPoints} балла");
            Console.WriteLine($"Среднее арифмитическое баллов = {averageScore}");
            Console.ReadKey();
        }
    }
}
