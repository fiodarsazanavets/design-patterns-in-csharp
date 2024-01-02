namespace State_Demo;

internal class MobilePhoneContext
{
	IMobilePhoneState state;

	public MobilePhoneContext()
	{
		state = new LockedScreenState();
	}

	public void ChangeState(IMobilePhoneState state)
    {
		this.state = state;
    }

	public void PressHomeButton()
    {
        Console.WriteLine("Pressing home button.");
        state.PressHomeButton();
    }

    public List<string> GetAppNames()
    {
        Console.WriteLine("Getting app list.");
        var apps = state.GetAppNames();
        Console.WriteLine($"{apps.Count} apps found.");
        return apps;
    }

    public string? GetCurrentApp()
    {
        Console.WriteLine("Retrieving the currently selected app.");
        var currentApp = state.GetCurrentApp();
        if (currentApp != null)
        {
            Console.WriteLine($"The currently selected app is '{currentApp}'.");
        }
        else
        {
            Console.WriteLine($"No app selected.");
        }

        return currentApp;
    }

    public void SelectApp(string appName)
    {
        Console.WriteLine("Selecting an app.");
        state.SelectApp(appName);
    }
}