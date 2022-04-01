namespace Observer_Demo;

internal class Publisher : ISubject
{
	private string name;
	private List<IObserver> observers;

	public Publisher(string name)
	{
		this.name = name;
		observers = new List<IObserver>();
	}

	public string Name => name;

	public void Subscribe(IObserver observer)
    {
		observers.Add(observer);
    }

	public void Unsubscribe(IObserver observer)
    {
		observers.Remove(observer);
    }

	public void Notify(string message)
    {
		foreach (var observer in observers)
        {
			observer.Update(this, message);

		}
    }
}