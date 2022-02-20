namespace Decorator_Demo;

internal class ExtendedMagazine : GunDecorator
{
    private int extraAmmo = 0;

    public override void Reload()
    {
        base.Reload();
        extraAmmo = 6;
    }

    public override bool Shoot()
    {
        if (!base.Shoot())
        {
            if (extraAmmo > 0)
            {
                Console.WriteLine("Shot fired from the extended magazine.");
                extraAmmo--;
                return true;
            }

            return false;
        }

        return true;
    }
}
