namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public interface IWSectionCollection : IDocumentObjectCollection
    {
        int Add(ISection section);
        int IndexOf(ISection section);

        Section this[int index] { get; }
    }
}

