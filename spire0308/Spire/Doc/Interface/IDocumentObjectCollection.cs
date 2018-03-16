namespace Spire.Doc.Interface
{
    using Spire.Doc;
    using System;
    using System.Reflection;

    public interface IDocumentObjectCollection : ICollectionBase
    {
        DocumentObject this[int index] { get; }
    }
}

