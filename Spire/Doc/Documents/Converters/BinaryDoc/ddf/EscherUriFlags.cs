namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherUriFlags
    {
        AbsFromGetdataRel = 0x200,
        HasCreationTime = 0x40,
        HasDisplayName = 0x10,
        HasFrameName = 0x80,
        HasGUID = 0x20,
        HasLocationStr = 8,
        HasMoniker = 1,
        IsAbsolute = 2,
        MonikerSavedAsStr = 0x100,
        SiteGaveDisplayName = 4
    }
}

