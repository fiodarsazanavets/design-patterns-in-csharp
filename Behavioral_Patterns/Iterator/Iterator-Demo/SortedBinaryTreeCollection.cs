namespace Iterator_Demo;

internal class SortedBinaryTreeCollection : IAggregate
{
    private Node? root;

    public SortedBinaryTreeCollection()
    {
        root = null;
    }

    public IIterator CreateIterator()
    {
        return new SortedBinaryTreeIterator(this);
    }

    public Node GetFirst()
    {
        var current = root;

        while (true)
        {
            if (current?.Left is not null)
            {
                current = current.Left;
            }
            else
            {
                return current;
            }
        }
    }

    public void Insert(int value)
    {
        Node newNode = new Node(value);

        if (root is null)
        {
            root = newNode;
        }
        else
        {
            Node parent;
            var temp = root;

            while (true)
            {
                parent = temp;

                if (value < temp.Value)
                {
                    temp = temp.Left;

                    if (temp is null)
                    {
                        parent.Left = newNode;
                        newNode.Parent = parent;
                        return;
                    }
                }
                else
                {
                    temp = temp.Right;

                    if (temp is null)
                    {
                        parent.Right = newNode;
                        newNode.Parent = parent;
                        return;
                    }
                }
            }
        }
    }
}