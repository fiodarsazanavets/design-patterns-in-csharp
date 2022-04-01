namespace State_Demo;

internal class MobilePhoneContext
{
	IMobilePhoneState state;

	public MobilePhoneContext()
	{
		state = new LockedScreenState();
	}

	public void ChangeState(IMobilePhoneState state)
    {
		this.state = state;
    }

	public void PressHomeButton()
    {
		state.PressHomeButton();
    }
}