namespace Command_Demo;

internal class DataReceiver
{
    private readonly Dictionary<string,string> data;

    public DataReceiver()
    {
        data = [];
    }

    public void Upsert(string key, string value)
    {
        data[key] = value;
        Console.WriteLine($"Upserted: {key} - {value}.");
    }

    public void Delete(string key)
    {
        data.Remove(key);
        Console.WriteLine($"Removed: {key}.");
    }
}