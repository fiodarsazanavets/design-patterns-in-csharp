namespace BridgeImplementation;

public class DataService : IDataService
{
    private readonly List<string> data;

    public DataService()
    {
        data = [];
    }

    public List<string> GetData()
    {
        return data;
    }

    public void InsertData(string item)
    {
        data.Add(item);
    }
}