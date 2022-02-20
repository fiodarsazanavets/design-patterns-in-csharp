namespace Composite_Demo;

internal class File : IComponent
{
    public File(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void Display(string currentPath)
    {
        Console.WriteLine(currentPath + Name);
    }
}
