using System;
namespace MyFourthGames
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloUser();
            int cookies = 0; // Печеньки
            int plants = 1; // Завод

            int pracePlant = 20; // Цена Завода

            int factory = 0; // Супер Завод
            int praceFactory = 750; // Цена Супер Завода

            char c = ' ';

            while (c != 'q')
            {
                c = Console.ReadKey().KeyChar;
                Console.Clear();

                if (c == ' ')
                {
                    cookies = cookies + plants + factory * 10;
                }

                else if (c == 'b')
                {
                    if (cookies >= pracePlant)
                    {
                        plants++;
                        cookies = cookies - pracePlant;
                        pracePlant = pracePlant * 2;
                    }
                    else
                    {
                        Console.WriteLine("\tНе достаточно Печенек:(");
                    }
                }

                else if (c == 'f')
                {
                    if (cookies >= praceFactory)
                    {
                        factory++;
                        cookies = cookies - praceFactory; 
                        praceFactory = praceFactory * 3;
                    }
                    else
                    {
                        Console.WriteLine("\tНе достаточно Печенек:(");
                    }
                }

                Console.WriteLine($"Баланс Печенек = {cookies}$");
                Console.WriteLine();

                Console.WriteLine($"Количество Заводов = {plants} || Цена за Завода - {pracePlant}$"); 
                Console.WriteLine($"Количество Фактории = {factory} || Цена за Факторию - {praceFactory}$");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t\t\t\t\t\t\tВыход из игры - q");
                Console.ResetColor();
            }
        }

        static void HelloUser()
        {
            Console.CursorVisible = false;
            Console.Title = "Cookie Clicker";

            Console.WriteLine("\t\t\t\tCookie Clicker");
            Console.WriteLine("Привила игры: ");

            Console.WriteLine("1. Нажимайте на пробел что бы зарабатывать Печеньки");
            Console.WriteLine("2. Для того что бы купить Завод нажми на клавишу - b");

            Console.WriteLine("3. Для того что бы купить Факторию нажми на клавишу - f");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\t\t\tРазработчик Роман Хоменко");
            Console.ResetColor();

            Console.WriteLine("\t\t\t\tПриятной игры!");
        }
    }
}