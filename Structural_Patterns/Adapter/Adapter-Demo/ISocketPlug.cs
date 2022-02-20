namespace Adapter_Demo;

internal interface ISocketPlug
{
    void SelectSocket(IElectricSocket socket);
    void ConnectToSocket();
}