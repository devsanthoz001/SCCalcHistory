using System.ComponentModel;
using ProjectCalculator;

namespace ComputerUI.Pages;
public partial class CalculatorUI
{
    // DH
    // 1 + 1 =
    // 1 - 1 =
    // 2 * 5 =
    // 5 / 5 =

    // LN 0  |  1   |   1
    // CK 1  |  +   |   1
    // CO    |  +   |   
    // EQ 1  |  1 + |   1 + 1
    // 1 + 1

    // 12 + 2 =
    // 123 - 22 =

    //      LN  CK  CO  EQ
    // 1    0   1       1
    // 2    1   2       12
    // +    12  +   +   12 +
    // 2    12  2   +   12 + 2
    // = 

    const string PLUS = "+";
    const string MULTIPLY = "*";
    const string MINUS = "-";
    const string DIVIDE = "/";


    Calculator calculatorInstance = new Calculator();
    public bool HasStarted = false;
    public string LastNumber { get; set; } = string.Empty;
    public string RunningTotal { get; set; } = string.Empty;
    public string CurrentKeyPress { get; set; } = string.Empty;
    public string Equation { get; set; } = string.Empty;
    public string LastPressedKey { get; set; } = string.Empty;
    public string RecentOperator { get; set; } = string.Empty;
    public string Total { get; set; } = string.Empty;

    public void DeleteCalculatorHistory()
    {
        RunningTotal = "0";
        CurrentKeyPress = string.Empty;
        Equation = string.Empty;
        LastPressedKey = string.Empty;
        RecentOperator = string.Empty;
        LastNumber = string.Empty;
        Total = string.Empty;
        HasStarted = false;
    }
    public void ClearUserEntry()
    {
        CurrentKeyPress = string.Empty;
    }

    public void ButtonPressedNumber(string buttonNumber)
    {
        if (HasStarted)
        {
            LastNumber = Equation;
            Equation = Equation + " " + buttonNumber;            
            CurrentKeyPress = buttonNumber;
        }
        else
        {
            LastNumber = "0";
            HasStarted = true;
            Equation = buttonNumber;
            CurrentKeyPress = buttonNumber;
        }
        
    }

    public void ButtonPressedOperator(string buttonOperation)
    {
        if (HasStarted)
        {
            LastNumber = CurrentKeyPress;
            RecentOperator = buttonOperation;
            CurrentKeyPress = buttonOperation;
            Equation = LastNumber + " " + buttonOperation;
        }
        else
        {
            return;
        }
    }
    public void ButtonPressedOperatorEqualTo()
    {
        // EQ 1 + 1
        // Split on space
        var arrayOfNumbers = Equation.Split(" ");
        //   0    1    2
        // ["1"]["+"]["1"]
        if (arrayOfNumbers[1] == PLUS)
        {
            RunningTotal = calculatorInstance.Add(Convert.ToInt32(arrayOfNumbers[0]), Convert.ToInt32(arrayOfNumbers[2])).ToString();
        }
        else if (arrayOfNumbers[1] == MINUS)
        {
            RunningTotal = calculatorInstance.Subtract(Convert.ToInt32(arrayOfNumbers[0]), Convert.ToInt32(arrayOfNumbers[2])).ToString();
        }
        else if (arrayOfNumbers[1] == MULTIPLY)
        {
            RunningTotal = calculatorInstance.Multiply(Convert.ToInt32(arrayOfNumbers[0]), Convert.ToInt32(arrayOfNumbers[2])).ToString();
        }
        else if (arrayOfNumbers[1] == DIVIDE)
        {
            RunningTotal = calculatorInstance.Divide(Convert.ToInt32(arrayOfNumbers[0]), Convert.ToInt32(arrayOfNumbers[2])).ToString();
        }
    }
}