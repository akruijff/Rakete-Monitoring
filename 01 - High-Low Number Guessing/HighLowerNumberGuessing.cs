using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

namespace _01___High_Low_Number_Guessing
{
    internal class HighLowerNumberGuessing
    {
        const int MIN = 1;
        const int MAX = 100;
        const int NUMBER_OF_ATTEMPTS = 15;

        static void Main(string[] args)
        {
            while (true)
            {
                playGame();
                if (!wantToPlayAgain())
                    break;
            }
        }

        private static void playGame()
        {
            int solution = new Random().Next(MAX - MIN) + MIN;

            Console.WriteLine($"Guess the value between ${MIN} and ${MAX}");
            Console.WriteLine($"You have {NUMBER_OF_ATTEMPTS} attemts to guess the number");
            Console.WriteLine($"The soltuion is {solution}. Don't tell anyone, OK?");

            for (int i = 1; i <= NUMBER_OF_ATTEMPTS; ++i)
            {
                Console.WriteLine();
                Console.Write($"Attemt {i} - Enter your number: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < solution)
                    Console.WriteLine("Higher");
                else if (guess > solution)
                    Console.WriteLine("Lower");
                else
                {
                    Console.WriteLine("YOU WON!");
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("GAME OVER");
            Console.WriteLine();
        }

        private static bool wantToPlayAgain()
        {
            Console.Write("Want to play again? [Y / N] ");
            bool result = "y" == Console.ReadLine().ToLower();
            Console.WriteLine();
            return result;
        }
    }
}
