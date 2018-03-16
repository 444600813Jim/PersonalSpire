using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Drawing;

internal class Class969
{
    public const double double_0 = 32767.999984741211;
    public const double double_1 = -32768.999984741211;
    private const double double_10 = 240.0;
    public const double double_11 = 0.05;
    public const double double_12 = 12700.0;
    private const double double_13 = 914400.0;
    private const double double_14 = 36000.000000000007;
    private const double double_15 = 635.0;
    public const double double_16 = 1584.0;
    public const double double_17 = 20116800.0;
    public const double double_18 = 0.75;
    public const double double_19 = 60000.0;
    public const double double_2 = 25.4;
    public const double double_3 = 72.0;
    private const double double_4 = 2.8346456692913389;
    private const double double_5 = 28.346456692913389;
    private const double double_6 = 12.0;
    public const double double_7 = 20.0;
    public const double double_8 = 1440.0;
    private const double double_9 = 56.692913385826778;
    public const float float_0 = 0.72f;
    public const float float_1 = 0.072f;
    public const float float_2 = 0.2834646f;
    public const float float_3 = 0.02834646f;
    public const float float_4 = 0.002834646f;
    public static float float_5 = 1.333333f;
    public static float float_6 = ((float) (1.0 / ((double) float_5)));
    public const int int_0 = 0x3e8;
    private const int int_1 = 0x11940;
    public const int int_2 = 50;
    private const int int_3 = 500;
    public const int int_4 = 0x7bc0;
    public const int int_5 = 15;
    public const int int_6 = 0x182b80;

    private Class969()
    {
    }

    public static double smethod_0(double A_0)
    {
        return smethod_1(A_0, 96.0);
    }

    public static double smethod_1(double A_0, double A_1)
    {
        return ((A_0 / 72.0) * A_1);
    }

    public static double smethod_10(double A_0, double A_1)
    {
        return ((A_0 / A_1) * 72.0);
    }

    public static int smethod_11(double A_0, double A_1)
    {
        return Class1133.smethod_5((A_0 / A_1) * 1440.0);
    }

    public static int smethod_12(double A_0, double A_1, double A_2)
    {
        return Class1133.smethod_5((A_0 * A_2) / A_1);
    }

    public static double smethod_13(double A_0)
    {
        return (A_0 * 72.0);
    }

    public static double smethod_14(double A_0)
    {
        return (A_0 / 72.0);
    }

    public static double smethod_15(double A_0)
    {
        return (A_0 * 2.8346456692913389);
    }

    public static int smethod_16(double A_0)
    {
        return Class1133.smethod_5(A_0 * 56.692913385826778);
    }

    public static int smethod_17(double A_0)
    {
        return Class1133.smethod_5(smethod_18(A_0));
    }

    public static double smethod_18(double A_0)
    {
        return smethod_19(A_0, 96.0);
    }

    public static double smethod_19(double A_0, double A_1)
    {
        return ((A_0 * A_1) / 25.4);
    }

    public static int smethod_2(double A_0)
    {
        return Class1133.smethod_5(smethod_0(A_0));
    }

    public static double smethod_20(double A_0)
    {
        return smethod_21(A_0, 96.0);
    }

    public static double smethod_21(double A_0, double A_1)
    {
        return (A_0 * A_1);
    }

    public static double smethod_22(double A_0)
    {
        return (A_0 * 28.346456692913389);
    }

    public static double smethod_23(double A_0)
    {
        return (A_0 * 12.0);
    }

    public static int smethod_24(int A_0)
    {
        return Class1133.smethod_5((A_0 * 240.0) / 100.0);
    }

    public static double smethod_25(double A_0)
    {
        return (A_0 / 12.0);
    }

    public static int smethod_26(double A_0)
    {
        return Class1133.smethod_5(A_0 * 2.0);
    }

    public static double smethod_27(int A_0)
    {
        return (((double) A_0) / 2.0);
    }

    public static int smethod_28(double A_0)
    {
        return Class1133.smethod_5(A_0 * 8.0);
    }

    public static double smethod_29(int A_0)
    {
        return (((double) A_0) / 8.0);
    }

    public static int smethod_3(double A_0, double A_1)
    {
        return Class1133.smethod_5(smethod_1(A_0, A_1));
    }

    public static int smethod_30(int A_0)
    {
        return Class1133.smethod_5(A_0 * 2.5);
    }

    public static int smethod_31(double A_0)
    {
        return Class1133.smethod_5(A_0 * 20.0);
    }

