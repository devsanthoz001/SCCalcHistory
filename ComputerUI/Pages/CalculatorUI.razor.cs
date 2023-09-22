using System.ComponentModel;
using ProjectCalculator;

namespace ComputerUI.Pages;
public partial class CalculatorUI
{
    Calculator calculatorInstance = new Calculator();
    public string LastNumber { get; set; } = string.Empty;
    public string RunningTotal { get; set; } = string.Empty;
    public string UserPressedKey { get; set; } = string.Empty;
    public string Equation { get; set; } = string.Empty;
    public string LastPressedKey { get; set; } = string.Empty;
    public string OperatorEntered { get; set; } = string.Empty;
    public string Total { get; set; } = string.Empty;

    public void DeleteCalculatorHistory()
    {
        RunningTotal = "0";
        UserPressedKey = string.Empty;
        Equation = string.Empty;
        LastPressedKey = string.Empty;
        OperatorEntered = string.Empty;
        LastNumber = string.Empty;
        Total = string.Empty;
    }
    public void ClearUserEntry()
    {
        UserPressedKey = string.Empty;
    }

    public void ButtonPressedNumber(string buttonNumber)
    {        
        Equation = Equation + buttonNumber;
        LastPressedKey = UserPressedKey;
        UserPressedKey = buttonNumber;
        OperatorEntered = string.Empty;        
    }

    public void ButtonPressedOperator(string buttonOperation)
    {        
        LastNumber = Equation;
        Equation = Equation + buttonOperation;
        LastPressedKey = UserPressedKey;
        UserPressedKey = buttonOperation;
        OperatorEntered = buttonOperation;

    }
   public void ButtonPressedOperatorEqualTo()
   {
    //Calculate = Equation;
    Total = Equation;
   }
}