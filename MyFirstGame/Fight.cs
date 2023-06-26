using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class Fight
    {
        static Player player
        {
            get { return Program.player; }
            set { Program.player = value; }
        }

        public static void FigthEnemu(Enemu enemu)
        {
            Console.WriteLine($"На вас напал {enemu.Name} с уроном {enemu.Damage} с защитой {enemu.Arrmor} и с жизнья {enemu.MaxHealth}");
            Console.WriteLine("нажмите enter чтоб продолжить");
            Console.ReadLine();
            Console.Clear();

        go:

            Console.WriteLine($"{enemu.Name}: {enemu.Health} HP");
            Console.WriteLine($"{player.name}: {player.playerHelth} HP");
            Console.WriteLine("1: Ударить, 2: Убежать");
            var key = Program.GetButton();

            if (key == ConsoleKey.D1)
            {
                enemu.Health -= Math.Max(player.damage -= enemu.Arrmor, 1);
            }

            else if (key == ConsoleKey.D2)
            {
                float r = Program.random.Next(1, 5);
                if (r == 2)
                {
                    Console.WriteLine("Вы смогли убежать от этого монстра");
                    goto run;

                }
                else
                {
                    Console.WriteLine("Вам не удалось сбежать,вам пизда");
                }
            }

            else
            {
                Console.WriteLine("\tне существующая команда");
                Thread.Sleep(2000);
                Console.Clear();
                goto go;
            }


            if (enemu.Health > 0)
            {
                player.playerHelth -= Math.Max(enemu.Damage -= player.arrmor, 1);
            }

            if (player.playerHelth <= 0)
            {
                goto lose;
            }
            else if (enemu.Health <= 0)
            {
                goto win;
            }
            else
            {
                Console.Clear();
                goto go;
            }

        win:
            Console.Clear();
            Console.WriteLine("Вы выграли этго монстра :)");
            Console.WriteLine("вы получили опыт");
            return;

        lose:
            Console.Clear();
            Console.WriteLine("Вы проиграли :(");
            return;

        run: 
            return;
            
        }
    }
}
