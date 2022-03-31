namespace Memento_Demo;

internal class TextEditor
{
	private string state;

	public TextEditor()
	{
		state = string.Empty;
	}

	public string GetCurrentText()
    {
		return state;
    }

	public void UpdateText(string updatedText)
    {
		state = updatedText;
	}

	public IMemento Save()
    {
		Console.WriteLine("Saving state.");
		return new TextEditorMemento(state);
    }

	public void SetState(IMemento memento)
	{
		state = memento.GetState();
		Console.WriteLine($"Restored the state from the snapshot created at {memento.GetCreatedDate()}.");
    }
}