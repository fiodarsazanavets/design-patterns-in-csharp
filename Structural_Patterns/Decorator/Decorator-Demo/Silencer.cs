namespace Decorator_Demo;

internal class Silencer : GunDecorator
{
    public override bool Shoot()
    {
        if (base.Shoot())
        {
            Console.WriteLine("Shot has been silenced.");
            return true;
        }

        return false;
    }
}