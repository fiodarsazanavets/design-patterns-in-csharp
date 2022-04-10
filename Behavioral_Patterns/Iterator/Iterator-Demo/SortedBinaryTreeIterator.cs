namespace Iterator_Demo;

internal class SortedBinaryTreeIterator : IIterator
{
	private SortedBinaryTreeCollection aggregate;
    private Node? current;

	public SortedBinaryTreeIterator(SortedBinaryTreeCollection aggregate)
	{
		this.aggregate = aggregate;
        current = null;

    }

    public bool MoveNext()
    {
        if (current is null)
        {
            current = aggregate.GetFirst();
            return true;
        }

        if (current.Right is not null)
        {
            current = current.Right;

            while (true)
            {
                if (current.Left is null)
                {
                    break;
                }

                current = current.Left;
            }

            return true;
        }
        else
        {
            var originalValue = current.Value;

            while (true)
            {
                if (current.Parent is not null)
                {
                    current = current.Parent;

                    if (current.Value > originalValue)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }

    public int GetCurrent()
    {
        return current.Value;
    }
}