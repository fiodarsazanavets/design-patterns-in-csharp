using Abstract_Factory_Demo;
using System.Runtime.InteropServices;

PlayerCreator? playerFactory;

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    playerFactory = new WindowsPlayerCreator();
else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    playerFactory = new LinuxPlayerCreator();
else
    throw new Exception("Only Linux and Windows operating systems are supported.");

Console.WriteLine("Please specify the path to the file to play.");

var filePath = Console.ReadLine() ?? string.Empty;
await playerFactory.CreatePlayButton().Play(filePath);

Console.WriteLine("Playing audio. Type 'stop' to stop it or 'exit' to exit the application.");

while (true)
{
    var command = Console.ReadLine();

    if (command == "stop")
        await playerFactory.CreateStopButton().Stop(filePath);
    else if (command == "exit")
        break;
}

Console.ReadKey();