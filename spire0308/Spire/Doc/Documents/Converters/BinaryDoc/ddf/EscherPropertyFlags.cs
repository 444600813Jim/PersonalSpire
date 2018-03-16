namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherPropertyFlags
    {
        BlipId = 0x4000,
        Complex = 0x8000,
        PropIdMask = 0x3fff
    }
}

