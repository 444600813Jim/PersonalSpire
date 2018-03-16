namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsTextFlags
    {
        AutoTextMargin = 8,
        FitShapeToText = 2,
        FitTextToShape = 1,
        RotateText = 4,
        SelectText = 0x10
    }
}

