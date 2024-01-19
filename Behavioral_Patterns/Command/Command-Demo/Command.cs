namespace Command_Demo;

internal abstract class Command(DataReceiver receiver) : ICommand
{
    protected DataReceiver receiver = receiver;

    public abstract void Execute();
}