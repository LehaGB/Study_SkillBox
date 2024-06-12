using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ошибка!!! - Не удается не явное преоброзавать тпи string в тип int
            //string inputString = "2029";
            //int intValue = (int)inputString;

            string inputString = "2029";
            //int intValue = int.Parse(inputString);
            int intValue = Convert.ToInt32(inputString);
            Console.WriteLine(intValue);

            //double doubleValue = double.Parse(inputString);
            double doubleValue = Convert.ToDouble(inputString);
            Console.WriteLine(doubleValue);

            //ulong ulongValue = ulong.Parse(inputString);
            ulong ulongValue = Convert.ToUInt64(inputString);
            Console.WriteLine(ulongValue);


            //Необработаное исключение: System.OverflowException: Значение было недопустимо 
            // малым или недопустимо большим для безнакового байта.
            //byte byteValue = byte.Parse(inputString);
            //Console.WriteLine(byteValue);

            Console.ReadLine();
        }
    }
}
