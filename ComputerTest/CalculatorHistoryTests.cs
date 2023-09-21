namespace ComputerTest;

public partial class CalculatorHistoryTests
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
    [Fact]
    public void CheckIfHistoryIsCorrectForMultiply10And40Test()
    {
        //Arrange
        Calculator calculatorMultiply6And2 = new Calculator();
        //Act
        calculatorMultiply6And2.Multiply(10, 40);
        var calculatorHistory = calculatorMultiply6And2.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("10,*,40", calculatorHistory);
    }   

    [Fact]
    public void CheckIfHistoryIsCorrectForMultiply16And2Test()
    {
        //Arrange
        Calculator calculatorMultiply6And2 = new Calculator();
        //Act
        calculatorMultiply6And2.Multiply(16, 2);
        var calculatorHistory = calculatorMultiply6And2.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("16,*,2", calculatorHistory);
    }
    [Fact]
    public void CheckIfHistoryIsCorrectForDivide18And4Test()
    {
        //Arrange
        Calculator calculatorDivide8And2 = new Calculator();
        //Act
        calculatorDivide8And2.Divide(18, 4);
        var calculatorHistory = calculatorDivide8And2.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("18,/,4", calculatorHistory);
    }   
    [Fact]
    public void CheckIfHistoryIsCorrectForDivide25And5Test()
    {
        //Arrange
        Calculator calculatorForDivide25And5 = new Calculator();
        //Act
        int resultOf25bY5 = calculatorForDivide25And5.Divide(25, 5);
        var calculatorHistory = calculatorForDivide25And5.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal(5,resultOf25bY5);
        Assert.Equal("25,/,5", calculatorHistory);
    }



    [Fact]
    public void CheckLongHistoryTest()
    {
        // You are a bus driver
        // From Stop 
        // 1    0   5
        // 2    0  10
        // 3    4   5
        // 4    10  3
        // 5    5   1
        // 6    
        // Total    
        //  0    -0 + 5
        //  5    -0 + 10
        //  15   -4 + 5
        //  16  -10 + 3
        //  9   -5 + 1
        //  5   -5 + 0

        //Arrange
        Calculator calculatorLongHistory = new Calculator();
        //Act
        calculatorLongHistory.Add(0,5);
        calculatorLongHistory.Subtract(5,0);
        calculatorLongHistory.Add(5,10);
        calculatorLongHistory.Subtract(15,4);
        calculatorLongHistory.Add(11,5);
        calculatorLongHistory.Subtract(5,2);
        var calculatorHistory = calculatorLongHistory.GetHistory();
        //Assert
         
        Assert.NotNull(calculatorHistory);
        //Assert.Equal(5,resultOf25bY5);
        Assert.Equal("0,+,5,=,5,-,0,=,5,+,10,=,15,-,4,=,11,+,5,=,5,-,2", calculatorHistory);
    }
}