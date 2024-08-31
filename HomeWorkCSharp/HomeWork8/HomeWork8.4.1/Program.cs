using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork8._4._1
{
    /*
       Задание 4. Записная книжка
       Что нужно сделать
       Программа спрашивает у пользователя данные о контакте:
       ФИО
       Улица
       Номер дома
       Номер квартиры
       обильный телефон
       Домашний телефон
    */

    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.XDocumentCreate();
            program.XDocumentReader();
            Console.ReadLine();
        }

        //Создаем xml файл
        private void XDocumentCreate()
        {
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();

            Console.Write("Введите название улицы: ");
            string street = Console.ReadLine();

            Console.Write("Введите номер дома: ");
            string houseNumber = Console.ReadLine();

            Console.Write("Введите номер квартиры: ");
            string flatNumber = Console.ReadLine();

            Console.Write("Введите номер мобильного телефона: ");
            string mobilePhone = Console.ReadLine();

            Console.Write("Введите номер домашнего телефона: ");
            string flatPhone = Console.ReadLine();

            XElement Person = new XElement("Person",
                new XAttribute("name", fullName),
                new XElement("Address",
                    new XElement("Street", street),
                    new XElement("HouseNumber", houseNumber),
                    new XElement("FlatNumber", flatNumber)),
                new XElement("Phone",
                    new XElement("MobilePhone", mobilePhone),
                    new XElement("FlatPhone", flatPhone))
                    );

            Person.Save("worker.xml");
            Console.WriteLine("\nДанные контакта сохранены в файл worker.xml");
            Console.WriteLine("\nНажмите Enter для вывода файла на экран");
            Console.ReadKey();
        }
        

        // Читаем xml файл
        private void XDocumentReader()
        {
            string xml = File.ReadAllText("worker.xml");

            var col = XDocument.Parse(xml)
                .Descendants("Person")
                .ToList();
            foreach (var item in col)
            {
                Console.WriteLine($"\n\n{item}");
            }
        }
    }
}
