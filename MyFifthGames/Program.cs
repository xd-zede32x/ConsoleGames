namespace FileCSharp
{
    public class Program
    {
        private static Random _random = new Random();

        public static void Main(string[] args)
        {
            Level currentLevel = Level.Easy;
            string[] names = Enum.GetNames(typeof(Level));

            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine($"[{index + 1}] -- [{names[index]}]");
            }

            Console.Write("Выберете уровень сложности: ");

            string levelInput = Console.ReadLine();
            int levelIndex = Convert.ToInt32(levelInput);
            currentLevel = (Level)levelIndex;

            while (true)
            {
                int sCount = 0;

                for (int index = 0; index < GetMaxCharCount(currentLevel); index++)
                {
                    SetConsoleColor(currentLevel);

                    if (_random.Next(0, 100) == 99)
                    {
                        sCount++;
                        Console.Write('S');
                    }

                    else
                    {
                        Console.Write('C');
                    }
                }

                Console.Write("\n\nСколько символов S вы видите: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer == sCount)
                {
                    Console.WriteLine($"Вы выиграли символов S было: {sCount} :)");
                }

                else
                {
                    Console.WriteLine($"Вы не угадали было: {sCount} символов S :(");
                }

                Console.ReadKey();
            }
        }

        private static int GetMaxCharCount(Level level)
        {
            switch (level)
            {
                default:
                case Level.Easy:
                    return 600;

                case Level.Normal:
                    return 1000;

                case Level.Hard:
                    return 2000;
            }
        }

        private static void SetConsoleColor(Level level)
        {
            switch (level)
            {
                default:
                case Level.Easy:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case Level.Normal:
                    Console.ForegroundColor = _random.Next(0, 2) == 0 ? ConsoleColor.Yellow : ConsoleColor.Red;
                    break;

                case Level.Hard:
                    Console.ForegroundColor = (ConsoleColor)_random.Next(1, 15);
                    break;
            }
        }
    }
}