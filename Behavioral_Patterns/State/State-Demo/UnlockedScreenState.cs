namespace State_Demo;

internal class UnlockedScreenState : IMobilePhoneState
{
    private readonly List<string> appNames;

    private string? currentApp;

    public UnlockedScreenState()
    {
        appNames =
        [
            "Notes",
            "Solitaire",
            "Calendar",
            "Contacts"
        ];

        currentApp = null;
    }

    public List<string> GetAppNames()
    {
        return appNames;
    }

    public string? GetCurrentApp()
    {
        return currentApp;
    }

    public void PressHomeButton()
    {
        Console.WriteLine("Home screen has been opened.");
    }

    public void SelectApp(string appName)
    {
        if (appNames.Contains(appName))
        {
            currentApp = appName;
            Console.WriteLine($"App '{appName}' selected.");
        }
        else
        {
            Console.WriteLine($"App '{appName}' doesn't exist.");
        }
    }
}