namespace Abstract_Factory_Demo;

internal class WindowsPlayerCreator : PlayerCreator
{
    public override PlayButton CreatePlayButton()
    {
        return new WindowsPlayButton();
    }

    public override StopButton CreateStopButton()
    {
        return new WindowsStopButton();
    }
}