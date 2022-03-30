namespace Adapter_Demo;

internal class EuropeanSocketPlug : ISocketPlug
{
    private IEuropeanElectricSocket? europeanSocket;

    public void ConnectToSocket()
    {
        europeanSocket?.ConnectTwoPins();
    }

    public void SelectSocket(IElectricSocket socket)
    {
        if (socket is not IEuropeanElectricSocket)
        {
            throw new ArgumentException("The European plug can only be connected to a European socket.");
        }

        europeanSocket = (IEuropeanElectricSocket)socket;
    }
}