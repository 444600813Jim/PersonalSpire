namespace Spire.Doc.Documents
{
    using Spire.Doc.Interface;
    using System;
    using System.Text.RegularExpressions;

    public interface IBodyRegion : IDocumentObject
    {
        int Replace(Regex pattern, TextSelection textSelection);
        int Replace(Regex pattern, string replace);
        int Replace(string given, string replace, bool caseSensitive, bool wholeWord);
    }
}

