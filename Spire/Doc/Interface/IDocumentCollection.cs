namespace Spire.Doc.Interface
{
    using System;
    using System.Reflection;

    public interface IDocumentCollection : ICollectionBase
    {
        IDocument this[int index] { get; }
    }
}

