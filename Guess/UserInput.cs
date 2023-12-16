public interface IUserInput
{
    public int ReadNumberGuess();
}

public class UserInput : IUserInput
{
    public int ReadNumberGuess()
    {
        Console.Write("Give me your guess: ");
        int guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You have given me: " + guess);
        return guess;
    }
}
