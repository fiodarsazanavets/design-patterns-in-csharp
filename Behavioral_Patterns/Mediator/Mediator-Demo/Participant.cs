
namespace Mediator_Demo;

internal abstract class Participant(string key, IMediator mediator) : IParticipant
{
    protected string key = key;

    public virtual void SendCommand(string receiver, string command)
    {
        mediator.SendCommand(receiver, key, command);
    }

    public virtual void ReceiveCommand(string sender, string command)
    {
        Console.WriteLine($"Executing command {command} issued by {sender}.");
    }
}