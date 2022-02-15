using Xunit;

namespace CalculatorLibUnitTests;

public class CalculatorUnitTests
{
    [Fact]
    public void TestAddingWithError2And2()
    {
        // Arrage
        double a = 2;
        double b = 2;
        double expected = 4;
        var calculator = new global::Calculator.Calculator();
        
        // Act
        double actual = calculator.AddWithError(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void TestAddingWithError2And3()
    {
        // Arrage
        double a = 2;
        double b = 3;
        double expected = 5;
        var calculator = new global::Calculator.Calculator();
        
        // Act
        double actual = calculator.AddWithError(a, b);

        // Assert
        // Assert.Equal(expected, actual);
        Assert.NotEqual(expected, actual);
    }
    
    [Fact]
    public void TestAdding2And2()
    {
        // Arrage
        double a = 2;
        double b = 2;
        double expected = 4;
        var calculator = new global::Calculator.Calculator();
        
        // Act
        double actual = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void TestAdding2And3()
    {
        // Arrage
        double a = 2;
        double b = 3;
        double expected = 5;
        var calculator = new global::Calculator.Calculator();
        
        // Act
        double actual = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }
}