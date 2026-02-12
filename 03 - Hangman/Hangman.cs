using System.Text;

namespace _03___Hangman
{
    internal class Hangman
    {
        private string secretWord;
        private string guessedLetters = "";
        private int lives;

        public Hangman(string secretWord, int lives)
        {
            this.secretWord = secretWord;
            this.lives = lives;
        }

        internal void Guess(char letter)
        {
            if (secretWord.Contains(letter))
                guessedLetters += letter;
            else
                --lives;
        }

        internal bool IsGameOver()
        {
            return lives <= 0;
        }

        internal String Status()
        {
            StringBuilder builder = new StringBuilder(secretWord.Length * 2);
            foreach (char c in secretWord)
                builder.Append("_ ");
            return builder.ToString().TrimEnd();
        }
    }
}