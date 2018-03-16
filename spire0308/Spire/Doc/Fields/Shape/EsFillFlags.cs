namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsFillFlags
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

