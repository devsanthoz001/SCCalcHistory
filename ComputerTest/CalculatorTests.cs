namespace ComputerTest;

public class CalculatorTests
{
    [Fact]
    public void Check1Plus1Is2Test()
    {
        //Arrange
        Calculator additionCalculator = new Calculator();
        //Act
        int resultOf1and1 = additionCalculator.Add(1, 1);
        //Assert
        Assert.Equal(2, resultOf1and1);
    }

    [Fact]
    public void Check1Plus15Is16Test()
    {
        //Arrange
        Calculator additionCalculator = new Calculator();
        //Act
        int resultOf1and1 = additionCalculator.Add(1, 15);
        //Assert
        Assert.Equal(16, resultOf1and1);
    }
}