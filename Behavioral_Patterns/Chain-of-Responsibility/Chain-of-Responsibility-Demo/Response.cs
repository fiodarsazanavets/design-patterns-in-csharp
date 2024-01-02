namespace Chain_of_Responsibility_Demo;

internal class Response(bool success, string message)
{
    public bool Success { get; } = success;
    public string? Message { get; } = message;
}