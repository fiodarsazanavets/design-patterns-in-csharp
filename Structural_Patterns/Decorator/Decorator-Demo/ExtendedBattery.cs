namespace Decorator_Demo;

internal class ExtendedBattery : PowerDrillDecorator
{
    private int extraPower = 0;

    public override void Recharge()
    {
        base.Recharge();
        extraPower = 6;
    }

    public override bool Drill()
    {
        if (!base.Drill())
        {
            if (extraPower > 0)
            {
                Console.WriteLine("Extended battery used.");
                extraPower--;
                return true;
            }

            return false;
        }

        return true;
    }
}