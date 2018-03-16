namespace Spire.Doc.Interface
{
    using System;
    using System.Collections;

    public interface IXDLSSerializableCollection : IEnumerable
    {
        IDocumentSerializable AddNewItem(IXDLSContentReader reader);

        int Count { get; }

        string TagItemName { get; }
    }
}

