namespace Spire.Doc.Fields.Shape
{
    using System;

    internal enum PathType
    {
        AngleEllipse = 0xa2,
        AngleEllipseTo = 0xa1,
        Arc = 0xa4,
        ArcTo = 0xa3,
        ClockwiseArc = 0xa6,
        ClockwiseArcTo = 0xa5,
        Close = 3,
        CurveTo = 1,
        EllipticalQuadrantX = 0xa7,
        EllipticalQuadrantY = 0xa8,
        End = 4,
        EscapeAutoCurve = 0xad,
        EscapeAutoLine = 0xac,
        EscapeBase = 160,
        EscapeCornerCurve = 0xaf,
        EscapeCornerLine = 0xae,
        EscapeExtension = 160,
        EscapeFreeForm = 180,
        EscapeSmoothCurve = 0xb1,
        EscapeSmoothLine = 0xb0,
        EscapeSymmetricCurve = 0xb3,
        EscapeSymmetricLine = 0xb2,
        FillColor = 0xb5,
        LineColor = 0xb6,
        LineTo = 0,
        MoveTo = 2,
        NoFill = 170,
        NoLine = 0xab,
        QuadraticBezier = 0xa9,
        Unknown = -1
    }
}

