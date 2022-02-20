using Adapter_Demo;

var socketPlug = new EuropeanSocketPlug();
socketPlug.SelectSocket(new EuropeanElectricSocket());
socketPlug.ConnectToSocket();

var adapter = new SocketAdapter();
adapter.SelectSocket(new BritishElectricSocket());
adapter.ConnectToSocket();

socketPlug.SelectSocket(adapter);
socketPlug.ConnectToSocket();

Console.ReadKey();