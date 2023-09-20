public class MultiplicationTests
{
    [Fact]
    public void CheckIf2Multiply2Is4Test()
    {
         //Arrange
        Calculator multiplicationCalculator = new Calculator();
        //Act
        int resultOf1and1 = multiplicationCalculator.Multiply(2,2);
        //Assert
        Assert.Equal(4, resultOf1and1);

    }
    [Fact]
    public void CheckIf5Multiply2Is10Test()
    {
         //Arrange
        Calculator multiplicationCalculator = new Calculator();
        //Act
        int resultOf1and1 = multiplicationCalculator.Multiply(5, 2);
        //Assert
        Assert.Equal(10, resultOf1and1);

    }
    [Fact]
    public void CheckIf80Multiply10Is800Test()
    {
         //Arrange
        Calculator multiplicationCalculator = new Calculator();
        //Act
        int resultOf1and1 = multiplicationCalculator.Multiply(80, 10);
        //Assert
        Assert.Equal(800, resultOf1and1);

    }

}