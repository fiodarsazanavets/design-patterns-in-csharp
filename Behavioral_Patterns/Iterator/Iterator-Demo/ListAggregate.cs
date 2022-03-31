namespace Iterator_Demo;

public class ListAggregate : IAggregate
{
	private List<int> collection;

	public ListAggregate()
    {
        collection = new List<int>();
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
