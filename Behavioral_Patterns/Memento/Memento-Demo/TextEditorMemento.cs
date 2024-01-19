namespace Memento_Demo;

internal class TextEditorMemento(string state) :  IMemento
{
	private readonly string state = state;
	private readonly DateTimeOffset created = DateTimeOffset.Now;

    public string GetState()
    {
		return state;
    }

	public DateTimeOffset GetCreatedDate()
    {
		return created;
    }
}