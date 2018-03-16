namespace Spire.Doc.Interface
{
    using Spire.Doc.Documents.XML;
    using System;

    public interface IDocumentSerializable
    {
        void ReadXmlAttributes(IXDLSAttributeReader reader);
        bool ReadXmlContent(IXDLSContentReader reader);
        void RestoreReference(string name, int value);
        void WriteXmlAttributes(IXDLSAttributeWriter writer);
        void WriteXmlContent(IXDLSContentWriter writer);

        Spire.Doc.Documents.XML.XDLSHolder XDLSHolder { get; }
    }
}

