namespace Template_Method_Demo;

internal class BasicTextToHtmlConverter : AbstractTextToHtmlConverter
{
	protected override string ApplyPostProcessing(string text)
    {
        return text;
    }
}