using System.Runtime.InteropServices;
using System.Text;

namespace Strategy_Demo;

internal class WindowsPlayerStrategy : IPlayerStrategy
{
    [DllImport("winmm.dll")]
    private static extern int mciSendString(string command, StringBuilder stringReturn, int returnLength, IntPtr hwndCallback);

    public Task Play(string fileName)
    {
        var sb = new StringBuilder();
        var result = mciSendString($"Play {fileName}", sb, 1024 * 1024, IntPtr.Zero);
        Console.WriteLine(result);
        return Task.CompletedTask;
    }
}