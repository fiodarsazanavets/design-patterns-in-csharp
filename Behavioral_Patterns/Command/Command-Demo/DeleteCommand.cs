namespace Command_Demo;

internal class DeleteCommand(string key,
    DataReceiver receiver) : Command(receiver)
{
    public override void Execute()
    {
        receiver.Delete(key);
    }
}