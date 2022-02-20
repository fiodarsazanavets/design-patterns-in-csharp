namespace Proxy_Demo;

internal class DataServiceProxy : IDataService
{
    private readonly DataService dataService;
    private List<string>? localCache;

    public DataServiceProxy()
    {
        dataService = new DataService();
        localCache = null;
    }

    public async Task<List<string>> GetData()
    {
        Console.WriteLine($"{DateTime.Now} - Started data query.");

        if (localCache is null)
            localCache = await dataService.GetData();

        Console.WriteLine($"{DateTime.Now} - Data has been retrieved.");
        return localCache;
    }

    public void InsertData(string item)
    {
        localCache = null;
        dataService.InsertData(item);
    }
}