namespace Iterator_Demo;

internal class SortedBinaryTreeCollection : IAggregate
{
    private Node root;
    private Node current;

    public SortedBinaryTreeCollection()
    {
        root = null;
        current = null;
    }

    public IIterator CreateIterator()
    {
        return new SortedBinaryTreeIterator(this);
    }

    public bool MoveNext()
    {
        if (current is null)
        {
            GetFirst();
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

    private void GetFirst()
    {
        current = root;

        while (true)
        {
            if (current.Left is not null)
            {
                current = current.Left;
            }
            else
            {
                return;
            }
        }
    }
}