namespace Visitor_Demo;

internal class HtmlToTextConverter : IComponent
{
    public string Accept(IVisitor visitor, string text)
    {
        return visitor.VisitHtmlToTextConverter(this, text);
    }

    public string ProcessParagraphs(string text)
    {
        return text
            .Replace("<p>", "")
            .Replace("</p>", "\n")
            .Replace("<br/>", "");
    }
}