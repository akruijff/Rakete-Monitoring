namespace _03___Hangman
{
    internal class HangmanProgram
    {
        const int LIVES = 5;
        static List<string> words =
        [
            "banana",
            "apple",
            "grapefruit",
            "strawberry",
            "watermelon"
        ];
        static Random random = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                PlayGame();
                if (!ContinueGame())
                    break;
            }
        }

        private static void PlayGame()
        {
            var word = words[random.Next(words.Count)];
            var game = new Hangman(word, LIVES);

            while (!game.IsGameOver())
            {
                DisplayStatus(game);
                GuessLetter(game);
            }

            DisplayStatus(game);
            DisplayResult(game);
        }

        private static void DisplayStatus(Hangman game)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine();
            Console.WriteLine(game.Status());
            Console.WriteLine();
        }

        private static void GuessLetter(Hangman game)
        {
            Console.WriteLine("Guess a letter: ");
            game.Guess(Console.ReadKey().KeyChar.ToString().ToLower());
        }

        private static void DisplayResult(Hangman game)
        {
            if (game.IsGameWon())
                Console.WriteLine("YOU WIN!");
            else
                Console.WriteLine("G A M E   O V E R");
        }

        private static bool ContinueGame()
        {
            Console.WriteLine("Play again? (y/n) ");
            return "y" == Console.ReadKey().KeyChar.ToString().ToLower();
        }
    }
}
