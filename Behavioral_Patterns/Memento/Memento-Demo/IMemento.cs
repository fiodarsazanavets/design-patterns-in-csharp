namespace Memento_Demo;

internal interface IMemento
{
    string GetState();
    DateTimeOffset GetCreatedDate();
}