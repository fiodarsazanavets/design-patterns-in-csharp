﻿using Chain_of_Responsibility_Demo;

var handler1 = new AuthenticationHandler();
var handler2 = new AuthorizationHandler();
handler1.SetNext(handler2);

var request1 = new Request
{
    Username = "Invalid",
    Password = "Invalid",
};

var request2 = new Request
{
    Username = "John",
    Password = "password",
    Role = "User"
};

var request3 = new Request
{
    Username = "John",
    Password = "password",
    Role = "Admin"
};

var response1 = handler1.HandleRequest(request1);
var response2 = handler1.HandleRequest(request2);
var response3 = handler1.HandleRequest(request3);
Console.WriteLine($"Response 1: Success - {response1.Success}, Message - {response1.Message}");
Console.WriteLine($"Response 2: Success - {response2.Success}, Message - {response2.Message}");
Console.WriteLine($"Response 3: Success - {response3.Success}, Message - {response3.Message}");

Console.ReadKey();