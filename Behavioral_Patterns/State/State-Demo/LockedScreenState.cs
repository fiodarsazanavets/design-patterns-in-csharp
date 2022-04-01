namespace State_Demo;

internal class LockedScreenState : IMobilePhoneState
{
    public void PressHomeButton()
    {
        Console.WriteLine("Please enter screen unlock PIN.");
    }
}