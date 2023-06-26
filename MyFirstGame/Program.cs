using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class Program
    {
       public static Player player;
       public static Random random;

        static void Main(string[] args)
        {
            random = new Random();
            player = new Player();
            DataBase.Load();
        go:
            Console.Clear();
            Console.WriteLine("1: играть");
            Console.WriteLine("2: загрузить");
            Console.WriteLine("3: выйти");

            ConsoleKey key = GetButton();

            Console.Clear();

            if (key == ConsoleKey.D1)
            {
                Console.Write("\nДля начала игры введите своё имя: ");
                player.name = Console.ReadLine();
                Game();

            }

            else if (key == ConsoleKey.D2)
            {
            }

            else if (key == ConsoleKey.D3)
            {
                return;
            }

            else
            {
                Console.WriteLine("\tне существующая кнопка");
                Thread.Sleep(2000);
                goto go;
            }

        }

        public static void Game()
        {
            Console.Clear();
            Console.WriteLine("После крушения корабля");
            Thread.Sleep(2000);

        go:
            Console.Clear();

            Console.WriteLine("1: Информация, 2: Иследовать, 3: Инввентарь, 4: Охота");
            ConsoleKey key = GetButton();


            if (key == ConsoleKey.D1)
            {
                Console.WriteLine($"Имя: {player.name}");
                Console.WriteLine($"Жизнь: {player.playerHelth} / {player.playerHelthMax}");
                Console.WriteLine($"Энергия: {player.playerPower} / {player.playerPowerMax}");
                
                
                Console.WriteLine("\tнажмите на любую кнопку");
                Console.ReadKey();
                goto go;
            }

            else if (key == ConsoleKey.D2)
            {
                if (player.playerPower > 0)
                {
                    player.playerPower--;
                    Explore();

                }
                else
                {
                    Console.WriteLine("\tУ вас недостаточно сил,вы устали");
                }
            }

            else if (key == ConsoleKey.D3)
            {
                player.inventory.GetAllItems();
            }

            else if (key == ConsoleKey.D4)
            {
                Fight.FigthEnemu(DataBase.GetEnemu(0));
            }

            else
            {
                Console.WriteLine("\tне существующая кнопка");
                Thread.Sleep(2000);
                goto go;
            }

            Console.WriteLine("\tНажмите на любую кнопку");
            Console.ReadKey();
            goto go;
        }

        public static void Explore()
        {
            int number = random.Next(0, 30);

            if (number <= 5)
            {
                Console.WriteLine("Вы нашли пищеру");
            }

            else if (number <= 10)
            {
                Console.WriteLine("Вы нашли сундук");
            }

            else if (number <= 15)
            {
                Console.WriteLine("Вы нашли кристал");
            }

            else
            {
                Console.WriteLine("Вы ничего не нашли");
            }

        }
        public static ConsoleKey GetButton()
        {
            var but = Console.ReadKey(true).Key;
            return but;
        }
    }
}
