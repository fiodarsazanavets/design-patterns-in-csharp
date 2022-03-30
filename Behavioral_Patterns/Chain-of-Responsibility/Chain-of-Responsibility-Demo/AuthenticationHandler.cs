namespace Chain_of_Responsibility_Demo;

internal class AuthenticationHandler : RequestHandler
{
    public override Response HandleRequest(Request request)
    {
        if (request.Username != "John" ||
            request.Password != "password")
            return new Response(false, "Invalid username or password.");

        if (successor is not null)
            return successor.HandleRequest(request);

        return new Response(true, "Authentication successfu.l");
    }
}

