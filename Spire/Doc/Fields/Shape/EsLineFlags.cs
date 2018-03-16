namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsLineFlags
    {
        ArrowHeadsOk = 0x10,
        HitTestLine = 4,
        InsetPen = 0x40,
        InsetPenOk = 0x20,
        Line = 8,
        LineFillShape = 2,
        NoLineDrawDash = 1,
        RecolorFillAsPicture = 0x100,
        UseArrowHeadsOk = 0x100000,
        UseHitTestLine = 0x40000,
        UseInsetPen = 0x400000,
        UseInsetPenOk = 0x200000,
        UseLine = 0x80000,
        UseLineFillShape = 0x20000,
        UseNoLineDrawDash = 0x10000,
        UseRecolorFillAsPicture = 0x1000000,
        UseShapeAnchor = 0x80,
        UseUseShapeAnchor = 0x800000
    }
}

