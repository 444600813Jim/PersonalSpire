namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherBlipNameFlags
    {
        Comment = 0,
        DoNotSave = 4,
        File = 1,
        LinkToFile = 8,
        TypeMask = 3,
        URL = 2
    }
}

