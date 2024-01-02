namespace Flyweight_Demo;

internal class SoldierFlyweight(string soldierType,
    int experienceLevel,
    int speed,
    int strength)
{
    public string SoldierType { get; set; } = soldierType;
    public int ExperienceLevel { get; set; } = experienceLevel;
    public int Speed { get; set; } = speed;
    public int Strength { get; set; } = strength;

    public void Eliminate(int soldierId)
    {
        Console.WriteLine($"{SoldierType} {soldierId} has been eliminated.");
    }
}