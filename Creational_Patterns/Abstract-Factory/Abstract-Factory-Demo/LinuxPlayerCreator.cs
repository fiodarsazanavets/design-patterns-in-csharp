namespace Abstract_Factory_Demo;

internal class LinuxPlayerCreator : PlayerCreator
{
    public override PlayButton CreatePlayButton()
    {
        return new LinuxPlayButton();
    }

    public override StopButton CreateStopButton()
    {
        return new LinuxStopButton();
    }
}