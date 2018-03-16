namespace Spire.Doc.Documents.Converters.BinaryDoc.User
{
    using System;

    [Flags]
    internal enum TBCFlags
    {
        BeginGroup = 2,
        BeginLine = 0x40,
        Hidden = 1,
        NoCustomize = 8,
        OwnLine = 4,
        SaveDxy = 0x10
    }
}

