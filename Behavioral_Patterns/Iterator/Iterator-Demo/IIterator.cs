namespace Iterator_Demo;

internal interface IIterator
{
    bool MoveNext();
    int GetCurrent();
}