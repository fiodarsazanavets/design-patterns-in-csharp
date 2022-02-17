namespace Builder_Demo;

internal class LinuxPlayerBuilder : IPlayerBuilder
{
    private readonly Player player = new Player();

    public void AddPlayButton()
    {
        player.PlayButton = new LinuxPlayButton();
    }

    public void AddStopButton()
    {
        player.StopButton = new LinuxStopButton();
    }

    public Player BuildPlayer()
    {
        return player;
    }
}