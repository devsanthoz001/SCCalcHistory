public partial class CalcHistoryTests
{
    [Fact]
    public void CheckIfHistoryIsCreatedForAdditionTest()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        calculator.Add(2, 3);
        calculator.Subtract(5, 3);
        var calculatorHistory = calculator.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
    }

    [Fact]
    public void CheckIfHistoryIsCorrectForAdd1And1Test()
    {
        //Arrange
        Calculator calculatorAdd1And1 = new Calculator();
        //Act
        calculatorAdd1And1.Add(1, 1);
        var calculatorHistory = calculatorAdd1And1.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("1,+,1", calculatorHistory);
    }

    [Fact]
    public void CheckIfHistoryIsCorrectForSubtract1And1Test()
    {
        //Arrange
        Calculator calculatorSubtract1And1 = new Calculator();
        //Act
        calculatorSubtract1And1.Subtract(1, 1);
        var calculatorHistory = calculatorSubtract1And1.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("1,-,1", calculatorHistory);
    }
     [Fact]
    public void CheckIfHistoryIsCorrectForAdd1And1TwiceTest()
    {
        //Arrange
        Calculator calculatorAdd1And1 = new Calculator();
        //Act
        calculatorAdd1And1.Add(1, 1);
        calculatorAdd1And1.Add(1, 1);
        var calculatorHistory = calculatorAdd1And1.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("1,+,1,=,1,+,1", calculatorHistory);
    }

    [Fact]
    public void CheckIfHistoryIsCorrectForDivide8And2Test()
    {
        //Arrange
        Calculator calculatorDivide8And2 = new Calculator();
        //Act
        calculatorDivide8And2.Divide(8, 2);
        var calculatorHistory = calculatorDivide8And2.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("8,/,2", calculatorHistory);
    }
    [Fact]
    public void CheckIfHistoryIsCorrectForMultiply6And2Test()
    {
        //Arrange
        Calculator calculatorMultiply6And2 = new Calculator();
        //Act
        calculatorMultiply6And2.Multiply(6, 2);
        var calculatorHistory = calculatorMultiply6And2.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("6,*,2", calculatorHistory);
    }

}