using System;
using System.Runtime.InteropServices;

namespace GuessTheNumber
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int number = random.Next(1, 101);

            Console.WriteLine($"Hello! Guess the number between 1 and 100!");
            while (true)
            {
                string answer = Console.ReadLine();
                int userNumber = Convert.ToInt32(answer);

                if (userNumber == number)
                {
                    Console.WriteLine("Вы угадали!");
                    Console.ReadKey();
                    break;
                }
                else if (userNumber < number)
                {
                    Console.WriteLine($"Не угадали! Больше!");
                }
                else if (userNumber > number)
                {
                    Console.WriteLine($"Не угадали! Меньше!");
                }
            }

        }
    }
}