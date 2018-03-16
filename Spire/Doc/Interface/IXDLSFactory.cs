namespace Spire.Doc.Interface
{
    public interface IXDLSFactory
    {
        IDocumentSerializable Create(IXDLSContentReader reader);
    }
}

