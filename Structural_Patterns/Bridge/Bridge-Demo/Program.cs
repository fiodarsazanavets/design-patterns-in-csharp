﻿using Bridge_Demo;

var bridgeInterface = new BridgeInterface();
bridgeInterface.Implementation = new DataService();

Console.WriteLine("Inserting item 1 into data service");
bridgeInterface.InsertData("item 1");
Console.WriteLine("Inserting item 2 into data service");
bridgeInterface.InsertData("item 2");
Console.WriteLine("Inserting item 3 into data service");
bridgeInterface.InsertData("item 3");

Console.WriteLine("Retrieving data from the service:");
bridgeInterface.GetData();

Console.ReadLine();