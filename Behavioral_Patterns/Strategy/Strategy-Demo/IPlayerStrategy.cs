namespace Strategy_Demo;

internal interface IPlayerStrategy
{
    Task Play(string fileName);
}