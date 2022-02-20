namespace Decorator_Demo;

internal class Gun : IGun
{
    private int ammo = 0;

    public void Reload()
    {
        ammo = 6;
    }

    public bool Shoot()
    {
        if (ammo > 0)
        {
            Console.WriteLine("Shot fired.");
            ammo--;
            return true;
        }

        Console.WriteLine("Out of ammo.");
        return false;
    }
}