using Builder_Demo;
using System.Runtime.InteropServices;

var director = new PlayerDirector();
Player? player;

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    player = director.BuildPlayer(new WindowsPlayerBuilder());
else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    player = director.BuildPlayer(new LinuxPlayerBuilder());
else
    throw new Exception("Only Linux and Windows operating systems are supported.");

Console.WriteLine("Please specify the path to the file to play.");

var filePath = Console.ReadLine() ?? string.Empty;
player.PlayButton?.Play(filePath);

Console.WriteLine("Playing audio. Type 'stop' to stop it or 'exit' to exit the application.");

while (true)
{
    var command = Console.ReadLine();

    if (command == "stop")
        player.StopButton?.Stop(filePath);
    else if (command == "exit")
        break;
}

Console.ReadKey();