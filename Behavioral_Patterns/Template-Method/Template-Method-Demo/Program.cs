using Template_Method_Demo;

var inputText = @"This is the *first* paragraph.

This is the **second** paragraph.

This is the ~~third~~ paragraph.";

Console.WriteLine("Text after using basic converter:");
var basicTextConverter = new BasicTextToHtmlConverter();
Console.WriteLine(basicTextConverter.ConvertText(inputText));

Console.WriteLine("Text after using MD converter:");
var mdToHtmlConverter = new MdToHtmlConverter();
Console.WriteLine(mdToHtmlConverter.ConvertText(inputText));

Console.ReadKey();