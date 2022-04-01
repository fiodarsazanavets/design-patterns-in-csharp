using System.Text;
using System.Text.RegularExpressions;

namespace Visitor_Demo;

internal class TextToHtmlConverter : IComponent
{
    public string Accept(IVisitor visitor, string text)
    {
        return visitor.VisitTextToHtmlConverter(this, text);
    }

    public string ProcessParagraphs(string text)
    {
        var paragraphs = Regex.Split(text, @"(\r\n?|\n)")
                          .Where(p => p.Any(char.IsLetterOrDigit));

        var sb = new StringBuilder();

        foreach (var paragraph in paragraphs)
        {
            if (paragraph.Length == 0)
                continue;

            sb.AppendLine($"<p>{paragraph}</p>");
        }

        sb.AppendLine("<br/>");

        return sb.ToString();
    }
}