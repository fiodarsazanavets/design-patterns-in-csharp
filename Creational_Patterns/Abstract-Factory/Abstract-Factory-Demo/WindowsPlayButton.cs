﻿namespace Abstract_Factory_Demo;

internal class WindowsPlayButton : PlayButton
{
    public override Task Play(string fileName)
    {
        WindowsPlayerUtility.ExecuteMciCommand($"Play {fileName}");
        return Task.CompletedTask;
    }
}