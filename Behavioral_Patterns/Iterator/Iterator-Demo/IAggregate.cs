namespace Iterator_Demo;

public interface IAggregate
{
	IIterator CreateIterator();
	void Insert(int value);
}