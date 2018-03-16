namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsGeometryFlags
    {
        FillOK = 1,
        FillShadeShapeOK = 2,
        GTextOK = 4,
        LineOK = 8,
        ShadowOK = 0x20,
        ThreeDOK = 0x10
    }
}

