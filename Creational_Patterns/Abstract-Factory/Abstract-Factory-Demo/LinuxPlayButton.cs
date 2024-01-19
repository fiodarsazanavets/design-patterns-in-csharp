namespace Abstract_Factory_Demo;

internal class LinuxPlayButton : PlayButton
{
    public override Task Play(string fileName)
    {
        Console.WriteLine("Playing audio via the following command:");
        Console.WriteLine($"mpg123 -q '{fileName}'");

        // Uncomment for testing on a real device
        // LinuxPlayerUtility.StartBashProcess($"mpg123 -q '{fileName}'");
        return Task.CompletedTask;
    }
}