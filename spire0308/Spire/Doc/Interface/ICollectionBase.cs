namespace Spire.Doc.Interface
{
    using System;
    using System.Collections;

    public interface ICollectionBase : IEnumerable
    {
        int Count { get; }
    }
}

