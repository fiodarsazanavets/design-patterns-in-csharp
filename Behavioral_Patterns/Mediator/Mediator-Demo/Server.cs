namespace Mediator_Demo;

internal class Server(string key, IMediator mediator) : Participant(key, mediator)
{
    public override void SendCommand(string receiver, string command)
    {
        Console.WriteLine($"Server has issued {command} command to {receiver}.");
        base.SendCommand(receiver, command);
    }

    public override void ReceiveCommand(string sender, string command)
    {
        Console.Write($"Server {key} received a command. ");
        base.ReceiveCommand(sender, command);
    }
}