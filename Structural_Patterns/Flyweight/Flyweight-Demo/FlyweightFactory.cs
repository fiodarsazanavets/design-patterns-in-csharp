﻿namespace Flyweight_Demo;

internal class FlyweightFactory
{
    private readonly Dictionary<string, SoldierFlyweight> flyweights;

    public FlyweightFactory()
    {
        flyweights = new()
        {
            ["Militiaman"] = new SoldierFlyweight("Militiaman", 1, 1, 1),
            ["Soldier"] = new SoldierFlyweight("Soldier", 2, 1, 2),
            ["Knight"] = new SoldierFlyweight("Soldier", 10, 5, 5)
        };
    }

    public SoldierFlyweight GetFlyweight(string key)
    {
        return flyweights[key];
    }
}