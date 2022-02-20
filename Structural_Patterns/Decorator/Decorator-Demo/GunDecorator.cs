namespace Decorator_Demo;

internal abstract class GunDecorator : IGun
{
    private IGun? gun;

    public void SetGun(IGun gun)
    {
        this.gun = gun;
    }

    public virtual void Reload()
    {
        if (gun is not null)
        {
            gun.Reload();
        }
    }

    public virtual bool Shoot()
    {
        if (gun is not null)
        {
            return gun.Shoot();
        }

        return false;
    }
}