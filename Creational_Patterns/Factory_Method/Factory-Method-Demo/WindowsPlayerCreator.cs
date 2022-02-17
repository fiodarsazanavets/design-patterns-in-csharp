namespace Factory_Method_Demo;

internal class WindowsPlayerCreator : PlayerCreator
{
    public override Player CreatePlayer()
    {
        return new WindowsPlayer();
    }
}