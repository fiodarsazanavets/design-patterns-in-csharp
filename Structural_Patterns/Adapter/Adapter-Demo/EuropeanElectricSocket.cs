namespace Adapter_Demo;

internal class EuropeanElectricSocket : IEuropeanElectricSocket
{
    public void ConnectTwoPins()
    {
        Console.WriteLine("Double-pin plug has been successfully connected.");
    }
}