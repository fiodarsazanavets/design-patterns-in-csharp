namespace Flyweight_Demo;

internal class FlyweightFactory
{
    private Dictionary<string, SoldierFlyweight> flyweights;

    public FlyweightFactory()
    {
        flyweights = new();
        flyweights["Militiaman"] = new SoldierFlyweight("Militiaman", 1, 1, 1);
        flyweights["Soldier"] = new SoldierFlyweight("Soldier", 2, 1, 2);
        flyweights["Knight"] = new SoldierFlyweight("Soldier", 10, 5, 5);
    }

    public SoldierFlyweight GetFlyweight(string key)
    {
        return flyweights[key];
    }
}