namespace Guess.Tests;

public class GameTest
{
    class StubUserInput : IUserInput
    {
        private readonly int[] _inputs;
        private int idx;
        public StubUserInput(int[] inputs)
        {
            _inputs = inputs;
            idx = 0;
        }

        public int ReadNumberGuess()
        {
            int input = _inputs[idx];
            idx++;
            return input;
        }
    }

    [Fact]
    public void Game_GuessWithinRange_Win()
    {
        var stubUserInput = new StubUserInput(inputs: new[] { 1, 2, 3 });
        Game game = new Game(minTarget: 1, maxTarget: 3, userInput: stubUserInput, maxGuesses: 3);

        var result = game.Play();

        Assert.True(result);
    }

    [Fact]
    public void Game_GuessOutsideRange_Loose()
    {
        var stubUserInput = new StubUserInput(inputs: new[] { 1, 2, 3 });
        Game game = new Game(minTarget: 10, maxTarget: 30, userInput: stubUserInput, maxGuesses: 3);

        var result = game.Play();

        Assert.False(result);
    }
}