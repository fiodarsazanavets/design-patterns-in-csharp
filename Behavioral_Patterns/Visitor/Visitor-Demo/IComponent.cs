namespace Visitor_Demo;

internal interface IComponent
{
    string Accept(IVisitor visitor, string text);
}