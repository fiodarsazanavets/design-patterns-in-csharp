namespace Abstract_Factory_Demo;

internal class LinuxStopButton : StopButton
{
    public override Task Stop(string fileName)
    {
        if (LinuxPlayerUtility.PlaybackProcess != null)
        {
            LinuxPlayerUtility.PlaybackProcess.Kill();
            LinuxPlayerUtility.PlaybackProcess.Dispose();
            LinuxPlayerUtility.PlaybackProcess = null;
        }

        return Task.CompletedTask;
    }
}