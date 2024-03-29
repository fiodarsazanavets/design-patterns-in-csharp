﻿namespace Iterator_Demo;

internal class SortedBinaryTreeIterator(SortedBinaryTreeCollection aggregate) : IIterator
{
	private Node? current = null;

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
        return current?.Value ?? 0;
    }
}