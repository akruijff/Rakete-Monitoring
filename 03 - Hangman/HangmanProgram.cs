namespace _03___Hangman
{
    internal class HangmanProgram
    {
        static void Main(string[] args)
        {
            var game = new Hangman("banana", 5);
            while (!game.IsGameOver())
            {
                Console.Clear();
                Console.WriteLine("Welcome to Hangman!");
                Console.WriteLine();
                Console.WriteLine(game.Status());
                Console.WriteLine();

                Console.WriteLine("Guess a letter: ");
                game.Guess(Console.ReadKey().KeyChar);
            }

            Console.Clear();
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine();
            Console.WriteLine(game.Status());
            Console.WriteLine();

            if (game.IsGameWon())
                Console.WriteLine("YOU WIN!");
            else
                Console.WriteLine("G A M E   O V E R");
        }
    }
}
