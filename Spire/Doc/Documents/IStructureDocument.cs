namespace Spire.Doc.Documents
{
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;

    public interface IStructureDocument : ICompositeObject
    {
        void UpdateDataBinding();

        CharacterFormat BreakCharacterFormat { get; }

        Spire.Doc.Documents.SDTProperties SDTProperties { get; }
    }
}

