using System.Runtime.InteropServices;
using Strategy_Demo;

var context = new PlayerContext();

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    context.SetStrategy(new WindowsPlayerStrategy());
else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    context.SetStrategy(new LinuxPlayerStrategy());
else
    throw new Exception("Only Linux and Windows operating systems are supported.");

Console.WriteLine("Please specify the path to the file to play.");
var filePath = Console.ReadLine() ?? string.Empty;

await context.Play(filePath);

Console.ReadKey();