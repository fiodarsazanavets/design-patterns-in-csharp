namespace Iterator_Demo;

internal class ListIterator : IIterator
{
	private ListAggregate aggregate;
	private int currentIndex;

	public ListIterator(ListAggregate aggregate)
	{
		this.aggregate = aggregate;
		currentIndex = -1;
	}

	public bool MoveNext()
	{
		if (currentIndex + 1 < aggregate.Count)
		{
			currentIndex++;
			return true;
		}

		return false;
	}

	public int GetCurrent()
	{
		return aggregate[currentIndex];

	}
}