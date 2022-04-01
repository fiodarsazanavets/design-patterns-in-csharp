namespace Factory_Method_Demo;

internal class LinuxPlayerCreator : PlayerCreator
{
    public override Player CreatePlayer()
    {
        return new LinuxPlayer();
    }
}