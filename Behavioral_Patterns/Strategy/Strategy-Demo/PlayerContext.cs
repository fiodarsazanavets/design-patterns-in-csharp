namespace Strategy_Demo;

internal class PlayerContext
{
	private IPlayerStrategy strategy;

	public void SetStrategy(IPlayerStrategy strategy)
    {
		this.strategy = strategy;
    }

	public Task Play(string fileName)
    {
		return strategy.Play(fileName);

	}
}