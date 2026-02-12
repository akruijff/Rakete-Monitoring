using System.Text;

namespace _03___Hangman
{
    public class Hangman
    {
        private string secretWord;
        private string guessedLetters = "";
        private int lives;

        public Hangman(string secretWord, int lives)
        {
            this.secretWord = secretWord;
            this.lives = lives;
        }

        public void Guess(string letter)
        {
            if (secretWord.Contains(letter))
                guessedLetters += letter;
            else
                --lives;
        }

        public bool IsGameOver()
        {
            return lives <= 0 || IsGameWon();
        }

        public bool IsGameWon()
        {
            foreach (char c in secretWord)
                if (!guessedLetters.Contains(c))
                    return false;
            return true;
        }

        public String Status()
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