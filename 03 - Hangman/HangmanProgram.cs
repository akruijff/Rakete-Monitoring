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
            var word = words[random.Next(words.Count)];
            var game = new Hangman(word, LIVES);

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
