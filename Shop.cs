using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random moneyShop = new Random();
            int result = moneyShop.Next(10, 100);

            Console.WriteLine("Ваш счёт: " + result);
            Console.WriteLine("В наличии продукты: |Яблоко | Груша | Киви | Банан | Ананас | Персик|\n");
            Console.Write("Введите продукт который вы хотите купить: ");
            string shop = Console.ReadLine();

            Console.WriteLine($"Вы выбрали продукт под названием: {shop}");

            Console.Write("\nВерен ли этот продукт | Если Да то напешите Верен | если нет | Неверен: ");
            string reult = Console.ReadLine();
            if (reult == "Верен" || reult == "верен" || reult == "ВЕРЕН")
            {
                Console.WriteLine("Хорошо сколько вы хотите заплатить за эту покупку: ");
                int sumSale = int.Parse(Console.ReadLine());
                Console.Write("Картой или наличкой: ");
                string money = Console.ReadLine();

                if (money == "Картой" || money == "КАРТОЙ" || reult == "картой" || reult == "Карточкой")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\t\tС вашей карты снялось -{sumSale}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    result -= sumSale;
                    Console.WriteLine("\t\tВаш счёт составляет = " + result);
                    Console.ResetColor();
                }
                else if (money == "Наличкой" || money == "наличкой" || money == "НАЛИЧКОЙ")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t\tС вашего карманика снялось -1(руб).");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\t\tВаш счёт составляет = {result}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Попробуйте как то в другой раз к нам зайти если будут деньги :)");
            }
        }
    }
}