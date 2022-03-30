namespace Command_Demo;

internal abstract class Command : ICommand
{
    protected DataReceiver receiver;

    public Command(DataReceiver receiver)
    {
        this.receiver = receiver;
    }

    public abstract void Execute();
}