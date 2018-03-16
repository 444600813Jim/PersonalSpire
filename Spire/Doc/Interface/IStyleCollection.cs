namespace Spire.Doc.Interface
{
    using Spire.Doc.Documents;
    using System;
    using System.Reflection;

    public interface IStyleCollection : ICollectionBase
    {
        int Add(IStyle style);
        Style FindByName(string name);
        IStyle FindByName(string name, StyleType styleType);

        IStyle this[int index] { get; }
    }
}

