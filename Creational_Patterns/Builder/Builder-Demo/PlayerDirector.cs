namespace Builder_Demo;

internal class PlayerDirector
{
    public Player BuildPlayer(IPlayerBuilder builder)
    {
        builder.AddPlayButton();
        builder.AddStopButton();
        return builder.BuildPlayer();
    }
}