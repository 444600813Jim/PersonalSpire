namespace Spire.Doc.Documents.Converters.OpenDocument.Output
{
    using System;

    internal enum OpenDocumentWritingStage
    {
        ContentAutomaticStyles,
        ContentBody,
        ContentBodyTrackedChanges,
        StylesStyles,
        StylesAutomaticStyles,
        StylesMasterPage,
        StrokeDashForHeadersFooters,
        MathML
    }
}

