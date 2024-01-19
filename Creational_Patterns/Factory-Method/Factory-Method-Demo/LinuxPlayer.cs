using System.Diagnostics;

namespace Factory_Method_Demo;

internal class LinuxPlayer : Player
{
    public override Task Play(string fileName)
    {
        Console.WriteLine("Playing audio via the following command:");
        Console.WriteLine($"mpg123 -q '{fileName}'");

        // Uncomment for testing on a real device
        // StartBashProcess($"mpg123 -q '{fileName}'");

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