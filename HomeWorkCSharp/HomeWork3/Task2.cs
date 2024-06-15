using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Task2
    {
        //Задание 2. Программа подсчёта суммы карт в игре «21».
        static void Main(string[] args)
        {
            Console.Write("Сколько у вас карт на руках: ");
            int numberCards = int.Parse(Console.ReadLine());

            while (true)
            {
                if (numberCards <= 0)
                {
                    Console.WriteLine("Убедитесь, что ввели все правильно, немогу подсчитать");
                    Console.WriteLine("Нажмите Enter для выхода....");
                }
                break;
            }
            string inputCards = string.Empty;
            int sumCards = 0;
            int count = 1;
            int naminalCards = 0;
            string K = "K";
            string Q = "Q";
            string J = "J";
            string T = "T";
            if (numberCards > 0)
            {
                Console.WriteLine("Введите наминал своих карт по одной карте: ");
                
                for (int i = 0; i < numberCards; i++)
                {
                    inputCards = Console.ReadLine();
                    bool result = int.TryParse(inputCards, out naminalCards);
                    if (result)
                    {
                        switch (naminalCards)
                        {
                            case 6:
                                Console.WriteLine($"{count}-карта = Шестерка");
                                break;
                            case 7:
                                Console.WriteLine($"{count}-карта = Семерка");
                                break;
                            case 8:
                                Console.WriteLine($"{count}-карта = Восьмерка");
                                break;
                            case 9:
                                Console.WriteLine($"{count}-карта = Девятка");
                                break;
                            case 10:
                                Console.WriteLine($"{count}-карта = Десятка");
                                break;
                            default:
                                Console.WriteLine("Такой карты в колоде нет");
                                naminalCards = 0;
                                break;
                        }
                    }
                    else
                    {
                        switch (inputCards)
                        {
                            case "K":
                                Console.WriteLine($"{count}-карта = Король");
                                sumCards = sumCards + 10;
                                break;
                            case "Q":
                                Console.WriteLine($"{count}-карта = Дама");
                                sumCards = sumCards + 10;
                                break;
                            case "J":
                                Console.WriteLine($"{count}-карта = Валет");
                                sumCards = sumCards + 10;
                                break;
                            case "T":
                                Console.WriteLine($"{count}-карта = Туз");
                                sumCards = sumCards + 10;
                                break;
                            default:
                                Console.WriteLine("Такой карты в колоде нет");
                                naminalCards = 0;
                                break;
                        }
                       
                    }
                    count++;
                    sumCards = sumCards + naminalCards;
                }
                Console.WriteLine($"Ваше количество очков = {sumCards}");
            }
            Console.ReadLine();
        }
    }
}
