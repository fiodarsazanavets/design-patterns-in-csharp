using System.Diagnostics;

namespace Strategy_Demo;

public class LinuxPlayerStrategy : IPlayerStrategy
{
    public Task Play(string fileName)
    {
        StartBashProcess($"mpg123 -q '{fileName}'");

        return Task.CompletedTask;
    }

    private static void StartBashProcess(string command)
    {
        var escapedArgs = command.Replace("\"", "\\\"");

        var process = new Process()
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "/bin/bash",
                Arguments = $"-c \"{escapedArgs}\"",
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            }
        };

        process.Start();
    }
}