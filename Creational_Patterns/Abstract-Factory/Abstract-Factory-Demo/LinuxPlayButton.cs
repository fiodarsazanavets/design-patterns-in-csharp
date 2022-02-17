namespace Abstract_Factory_Demo;

internal class LinuxPlayButton : PlayButton
{
    public override Task Play(string fileName)
    {
        LinuxPlayerUtility.StartBashProcess($"mpg123 -q '{fileName}'");
        return Task.CompletedTask;
    }
}