namespace Prototype_Demo;

internal class ClonableObject : IClonable
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

    public IClonable Clone()
    {
        return (ClonableObject)MemberwiseClone();
    }
}