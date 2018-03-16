namespace Spire.Doc.Documents.Converters
{
    using System;

    [Flags]
    internal enum XmlDocumentTextHandling
    {
        None = 0,
        SignificantWhitespace = 2,
        Text = 1,
        TextAndSignificant = 3,
        TextAndSignificantAndIgnorable = 7,
        Whitespace = 4
    }
}

