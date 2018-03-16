namespace Spire.Doc.Interface
{
    using Spire.Doc.Documents;
    using System;

    public interface IParagraphBase : IDocumentObject
    {
        void ApplyStyle(string styleName);

        Paragraph OwnerParagraph { get; }

        string StyleName { get; }
    }
}

