namespace Proxy_Demo;

internal class DataService : IDataService
{
    private readonly List<string> data;

    public DataService()
    {
        data = [];
    }

    public async Task<List<string>> GetData()
    {
        // Simulate long-running process
        await Task.Delay(3000);
        return data;
    }

    public void InsertData(string item)
    {
        data.Add(item);
    }
}