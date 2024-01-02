using System.Runtime.InteropServices;
using System.Text;

namespace Abstract_Factory_Demo;

internal static class WindowsPlayerUtility
{
    [DllImport("winmm.dll", CharSet = CharSet.Unicode)]
    private static extern int mciSendString(string command, StringBuilder stringReturn, int returnLength, IntPtr hwndCallback);

    public static void ExecuteMciCommand(string commandString)
    {
        var sb = new StringBuilder();
        var result = mciSendString(commandString, sb, 1024 * 1024, IntPtr.Zero);
        Console.WriteLine(result);
    }
}