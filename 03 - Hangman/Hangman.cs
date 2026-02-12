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

        internal void Guess(string letter)
        {
            if (secretWord.Contains(letter))
                guessedLetters += letter;
            else
                --lives;
        }

        internal bool IsGameOver()
        {
            return lives <= 0 || IsGameWon();
        }

        internal bool IsGameWon()
        {
            foreach (char c in secretWord)
                if (!guessedLetters.Contains(c))
                    return false;
            return true;
        }

        internal String Status()
        {
            StringBuilder builder = new StringBuilder(secretWord.Length * 2);
            foreach (char c in secretWord)
                builder
                    .Append(guessedLetters.Contains(c) ? c : '_')
                    .Append(" ");
            return builder.ToString().TrimEnd();
        }
    }
}