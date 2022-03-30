namespace Command_Demo;

internal class DeleteCommand : Command
{
    private string key;

    public DeleteCommand(string key,
        DataReceiver receiver) : base(receiver)
    {
        this.key = key;
    }

    public override void Execute()
    {
        receiver.Delete(key);
    }
}