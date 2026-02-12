using _03___Hangman;

namespace tests
{
    public class HangmanTest
    {
        [Fact]
        public void A_game_without_lives_is_over()
        {
            Hangman game = new Hangman("banana", 0);
            Assert.True(game.IsGameOver());
        }

        [Fact]
        public void A_game_is_won_when_the_word_is_guessed()
        {
            Hangman game = new Hangman("banana", 3);
            game.Guess("abn");
            Assert.True(game.IsGameOver());
            Assert.True(game.IsGameWon());
        }

        [Fact]
        public void A_game_is_lost_when_lives_run_out_and_the_words_isnt_guessed()
        {
            Hangman game = new Hangman("banana", 3);
            game.Guess("xyz");
            Assert.True(game.IsGameOver());
            Assert.False(game.IsGameWon());
        }

        [Theory]
        [InlineData("a", "_ a _ a _ a")]
        [InlineData("A", "_ a _ a _ a")]
        [InlineData("b", "b _ _ _ _ _")]
        [InlineData("n", "_ _ n _ n _")]
        [InlineData("x", "_ _ _ _ _ _")]
        [InlineData("abn", "b a n a n a")]
        public void A_letter_that_is_guessed_shows_in_status(string guesses, string status)
        {
            Hangman game = new Hangman("banana", 3);
            game.Guess(guesses);
            Assert.Equal(status, game.Status());
        }
    }
}
