namespace Proxy_Demo;

internal interface IDataService
{
    Task<List<string>> GetData();
    void InsertData(string item);
}