namespace Spire.Doc.Interface
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using System;

    public interface IDocumentObject
    {
        DocumentObject Clone();

        Spire.Doc.Document Document { get; }

        Spire.Doc.Documents.DocumentObjectType DocumentObjectType { get; }

        bool IsComposite { get; }

        IDocumentObject NextSibling { get; }

        DocumentObject Owner { get; }

        IDocumentObject PreviousSibling { get; }
    }
}

