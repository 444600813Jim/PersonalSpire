namespace Spire.Doc.Interface
{
    using Spire.Doc.Documents;
    using System;
    using System.Reflection;

    public interface IParagraphCollection : IDocumentObjectCollection
    {
        int Add(IParagraph paragraph);
        int IndexOf(IParagraph paragraph);
        void Insert(int index, IParagraph paragraph);
        void RemoveAt(int index);

        Paragraph this[int index] { get; }
    }
}

