using System;
using System.Diagnostics;
using static System.Console;

namespace NETCORE
{
    class Program
    {
        private const int MapWidth = 30;
        private const int MapHigth = 15;

        private const int ScreenWidth = MapWidth * 3;
        private const int ScreenHigth = MapHigth * 3;

        private const int FrameMs = 200;

        private const ConsoleColor BorderColor = ConsoleColor.Gray;
        private const ConsoleColor HeadColor = ConsoleColor.DarkRed;
        private const ConsoleColor BoddyColor = ConsoleColor.DarkGreen;
        private const ConsoleColor FoodColor = ConsoleColor.Cyan;

        private static readonly Random Random = new Random();

        static void Main()
        {
            SetWindowSize(ScreenWidth, ScreenHigth);
            SetBufferSize(ScreenWidth, ScreenHigth);
            CursorVisible = false;

            while (true)
            {
                StartGame();

                Thread.Sleep(1000);
                ReadKey();
            }
        }

        static void StartGame()
        {
            Clear();
            DrawBorder();
            Direction currentMovement = Direction.Right;

            var snake = new Snake(10, 5, HeadColor, BoddyColor);
            Pixel food = GenFood(snake);
            food.Draw();

            int score = 0;
            int lagMs = 0;
            var sw = new Stopwatch();

            while (true)
            {
                sw.Restart();

                Direction oldMovement = currentMovement;

                while (sw.ElapsedMilliseconds <= FrameMs - lagMs)
                {
                    if (currentMovement == oldMovement)
                    {
                        currentMovement = ReadMovement(currentMovement);
                    }
                }

                sw.Restart();

                if (snake.Head.X == food.X && snake.Head.Y == food.Y)
                {
                    snake.Move(currentMovement, true);

                    food = GenFood(snake);
                    food.Draw();
                    score++;

                    Task.Run(() => Beep(1200, 200));
                }

                else
                {
                    snake.Move(currentMovement);
                }

                if (snake.Head.X == MapWidth - 1 || snake.Head.X == 0 || snake.Head.Y == MapHigth - 1 || snake.Head.Y == 0
                    || snake.Body.Any(b => b.X == snake.Head.X && b.Y == snake.Head.Y))
                    break;

                lagMs = (int)sw.ElapsedMilliseconds;
            }

            snake.Clear();
            food.Clear();

            SetCursorPosition(ScreenWidth / 3, ScreenHigth / 2);
            WriteLine($"GAME OVER Score: {score}");
            Task.Run(() => Beep(200, 600));
        }

        static Pixel GenFood(Snake snake)
        {
            Pixel food;

            do
            {
                food = new Pixel(Random.Next(1, MapWidth - 2), Random.Next(1, MapHigth - 2), FoodColor);
            } while (snake.Head.X == food.X && snake.Head.Y == food.Y
            || snake.Body.Any(b => b.X == food.X && b.Y == food.Y));

            return food;

        }

        static Direction ReadMovement(Direction currentDirection)
        {
            if (!KeyAvailable)
            {
                return currentDirection;
            }

            ConsoleKey key = ReadKey(true).Key;

            currentDirection = key switch
            {
                ConsoleKey.UpArrow when currentDirection != Direction.Down => Direction.Up,
                ConsoleKey.DownArrow when currentDirection != Direction.Up => Direction.Down,
                ConsoleKey.LeftArrow when currentDirection != Direction.Right => Direction.Left,
                ConsoleKey.RightArrow when currentDirection != Direction.Left => Direction.Right,
                _ => currentDirection,
            };
            return currentDirection;
        }

        static void DrawBorder()
        {
            for (int index = 0; index < MapWidth; index++)
            {
                new Pixel(index, 0, BorderColor).Draw();
                new Pixel(index, MapHigth - 1, BorderColor).Draw();
            }

            for (int index = 0; index < MapHigth; index++)
            {
                new Pixel(0, index, BorderColor).Draw();
                new Pixel(MapWidth - 1, index, BorderColor).Draw();
            }
        }
    }
}