namespace Chain_of_Responsibility_Demo;

internal class Response
{
    public Response(bool success, string message)
    {
        Success = success;
        Message = message;
    }

    public bool Success { get; }
    public string? Message { get; }
}