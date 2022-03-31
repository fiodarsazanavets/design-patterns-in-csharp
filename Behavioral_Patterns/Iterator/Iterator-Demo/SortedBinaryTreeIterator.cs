namespace Iterator_Demo;

public class SortedBinaryTreeIterator : IIterator
{
	private SortedBinaryTreeCollection aggregate;

	public SortedBinaryTreeIterator(SortedBinaryTreeCollection aggregate)
	{
		this.aggregate = aggregate;
	}

	public bool MoveNext()
    {
		return aggregate.MoveNext();
	}

	public int GetCurrent()
    {
		return aggregate.GetCurrent();
	}
}