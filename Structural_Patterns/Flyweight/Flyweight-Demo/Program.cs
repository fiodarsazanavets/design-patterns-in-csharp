using Flyweight_Demo;

var factory = new FlyweightFactory();
var army = new Dictionary<int, SoldierFlyweight>();

Console.WriteLine("Adding militiamen to the army.");
for (var i = 0; i < 1000; i++)
{
    army[i] = factory.GetFlyweight("Militiaman");
}

Console.WriteLine("Adding soldiers to the army.");
for (var i = 0; i < 100; i++)
{
    army[i + 1000] = factory.GetFlyweight("Soldier");
}

Console.WriteLine("Adding knights to the army.");
for (var i = 0; i < 10; i++)
{
    army[i + 1100] = factory.GetFlyweight("Knight");
}

Console.WriteLine($"Total army size is {army.Count}.");

Console.ReadKey();