namespace Command_Demo;

internal class DataCommandInvoker
{
    ICommand? command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
        Console.WriteLine($"Command {command.GetType()} set.");
    }

    public void ExecuteCommand()
    {
        command?.Execute();
    }
}