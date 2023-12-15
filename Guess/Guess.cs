namespace Guess;

public enum GameState
{
    Play,
    Won
}

public class UserInput
{
    public int ReadNumberGuess()
    {
        Console.Write("Give me your guess: ");
        int guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You have given me: " + guess);
        return guess;
    }
}

public class Game
{
    private readonly int MIN;
    private readonly int MAX;
    public Game(int min, int max)
    {
        MIN = min;
        MAX = max;
    }

    public void Play()
    {
        UserInput userInput = new UserInput();
        const int MIN = 1;
        const int MAX = 100;

        bool correctGuess = false;
        Random rnd = new Random();
        int target = rnd.Next(MIN, MAX + 1);
        Console.WriteLine($"I thought of a number between {MIN} and {MAX}, can you guess it?");

        while (!correctGuess)
        {
            int guess = userInput.ReadNumberGuess();

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
    }
}


public class Guess
{
    public static void Main()
    {
        var game = new Game(min: 1, max: 100);
        game.Play();
    }

    public bool IsEven(int n)
    {
        return n % 2 == 0;
    }

}
