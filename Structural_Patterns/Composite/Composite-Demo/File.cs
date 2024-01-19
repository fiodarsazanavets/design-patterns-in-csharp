namespace Composite_Demo;

internal class File(string name) : IComponent
{
    public string Name { get; } = name;

    public void Display(string currentPath)
    {
        Console.WriteLine(currentPath + Name);
    }
}