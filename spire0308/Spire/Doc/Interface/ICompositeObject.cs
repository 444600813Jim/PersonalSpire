namespace Spire.Doc.Interface
{
    using Spire.Doc.Collections;

    public interface ICompositeObject : IDocumentObject
    {
        DocumentObjectCollection ChildObjects { get; }
    }
}

