namespace Memento_Demo;

internal class Caretaker
{
	private TextEditor textEditor;
	private Stack<IMemento> history;

	public Caretaker(TextEditor textEditor)
	{
		this.textEditor = textEditor;
		history = new Stack<IMemento>();
	}

	public void Backup()
    {
		history.Push(textEditor.Save());
	}

	public void Revert()
    {
		Console.WriteLine("Restoring a snapshot from history.");

		if (history.Count == 0)
        {
			Console.WriteLine("No snapshots to restore.");
			return;
        }

		textEditor.SetState(history.Pop());
	}
}