using System.Text;
using System.Text.RegularExpressions;

namespace Template_Method_Demo;

internal abstract class AbstractTextToHtmlConverter
{
	protected string ProcessParagraphs(string text)
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

    protected abstract string ApplyPostProcessing(string text);

    public string ConvertText(string text)
    {
        text = ProcessParagraphs(text);
        return ApplyPostProcessing(text);
    }
}