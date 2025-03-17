using Xunit;
using CalculatorLibrary;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        var calculator = new Calculator();
        var result = calculator.Add(5, 3);
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        var calculator = new Calculator();
        var result = calculator.Subtract(10, 4);
        Assert.Equal(6, result);
    }
}
