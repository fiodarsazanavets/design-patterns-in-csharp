namespace Abstract_Factory_Demo;

internal abstract class PlayerCreator
{
    public abstract PlayButton CreatePlayButton();
    public abstract StopButton CreateStopButton();
}