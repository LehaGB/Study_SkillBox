using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._4
{

    // 7.4 Описание членов структуры: свойства

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Bod", "qwerty");
            account.Paswword = "qazwsxedc";
            Console.WriteLine($"Логин: {account.Login}, Пароль: {account.Paswword}");
            Console.ReadKey();
        }
    }
}
