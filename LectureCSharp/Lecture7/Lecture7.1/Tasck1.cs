using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7._1
{

    // 7.Структуры и введение в ООП


    class Tasck1
    {
        // 7.1 Структуры: описание, использование
        static void Main(string[] args)
        {
            // MonthlyReport
            WorkerMan();
            MonthlyReportMany2();
        }
        private static void MonthlyReportMany()
        {
            MonthlyReport january = new MonthlyReport();
            january.Month = "Январь";
            january.Income = 100_000;
            january.Consumption = 30_000;
            january.Arrived = january.Income - january.Consumption;

            Console.WriteLine("{0}: Доход: {1} Расход: {2} Прибыль: {3}",
                january.Month, january.Income, january.Consumption, january.Arrived);
            Console.ReadKey();
        }
        private static void MonthlyReportMany2()
        {
            MonthlyReport[] report = new MonthlyReport[12];

            report[0] = new MonthlyReport()
            {
                Month = "Январь",
                Income = 100_000,
                Consumption = 30_000,
            };
             report[0].Arrived = report[0].Income - report[0].Consumption;

            Console.WriteLine("{0}: Доход: {1} Расход: {2} Прибыль: {3}",
                report[0].Month, report[0].Income, report[0].Consumption,
                report[0].Arrived);
            Console.ReadKey();
        }
        private static void WorkerMan()
        {
            Worker worker = new Worker()
            {
                Position = "Инженер",
                FirstName = "Роберт",
                LastName = "Иванов",
                DateOfBirth = new DateTime(1990, 09, 28)
            };
            Console.WriteLine("Должность: {0}, Фамилия: {1}, Имя: {2}, Дата рождения: {3}",
                worker.Position, worker.LastName, worker.FirstName, worker.DateOfBirth);
            Console.ReadKey();
        }
    }
}
