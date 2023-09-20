public class SubtractionTests
{
    [Fact]
    public void CheckIf65Minus15Is50Test()
    {
         //Arrange
        Calculator subtractionCalculator = new Calculator();
        //Act
        int resultOf1and1 = subtractionCalculator.Subtract(65, 15);
        //Assert
        Assert.Equal(50, resultOf1and1);

    }
    [Fact]
    public void CheckIf25Minus25Is0Test()
    {
         //Arrange
        Calculator subtractionCalculator = new Calculator();
        //Act
        int resultOf1and1 = subtractionCalculator.Subtract(25, 25);
        //Assert
        Assert.Equal(0, resultOf1and1);

    }
    [Fact]
    public void CheckIf80Minus20Is60Test()
    {
         //Arrange
        Calculator subtractionCalculator = new Calculator();
        //Act
        int resultOf1and1 = subtractionCalculator.Subtract(80, 20);
        //Assert
        Assert.Equal(60, resultOf1and1);

    }
}   
