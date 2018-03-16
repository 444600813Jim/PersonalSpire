namespace Spire.Doc.Interface
{
    using Spire.Doc.Formatting;
    using System;

    public interface ITextRange : IParagraphBase
    {
        void ApplyCharacterFormat(Spire.Doc.Formatting.CharacterFormat charFormat);

        Spire.Doc.Formatting.CharacterFormat CharacterFormat { get; }

        string Text { get; set; }
    }
}

