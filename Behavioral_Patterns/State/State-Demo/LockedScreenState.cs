namespace State_Demo;

internal class LockedScreenState : IMobilePhoneState
{
    public List<string> GetAppNames()
    {
        Console.WriteLine("Cannot get apps in a locked state.");
        return [];
    }

    public string? GetCurrentApp()
    {
        Console.WriteLine("Cannot get the current app in a locked state.");
        return null;
    }

    public void PressHomeButton()
    {
        Console.WriteLine("Please enter screen unlock PIN.");
    }

    public void SelectApp(string appName)
    {
        Console.WriteLine("Cannot select an app in a locked state.");
    }
}