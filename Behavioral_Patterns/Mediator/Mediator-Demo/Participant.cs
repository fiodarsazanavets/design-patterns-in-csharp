
namespace Mediator_Demo;

internal class Participant : IParticipant
{
    private IMediator mediator;

    protected string key;

    public Participant(string key, IMediator mediator)
    {
        this.key = key;
        this.mediator = mediator;
    }

    public virtual void SendCommand(string receiver, string command)
    {
        mediator.SendCommand(receiver, key, command);
    }

    public virtual void ReceiveCommand(string sender, string command)
    {
        Console.WriteLine($"Executing command {command} issued by {sender}.");
    }
}
