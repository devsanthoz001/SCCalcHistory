using ProjectCalculator;

public partial class AdditionTests
{
    [Fact]
    public void CheckIf65Plus15Is80Test()
    {
         //Arrange
        Calculator additionCalculator = new Calculator();
        //Act
        int resultOf1and1 = additionCalculator.Add(15, 65);
        //Assert
        Assert.Equal(80, resultOf1and1);

    }
    [Fact]
    public void CheckIf25Pluss25Is50Test()
    {
         //Arrange
        Calculator additionCalculator = new Calculator();
        //Act
        int resultOf1and1 = additionCalculator.Add(25, 25);
        //Assert
        Assert.Equal(50, resultOf1and1);

    }
    [Fact]
    public void CheckIf80Plus20Is100Test()
    {
         //Arrange
        Calculator additionCalculator = new Calculator();
        //Act
        int resultOf1and1 = additionCalculator.Add(80, 20);
        //Assert
        Assert.Equal(100, resultOf1and1);

    }
}