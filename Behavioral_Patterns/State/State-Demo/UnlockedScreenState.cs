namespace State_Demo;

internal class UnlockedScreenState : IMobilePhoneState
{
    public void PressHomeButton()
    {
        Console.WriteLine("Home screen has been opened.");
    }
}