    public static double smethod_32(int A_0)
    {
        return (((double) A_0) / 20.0);
    }

    public static double smethod_33(double A_0)
    {
        return (A_0 / 20.0);
    }

    public static double smethod_34(int A_0)
    {
        return (((double) A_0) / 56.692913385826778);
    }

    public static double smethod_35(int A_0)
    {
        return (((double) A_0) / 12.0);
    }

    public static int smethod_36(int A_0)
    {
        return smethod_2(smethod_32(A_0));
    }

    public static int smethod_37(double A_0)
    {
        return Class1133.smethod_5(A_0 * 1440.0);
    }

    public static int smethod_38(int A_0)
    {
        return Class1133.smethod_5(((double) A_0) / 635.0);
    }

    public static int smethod_39(int A_0)
    {
        return Class1133.smethod_5(A_0 * 635.0);
    }

    public static int smethod_4(double A_0, double A_1)
    {
        return Math.Max((int) Math.Ceiling(smethod_1(A_0, A_1)), 1);
    }

    public static int smethod_40(double A_0)
    {
        return Class1133.smethod_5(A_0 * 12700.0);
    }

    public static RectangleF smethod_41(RectangleF A_0)
    {
        return RectangleF.FromLTRB((float) smethod_40((double) A_0.Left), (float) smethod_40((double) A_0.Top), (float) smethod_40((double) A_0.Right), (float) smethod_40((double) A_0.Bottom));
    }

    public static double smethod_42(int A_0)
    {
        return (((double) A_0) / 12700.0);
    }

    public static double smethod_43(double A_0)
    {
        return (A_0 / 12700.0);
    }

    public static RectangleF smethod_44(RectangleF A_0)
    {
        return new RectangleF((float) smethod_43((double) A_0.Left), (float) smethod_43((double) A_0.Top), (float) smethod_43((double) A_0.Width), (float) smethod_43((double) A_0.Height));
    }

    public static double smethod_45(int A_0)
    {
        return (double) smethod_40(smethod_8((double) A_0));
    }

    public static double smethod_46(int A_0, double A_1)
    {
        return (double) smethod_40(smethod_10((double) A_0, A_1));
    }

    public static RectangleF smethod_47(RectangleF A_0, double A_1)
    {
        return RectangleF.FromLTRB((float) smethod_46((int) A_0.Left, A_1), (float) smethod_46((int) A_0.Top, A_1), (float) smethod_46((int) A_0.Right, A_1), (float) smethod_46((int) A_0.Bottom, A_1));
    }

    public static RectangleF smethod_48(RectangleF A_0)
    {
        return new RectangleF((float) smethod_45((int) A_0.Left), (float) smethod_45((int) A_0.Top), (float) smethod_45((int) A_0.Width), (float) smethod_45((int) A_0.Height));
    }

    public static double smethod_49(int A_0)
    {
        return (((double) A_0) / 914400.0);
    }

