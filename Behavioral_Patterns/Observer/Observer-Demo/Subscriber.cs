namespace Observer_Demo;

internal class Subscriber : IObserver
{
	private string name;

	public Subscriber(string name)
	{
		this.name = name;
	}

	public void Update(ISubject subject, string message)
    {
		Console.WriteLine($"'{message}' message received from {subject.Name} by {name}.");
    }
}