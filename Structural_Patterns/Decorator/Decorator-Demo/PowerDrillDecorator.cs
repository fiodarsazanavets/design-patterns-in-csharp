namespace Decorator_Demo;

internal abstract class PowerDrillDecorator : IPowerDrill
{
    private IPowerDrill? powerDrill;

    public void SetPowerDrill(IPowerDrill powerDrill)
    {
        this.powerDrill = powerDrill;
    }

    public virtual void Recharge()
    {
        if (powerDrill is not null)
        {
            powerDrill.Recharge();
        }
    }

    public virtual bool Drill()
    {
        if (powerDrill is not null)
        {
            return powerDrill.Drill();
        }

        return false;
    }
}