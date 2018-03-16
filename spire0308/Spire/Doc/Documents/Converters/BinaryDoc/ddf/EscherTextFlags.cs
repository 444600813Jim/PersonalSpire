namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherTextFlags
    {
        AutoTextMargin = 8,
        FitShapeToText = 2,
        FitTextToShape = 1,
        RotateText = 4,
        SelectText = 0x10
    }
}

