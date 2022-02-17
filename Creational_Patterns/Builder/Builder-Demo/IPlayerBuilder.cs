namespace Builder_Demo;

internal interface IPlayerBuilder
{
    void AddPlayButton();
    void AddStopButton();
    Player BuildPlayer();
}