namespace Builder_Demo;

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
        else
        {
            Console.WriteLine("No active playback process found.");
        }

        return Task.CompletedTask;
    }
}