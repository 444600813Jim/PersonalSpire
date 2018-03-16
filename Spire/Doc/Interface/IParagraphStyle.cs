namespace Spire.Doc.Interface
{
    using Spire.Doc.Formatting;

    public interface IParagraphStyle : IStyle
    {
        Spire.Doc.Formatting.CharacterFormat CharacterFormat { get; }

        Spire.Doc.Formatting.ParagraphFormat ParagraphFormat { get; }
    }
}

