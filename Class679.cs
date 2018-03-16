using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;

internal class Class679
{
    private readonly int int_0;
    private readonly PathType pathType_0;

    internal Class679() : this(PathType.Unknown, 0)
    {
    }

    internal Class679(PathType A_0, int A_1)
    {
        this.pathType_0 = A_0;
        this.int_0 = A_1;
    }

    internal PathType method_0()
    {
        return this.pathType_0;
    }

    internal int method_1()
    {
        return this.int_0;
    }

    internal int method_2()
    {
        return (this.method_3() + (this.method_4() * this.method_1()));
    }

    internal int method_3()
    {
        if (this.method_0() == PathType.MoveTo)
        {
            return 1;
        }
        return 0;
    }

    internal int method_4()
    {
        int num = 1;
        switch (this.method_0())
        {
            case PathType.LineTo:
                return 1;

            case PathType.CurveTo:
                return 3;

            case PathType.MoveTo:
            case PathType.Close:
            case PathType.End:
                return 0;

            case PathType.AngleEllipseTo:
            case PathType.AngleEllipse:
            case PathType.ArcTo:
            case PathType.Arc:
            case PathType.ClockwiseArcTo:
            case PathType.ClockwiseArc:
            case PathType.EllipticalQuadrantX:
            case PathType.EllipticalQuadrantY:
            case PathType.QuadraticBezier:
                return 1;

            case PathType.NoFill:
            case PathType.NoLine:
            case PathType.EscapeAutoLine:
            case PathType.EscapeAutoCurve:
            case PathType.EscapeCornerLine:
            case PathType.EscapeCornerCurve:
            case PathType.EscapeSmoothLine:
            case PathType.EscapeSmoothCurve:
            case PathType.EscapeSymmetricLine:
            case PathType.EscapeSymmetricCurve:
            case PathType.EscapeFreeForm:
                return 0;

            case PathType.FillColor:
            case PathType.LineColor:
                return 1;
        }
        throw new InvalidOperationException(BookmarkStart.b("爦䜨太䠬䰮帰吲嬴帶䌸帺夼Ἶ≀ⱂ⡄⩆⡈╊⥌潎㡐㵒畔ざ㱘㑚ぜ㩞ᕠᅢᱤ䝦ᥨ੪ᥬݮ彰", num));
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("怯匱䀳帵氷䌹䰻嬽稿扁㽃癅㕇晉汋്㽏❑㩓≕扗穙❛潝ᵟ", 10), this.method_0(), this.method_1());
    }
}

