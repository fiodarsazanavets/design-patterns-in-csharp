namespace Prototype_Demo;

internal class CloneableObject : ICloneable
{
    private readonly int internalData;
    private readonly string internalTitle;

    public ClonableObject(string title)
    {
        var random = new Random();
        internalData = random.Next();

        internalTitle = title;
    }

    public int Data => internalData;
    public string Title => internalTitle;

    public ICloneable Clone()
    {
        return (ClonableObject)MemberwiseClone();
    }
}