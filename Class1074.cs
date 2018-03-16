using Spire.Doc.Documents;
using System;
using System.Drawing;

internal class Class1074
{
    internal static void smethod_0(Class672 A_0, PointF A_1, PointF A_2)
    {
        sprᲆ rᲆ = new sprᲆ(A_0.method_18());
        rᲆ.ᜀ(A_0.method_19());
        sprᧂ rᧂ = new sprᧂ();
        rᲆ.ᜁ(rᧂ);
        rᧂ.ᜁ(A_1, A_2);
        A_0.method_10().ᜁ(rᲆ);
    }

    internal static float smethod_1(Class1031 A_0)
    {
        switch (A_0.method_1())
        {
            case BorderStyle.Single:
            case BorderStyle.Dot:
            case BorderStyle.DashLargeGap:
            case BorderStyle.DotDash:
            case BorderStyle.DotDotDash:
            case BorderStyle.Wave:
            case BorderStyle.DoubleWave:
            case BorderStyle.DashSmallGap:
            case BorderStyle.DashDotStroker:
                return A_0.method_8();

            case BorderStyle.Thick:
            case BorderStyle.Hairline:
                return 1f;

            case BorderStyle.Double:
            case BorderStyle.Triple:
            case BorderStyle.ThinThickSmallGap:
            case BorderStyle.ThickThinSmallGap:
            case BorderStyle.ThinThickThinSmallGap:
            case BorderStyle.ThinThickMediumGap:
            case BorderStyle.ThickThinMediumGap:
            case BorderStyle.ThinThickThinMediumGap:
            case BorderStyle.ThinThickLargeGap:
            case BorderStyle.ThickThinLargeGap:
            case BorderStyle.ThinThickThinLargeGap:
            case BorderStyle.Emboss3D:
            case BorderStyle.Engrave3D:
                return (float) A_0.method_3();

            case BorderStyle.Outset:
            case BorderStyle.Inset:
                return 1f;
        }
        return A_0.method_8();
    }
}

