public class Game
{
    public Game(int minTarget, int maxTarget, IUserInput userInput, int maxGuesses)
    {
        _minTarget = minTarget;
        _maxTarget = maxTarget;
        _userInput = userInput;
        _maxGuesses = maxGuesses;
    }

    public bool Play()
    {
        bool correctGuess = false;
        Random rnd = new Random();
        int target = rnd.Next(_minTarget, _maxTarget + 1);
        Console.WriteLine(
            $"I thought of a number between {_minTarget} and {_maxTarget}, can you guess it?\n" +
            $"You can guess {_maxGuesses} times"
        );

        int guesses = 0;

        while (!correctGuess && guesses < _maxGuesses)
        {
            int guess = _userInput.ReadNumberGuess();
            guesses++;

            if (guess > target) // ez lehetne functional linq style https://www.milanjovanovic.tech/blog/how-to-apply-functional-programming-in-csharp
            {
                Console.WriteLine("Too big!");
            }
            else if (guess < target)
            {
                Console.WriteLine("Too small!");
            }
            else
            {
                Console.WriteLine("You win!");
                correctGuess = true;
            }
        }

        if (correctGuess)
            return true;

        Console.WriteLine("You ran out of guesses");
        return false;
    }

    private readonly int _minTarget;
    private readonly int _maxTarget;
    private readonly int _maxGuesses;
    private readonly IUserInput _userInput;
}