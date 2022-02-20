namespace Adapter_Demo
{
    internal class SocketAdapter : IEuropeanElectricSocket, ISocketPlug
    {
        private IBritishElectricSocket? britishSocket;

        public void ConnectToSocket()
        {
            britishSocket?.ConnectThreePins();
        }

        public void ConnectTwoPins()
        {
            Console.WriteLine("Double-pin plug has been successfully connected to the adapter.");
        }

        public void SelectSocket(IElectricSocket socket)
        {
            if (socket is not IBritishElectricSocket)
            {
                throw new ArgumentException("The adapter can only be connected to a British socket.");
            }

            britishSocket = (IBritishElectricSocket) socket;
        }
    }
}
