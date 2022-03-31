namespace Iterator_Demo;

internal interface IAggregate
{
	IIterator CreateIterator();
	void Insert(int value);
}