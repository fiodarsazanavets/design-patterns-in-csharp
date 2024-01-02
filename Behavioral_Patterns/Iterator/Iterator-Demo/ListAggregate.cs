namespace Iterator_Demo;

internal class ListAggregate : IAggregate
{
	private readonly List<int> collection;

	public ListAggregate()
    {
        collection = [];
    }

    public IIterator CreateIterator()
    {
        return new ListIterator(this);
    }
    // Get item count
    public int Count
    {
        get { return collection.Count; }
    }
    // Indexer
    public int this[int index]
    {
        get { return collection[index]; }
        set { collection.Insert(index, value); }
    }

    public void Insert(int value)
    {
        collection.Add(value);
    }
}