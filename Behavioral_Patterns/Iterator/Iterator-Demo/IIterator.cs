namespace Iterator_Demo;

public interface IIterator
{
    bool MoveNext();
    int GetCurrent();
}