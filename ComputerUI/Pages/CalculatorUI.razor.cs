namespace ComputerUI.Pages;
public partial class CalculatorUI
{
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
    public void ButtonPressed(string buttonOperation)
    {       
        UserHasTyped = UserHasTyped + buttonOperation;
    }

}