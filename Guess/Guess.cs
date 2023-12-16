namespace Guess;

public class Guess
{
    public static void Main()
    {
        var game = new Game(minTarget: 1, maxTarget: 10, userInput: new UserInput(), maxGuesses: 5);
        game.Play();
    }
}
