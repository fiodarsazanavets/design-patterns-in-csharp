namespace Decorator_Demo;

internal class HammerExtension : PowerDrillDecorator
{
    public override bool Drill()
    {
        if (base.Drill())
        {
            Console.WriteLine("Drill used in hammer mode.");
            return true;
        }

        return false;
    }
}