    public static Size smethod_5(SizeF A_0, float A_1, double A_2)
    {
        int num = 0;
        if (A_1 <= 0f)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("唥䬧䬩䀫䬭", num));
        }
        if (A_2 <= 0.0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䈥堧䌩", num));
        }
        return new Size(smethod_3((double) (A_0.Width * A_1), A_2), smethod_3((double) (A_0.Height * A_1), A_2));
    }

    public static float smethod_50(int A_0)
    {
        return (float) smethod_0(((double) A_0) / 12700.0);
    }

    public static RectangleF smethod_51(RectangleF A_0)
    {
        return RectangleF.FromLTRB(smethod_50((int) A_0.Left), smethod_50((int) A_0.Top), smethod_50((int) A_0.Right), smethod_50((int) A_0.Bottom));
    }

    public static double smethod_52(int A_0)
    {
        return (((double) A_0) / 36000.000000000007);
    }

    public static int smethod_53(double A_0, double A_1)
    {
        return Class1133.smethod_5((A_1 * A_0) / 72000.0);
    }

    public static int smethod_54(int A_0)
    {
        return smethod_53((double) A_0, 96.0);
    }

    public static int smethod_55(double A_0)
    {
        return Class1133.smethod_5(A_0 * 1000.0);
    }

    public static float smethod_56(int A_0)
    {
        return (((float) A_0) / 1000f);
    }

    public static int smethod_57(int A_0)
    {
        return (A_0 * 50);
    }

    public static int smethod_58(int A_0)
    {
        return (A_0 / 50);
    }

    public static int smethod_59(double A_0)
    {
        return Class1133.smethod_5(A_0 * 500.0);
    }

    public static double smethod_6(double A_0)
    {
        return (A_0 / 0.0028346458827768761);
    }

    public static float smethod_60(int A_0)
    {
        return (((float) A_0) / 500f);
    }

    public static RectangleF smethod_61(Rectangle A_0)
    {
        return new RectangleF(smethod_56(A_0.X), smethod_56(A_0.Y), smethod_56(A_0.Width), smethod_56(A_0.Height));
    }

    public static PointF smethod_62(Point A_0)
    {
        return new PointF(smethod_56(A_0.X), smethod_56(A_0.Y));
    }

    public static SizeF smethod_63(Size A_0)
    {
        return new SizeF(smethod_56(A_0.Width), smethod_56(A_0.Height));
    }

    public static Rectangle smethod_64(RectangleF A_0)
    {
        return new Rectangle(smethod_55((double) A_0.X), smethod_55((double) A_0.Y), smethod_55((double) A_0.Width), smethod_55((double) A_0.Height));
    }

    public static Point smethod_65(PointF A_0)
    {
        return new Point(smethod_55((double) A_0.X), smethod_55((double) A_0.Y));
    }

    public static float smethod_66(int A_0)
    {
        return ((((float) A_0) / 1000f) / 12f);
    }

    public static Color smethod_67(Color A_0)
    {
        if (!A_0.IsEmpty)
        {
            return new Color();
        }
        return A_0;
    }

    public static double smethod_68(int A_0)
    {
        if ((((double) A_0) / 65536.0) == 32767.999984741211)
        {
            return 3.4028234663852886E+38;
        }
        if ((((double) A_0) / 65536.0) == -32768.999984741211)
        {
            return -3.4028234663852886E+38;
        }
        return (((double) A_0) / 65536.0);
    }

    public static float smethod_69(int A_0)
    {
        return (((float) A_0) / 65536f);
    }

    public static int smethod_7(double A_0)
    {
        return Class1133.smethod_5(smethod_6(A_0));
    }

    public static int smethod_70(float A_0)
    {
        if (A_0 > 32767.999984741211)
        {
            A_0 = 32768f;
        }
        else if (A_0 < -32768.999984741211)
        {
            A_0 = -32769f;
        }
        return Class1133.smethod_5(A_0 * 65536.0);
    }

    public static int smethod_71(double A_0)
    {
        if (A_0 > 32767.999984741211)
        {
            A_0 = 32767.999984741211;
        }
        else if (A_0 < -32768.999984741211)
        {
            A_0 = -32768.999984741211;
        }
        return Class1133.smethod_5(A_0 * 65536.0);
    }

    public static double smethod_72(double A_0)
    {
        return Class1133.smethod_0(A_0 / 60000.0);
    }

    public static double smethod_73(double A_0)
    {
        return (Class1133.smethod_1(A_0) * 60000.0);
    }

    public static double smethod_74(double A_0)
    {
        return (A_0 * 60000.0);
    }

    public static double smethod_75(double A_0)
    {
        return (A_0 / 60000.0);
    }

    public static BorderStyle smethod_76(ShapeLineStyle A_0, LineDashing A_1)
    {
        BorderStyle single = BorderStyle.Single;
        switch (A_0)
        {
            case ShapeLineStyle.Single:
                switch (A_1)
                {
                    case LineDashing.Dash:
                        return BorderStyle.DashSmallGap;

                    case LineDashing.Dot:
                        return BorderStyle.Dot;

                    case LineDashing.DashDot:
                        return BorderStyle.DotDash;

                    case LineDashing.DashDotDot:
                        return BorderStyle.DotDotDash;
                }
                break;

            case ShapeLineStyle.Double:
                return BorderStyle.ThickThinSmallGap;

            case ShapeLineStyle.ThickThin:
                return BorderStyle.ThickThinMediumGap;

            case ShapeLineStyle.ThinThick:
                return BorderStyle.ThinThickMediumGap;

            case ShapeLineStyle.Triple:
                return BorderStyle.ThinThickThinMediumGap;

            default:
                return single;
        }
        return BorderStyle.Single;
    }

    public static double smethod_8(double A_0)
    {
        return smethod_10(A_0, 96.0);
    }

    public static RectangleF smethod_9(RectangleF A_0)
    {
        return RectangleF.FromLTRB((float) smethod_8((double) A_0.Left), (float) smethod_8((double) A_0.Top), (float) smethod_8((double) A_0.Right), (float) smethod_8((double) A_0.Bottom));
    }
}

