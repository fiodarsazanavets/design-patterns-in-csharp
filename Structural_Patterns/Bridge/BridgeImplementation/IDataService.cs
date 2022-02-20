namespace BridgeImplementation;

public interface IDataService
{
    List<string> GetData();
    void InsertData(string item);
}