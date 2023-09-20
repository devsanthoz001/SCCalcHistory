public partial class Calculator
{
    string calculatorHistory = "";
    public int Add(int number1, int number2)
    {
        SaveHistory(number1, number2, "+");
        return number1 + number2;
    }

    private void SaveHistory(int number1, int number2, string operation)
    {
        if (calculatorHistory == "")
        {
            calculatorHistory = calculatorHistory + $"{number1},{operation},{number2}";
        }
        else
        {
            calculatorHistory = calculatorHistory + ",=," + $"{number1},{operation},{number2}";
        }
    }

    public int Subtract(int number1, int number2)
    {
        SaveHistory(number1, number2, "-");
        return number1 - number2;
    }

     public int Multiply(int number1, int number2)
    {
        SaveHistory(number1, number2, "*");
        return number1 * number2;
    }
     public int Divide(int number1, int number2)
    {
        SaveHistory(number1, number2, "/");
        return number1 / number2;
    }
    public string GetHistory()
    {
        return calculatorHistory;
    }
}