using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lecture8._5
{
    /// <summary>
    /// 8.5 XML: XDocument.Parse
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.XDocumentCreate();
            program.XDocumentReader();
        }
        private void XDocumentParseReader()
        {
            #region XDocument.Parse(чтение файла)
            string xml = File.ReadAllText("_myWeather.xml");

            var col = XDocument.Parse(xml)
                .Descendants("MMWEATHER")
                .Descendants("REPORT")
                .Descendants("TOWN")
                .Descendants("FORECAST")
                .ToList();
            foreach (var item in col)
            {
                Console.WriteLine($"\n\n{item}");
            }
            Console.ReadLine();
            Console.Clear();

            //foreach (var item in col)
            //{
            //    Console.WriteLine("day: {0} month: {1} year: {2}",
            //       item.Attribute("day").Value,
            //       item.Attribute("month").Value,
            //       item.Attribute("year").Value);
            //}
            //Console.ReadLine();
            //Console.Clear();

            foreach (var item in col)
            {
                Console.WriteLine("min: {0} max: {1}",
                   item.Element("TEMPERATURE").Attribute("min").Value,
                   item.Element("TEMPERATURE").Attribute("max").Value);
            }
            Console.ReadLine();
            Console.Clear();

            string city = XDocument.Parse(xml)
                    .Element("MMWEATHER")
                    .Element("REPORT")
                    .Element("TOWN")
                    .Attribute("sname").Value;
            Console.WriteLine($"{city}");
            Console.ReadLine();
            Console.Clear();
            #endregion
        }



        private void XDocumentCreate()
        {
            XElement myMMWEATHER = new XElement("MMWEATHER");
            XElement myTOWN = new XElement("TOWN");
            XElement myFORECAST = new XElement("FORECAST");
            XElement myTEMPERATURE = new XElement("TEMPERATURE");

            XAttribute xAttributemMin = new XAttribute("min", 7);
            XAttribute xAttributemMax = new XAttribute("max", 10);

            myTEMPERATURE.Add(xAttributemMin, xAttributemMax);
            myFORECAST.Add(myTEMPERATURE);

            XAttribute xAttributeCityName = new XAttribute("sname", "Москва");

            myTOWN.Add(myFORECAST, xAttributeCityName);

            myMMWEATHER.Add(myTOWN);

            myMMWEATHER.Save("_myWeather.xml");

        }
        private void XDocumentReader()
        {
            string xml = File.ReadAllText("_myWeather.xml");
            var col = XDocument.Parse(xml)
                .Descendants("MMWEATHER")
                .Descendants("TOWN")
                .Descendants("FORECAST")
                .ToList();
            foreach (var item in col)
            {
                Console.WriteLine($"\n\n{item}");
            }
            Console.ReadLine();
            Console.Clear();

            string city = XDocument.Parse(xml)
                  .Element("MMWEATHER")
                  .Element("TOWN")
                  .Attribute("sname").Value;
            Console.WriteLine($"{city}");
            Console.ReadLine();

        }

    }
}
