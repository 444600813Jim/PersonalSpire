namespace Spire.Doc.Interface
{
    using System;
    using System.Reflection;

    public interface ITableCollection : IDocumentObjectCollection
    {
        int Add(ITable table);
        bool Contains(ITable table);
        int IndexOf(ITable table);

        ITable this[int index] { get; }
    }
}

