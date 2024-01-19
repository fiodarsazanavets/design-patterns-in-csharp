namespace Mediator_Demo;

internal class NetworkMediator : IMediator
{
	private Dictionary<string, IParticipant> participants;

	public NetworkMediator()
	{
		participants = [];
	}

	public void Register(string key, IParticipant participant)
    {
		participants[key] = participant;

	}

	public void SendCommand(string receiver, string sender, string command)
    {
		if (participants.ContainsKey(receiver))
        {
			participants[receiver].ReceiveCommand(sender, command);

		}
	}
}