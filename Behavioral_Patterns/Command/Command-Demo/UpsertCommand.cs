namespace Command_Demo;

internal class UpsertCommand : Command
{
    private string key;
    private string value;

    public UpsertCommand(string key,
        string value,
        DataReceiver receiver) : base(receiver)
    {
        this.key = key;
        this.value = value;
    }

    public override void Execute()
    {
        receiver.Upsert(key, value);
    }
}