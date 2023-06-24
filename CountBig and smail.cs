using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("\nПервон число больше второго");
            }

            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("\nВторое число больше первого");
            }

            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("\nОба числа равны друг другу");
            }

            else
            {
                Console.WriteLine("Erorr");
            }
            Console.ReadLine();

        }
    }
}