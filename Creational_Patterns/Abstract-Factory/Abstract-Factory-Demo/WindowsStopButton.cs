namespace Abstract_Factory_Demo;

internal class WindowsStopButton : StopButton
{
    public override Task Stop(string fileName)
    {
        WindowsPlayerUtility.ExecuteMciCommand($"Stop {fileName}");
        return Task.CompletedTask;
    }
}