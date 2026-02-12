using System.Text;

namespace _03___Hangman
{
    public class Hangman
    {
        private string secretWord;
        private string guessedLetters = "";
        private string wrongLetters = "";
        private int lives;

        public Hangman(string secretWord, int lives)
        {
            this.secretWord = secretWord.ToLower();
            this.lives = lives;

            foreach (char c in secretWord)
                if (!char.IsLetter(c))
                    guessedLetters += c;
        }

        public void Guess(string letters)
        {
            letters = letters.ToLower();
            foreach (char c in letters)
                Guess(c);
        }

        public void Guess(char letter)
        {
            if (lives == 0)
                throw new InvalidOperationException("game over");
            if (secretWord.Contains(letter))
                guessedLetters += letter;
            else if (!wrongLetters.Contains(letter))
            {
                wrongLetters += letter;
                --lives;
            }
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