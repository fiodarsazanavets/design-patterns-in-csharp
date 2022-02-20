namespace Adapter_Demo;

internal interface IBritishElectricSocket : IElectricSocket
{
    void ConnectThreePins();
}

internal class BritishElectricSocket : IBritishElectricSocket
{
    public void ConnectThreePins()
    {
        Console.WriteLine("Triple-pin plug has been successfully connected.");
    }
}