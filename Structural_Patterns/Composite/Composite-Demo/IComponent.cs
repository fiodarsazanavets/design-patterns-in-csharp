namespace Composite_Demo;

internal interface IComponent
{
    string Name { get; }
    void Display(string currentPath);
}