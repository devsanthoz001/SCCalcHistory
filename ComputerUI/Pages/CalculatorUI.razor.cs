using ProjectCalculator;

namespace ComputerUI.Pages;
public partial class CalculatorUI
{
    Calculator calculatorInstance = new Calculator();   
    public string UserHasTyped { get; set; } = string.Empty;
    private string lastPressedKey = string.Empty;
    public void DeleteCalculatorHistory()
    {

    }
    public void ClearUserEntry()
    {
        UserHasTyped = string.Empty;
    }

    public void UserPressedZero()
    {
        UserHasTyped = UserHasTyped + "0";
    }
    public void UserPressedOne()
    {
        UserHasTyped = UserHasTyped + "1";
    }
    public void ButtonPressedNumber(string buttonNumber)
    {       
        UserHasTyped = UserHasTyped + buttonNumber;
    }

    public void ButtonPressedOperator(string buttonOperation)
    {       
        /*
        UserPressedKey  RunningTotal    Equation
        1                   1            1       
        2                   12           12      
        +                   12           12+
        3                   3            12+3    
        4                   34           23+34
        -                   57           57-
        2                   57           57-2
        7                   57           57-27
        =                   30
        
        
        
        */               
    }

}