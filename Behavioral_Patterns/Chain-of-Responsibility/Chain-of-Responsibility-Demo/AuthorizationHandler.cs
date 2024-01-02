namespace Chain_of_Responsibility_Demo;

internal class AuthorizationHandler : RequestHandler
{
    public override Response HandleRequest(Request request)
    {
        if (request.Role != "Admin")
            return new Response(false, "User not authorized.");

        if (successor is not null)
            return successor.HandleRequest(request);

        return new Response(true, "Authorization successful.");
    }
}