using System.Dynamic;

namespace State_Demo;

internal interface IMobilePhoneState
{
    void PressHomeButton();
    List<string> GetAppNames();
    void SelectApp(string appName);
    string? GetCurrentApp();
}