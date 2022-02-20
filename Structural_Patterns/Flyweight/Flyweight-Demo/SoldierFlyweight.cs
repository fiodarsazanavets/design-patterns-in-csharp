namespace Flyweight_Demo;

internal class SoldierFlyweight
{
    public SoldierFlyweight(string soldierType,
        int experienceLevel,
        int speed,
        int strength)
    {
        SoldierType = soldierType;
        ExperienceLevel = experienceLevel;
        Speed = speed;
        Strength = strength;
    }

    public string SoldierType { get; set; }
    public int ExperienceLevel { get; set; }
    public int Speed { get; set; }
    public int Strength { get; set; }

    public void Eliminate(int soldierId)
    {
        Console.WriteLine($"{SoldierType} {soldierId} has been eliminated.");
    }
}