namespace Memento_Demo;

internal class TextEditorMemento :  IMemento
{
	private readonly string state;
	private readonly DateTimeOffset created;

	public TextEditorMemento(string state)
	{
		this.state = state;
		created = DateTimeOffset.Now;
	}

	public string GetState()
    {
		return state;
    }

	public DateTimeOffset GetCreatedDate()
    {
		return created;
    }
}