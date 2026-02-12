using System.Text;

namespace _03___Hangman
{
    internal class Hangman
    {
        private string secretWord;
        private int lives;

        public Hangman(string secretWord, int lives)
        {
            this.secretWord = secretWord;
            this.lives = lives;
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