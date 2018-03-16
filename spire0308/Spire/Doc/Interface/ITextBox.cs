namespace Spire.Doc.Interface
{
    using Spire.Doc;
    using Spire.Doc.Formatting;

    public interface ITextBox : ICompositeObject, IParagraphBase
    {
        Spire.Doc.Body Body { get; }

        TextBoxFormat Format { get; }
    }
}

