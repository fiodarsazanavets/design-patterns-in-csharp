using Memento_Demo;

var textEditor = new TextEditor();
var caretaker = new Caretaker(textEditor);

textEditor.UpdateText("Original text.");
Console.WriteLine($"Updated text to '{textEditor.GetCurrentText()}'.");
caretaker.Backup();
textEditor.UpdateText("First edit.");
Console.WriteLine($"Updated text to '{textEditor.GetCurrentText()}'.");
caretaker.Backup();
textEditor.UpdateText("Second edit.");
Console.WriteLine($"Updated text to '{textEditor.GetCurrentText()}'.");
caretaker.Backup();

textEditor.UpdateText("Third edit.");
Console.WriteLine($"Updated text to '{textEditor.GetCurrentText()}'.");

caretaker.Revert();
Console.WriteLine($"Reverted text to '{textEditor.GetCurrentText()}'.");
caretaker.Revert();
Console.WriteLine($"Reverted text to '{textEditor.GetCurrentText()}'.");
caretaker.Revert();
Console.WriteLine($"Reverted text to '{textEditor.GetCurrentText()}'.");

Console.ReadKey();