namespace Observer_Demo;

internal interface ISubject
{
    string Name { get; }
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void Notify(string message);
}