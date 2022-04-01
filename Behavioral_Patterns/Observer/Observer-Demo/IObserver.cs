namespace Observer_Demo;

internal interface IObserver
{
    void Update(ISubject subject, string message);
}