namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherImageFlags
    {
        Active = 1,
        BiLevel = 2,
        Gray = 4,
        NoHitTestPicture = 8,
        PreserveGrays = 0x40
    }
}

