namespace _03___Hangman
{
    internal class HangmanProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine();

            var game = new Hangman("banana", 5);
            Console.WriteLine(game.Status());
        }
    }
}
