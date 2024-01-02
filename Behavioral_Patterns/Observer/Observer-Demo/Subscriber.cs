namespace Observer_Demo;

internal class Subscriber(string name) : IObserver
{
	public void Update(ISubject subject, string message)
    {
		Console.WriteLine($"'{message}' message received from {subject.Name} by {name}.");
    }
}