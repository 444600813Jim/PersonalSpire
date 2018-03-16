namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherFillFlags
    {
        Filled = 0x10,
        FillShape = 4,
        FillUseRect = 2,
        HitTestFill = 8,
        NoFillHitTest = 1,
        RecolorFillAsPicture = 0x40,
        UseShapeAnchor = 0x20
    }
}

