public class DivisionTests
{
    [Fact]
    public void CheckIf10Divide2Is5Test()
    {
         //Arrange
        Calculator divisionCalculator = new Calculator();
        //Act
        int resultOf1and1 = divisionCalculator.Divide(10,2);
        //Assert
        Assert.Equal(5, resultOf1and1);

    }
    [Fact]
    public void CheckIf8Divide2Is4Test()
    {
         //Arrange
        Calculator divisionCalculator = new Calculator();
        //Act
        int resultOf1and1 = divisionCalculator.Divide(8, 2);
        //Assert
        Assert.Equal(4, resultOf1and1);

    }
    [Fact]
    public void CheckIf80Divide10Is8Test()
    {
         //Arrange
        Calculator divisionCalculator = new Calculator();
        //Act
        int resultOf1and1 = divisionCalculator.Divide(80, 10);
        //Assert
        Assert.Equal(8, resultOf1and1);

    }

}