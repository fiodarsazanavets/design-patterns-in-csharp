namespace Decorator_Demo;

internal class PowerDrill : IPowerDrill
{
    private int powerUnits = 0;

    public void Recharge()
    {
        powerUnits = 6;
    }

    public bool Drill()
    {
        if (powerUnits > 0)
        {
            Console.WriteLine("Drill used.");
            powerUnits--;
            return true;
        }

        Console.WriteLine("Out of power.");
        return false;
    }
}