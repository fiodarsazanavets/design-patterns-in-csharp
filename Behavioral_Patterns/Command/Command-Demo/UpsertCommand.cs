namespace Command_Demo;

internal class UpsertCommand : Command
{
    private readonly string key;
    private readonly string value;

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