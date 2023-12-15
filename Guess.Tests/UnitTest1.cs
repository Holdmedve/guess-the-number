using Guess;

namespace Guess.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true, "true");
    }

    [Theory]
    [InlineData(10, true)]
    [InlineData(11, false)]
    public void IsEven(int input, bool expected)
    {
        var Guess = new Guess();

        bool result = Guess.IsEven(n: input);

        Assert.Equal(result, expected);
    }
}