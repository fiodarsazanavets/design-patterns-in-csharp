namespace Iterator_Demo;

internal class ListIterator(ListAggregate aggregate) : IIterator
{
	private int currentIndex = -1;

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