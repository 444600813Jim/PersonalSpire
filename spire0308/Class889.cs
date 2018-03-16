using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;

internal class Class889
{
    internal static void smethod_0(Class672 A_0)
    {
        if (A_0.method_28() == null)
        {
            throw new ArgumentNullException();
        }
        ShapeObject obj2 = A_0.method_28();
        int[] numArray = smethod_18(obj2);
        PointF[] tfArray = smethod_2(obj2.Vertices, numArray);
        A_0.method_31(smethod_3(obj2, numArray));
        smethod_10(A_0, tfArray);
    }

    internal static PointF[] smethod_1(Class891[] A_0)
    {
        return smethod_2(A_0, null);
    }

    private static void smethod_10(Class672 A_0, PointF[] A_1)
    {
        switch (A_0.method_28().ShapeType)
        {
            case ShapeType.Rectangle:
                smethod_11(A_0);
                return;

            case ShapeType.RoundRectangle:
            {
                Size coordSize = A_0.method_28().CoordSize;
                int num = A_0.method_28().method_60(1);
                if (num != 0)
                {
                    smethod_15(A_0, num, coordSize);
                    return;
                }
                smethod_11(A_0);
                return;
            }
            case ShapeType.Ellipse:
                A_0.method_31(smethod_13(A_0));
                return;

            case ShapeType.Line:
                smethod_12(A_0);
                return;
        }
        A_0.method_13(A_0.method_28().SegmentInfo);
        A_0.method_15(A_1);
    }

    private static void smethod_11(Class672 A_0)
    {
        Size coordSize = A_0.method_28().CoordSize;
        A_0.method_13(new Class679[3]);
        A_0.method_12()[0] = new Class679(PathType.MoveTo, 0);
        A_0.method_12()[1] = new Class679(PathType.LineTo, 3);
        PointF[] tfArray = new PointF[] { PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty };
        A_0.method_15(tfArray);
        A_0.method_14()[0] = new PointF(0f, 0f);
        A_0.method_14()[1] = new PointF((float) coordSize.Width, 0f);
        A_0.method_14()[2] = new PointF((float) coordSize.Width, (float) coordSize.Height);
        A_0.method_14()[3] = new PointF(0f, (float) coordSize.Height);
        A_0.method_12()[2] = new Class679(PathType.Close, 0);
    }

    private static void smethod_12(Class672 A_0)
    {
        Size coordSize = A_0.method_28().CoordSize;
        A_0.method_13(new Class679[2]);
        A_0.method_12()[0] = new Class679(PathType.MoveTo, 0);
        A_0.method_12()[1] = new Class679(PathType.LineTo, 1);
        PointF[] tfArray = new PointF[] { PointF.Empty, PointF.Empty };
        A_0.method_15(tfArray);
        A_0.method_14()[1] = new PointF((float) coordSize.Width, (float) coordSize.Height);
    }

    private static RectangleF smethod_13(Class672 A_0)
    {
        Size coordSize = A_0.method_28().CoordSize;
        A_0.method_13(new Class679[2]);
        A_0.method_12()[0] = new Class679(PathType.AngleEllipse, 3);
        PointF[] tfArray = new PointF[] { PointF.Empty, PointF.Empty, PointF.Empty };
        A_0.method_15(tfArray);
        float x = coordSize.Width * 0.5f;
        float y = coordSize.Height * 0.5f;
        A_0.method_14()[0] = new PointF(x, y);
        A_0.method_14()[1] = new PointF(x, y);
        A_0.method_14()[2] = new PointF(0f, -2.359296E+07f);
        A_0.method_12()[1] = new Class679(PathType.Close, 0);
        return smethod_14(coordSize);
    }

    private static RectangleF smethod_14(Size A_0)
    {
        float num = ((float) A_0.Height) / ((float) A_0.Width);
        float num2 = A_0.Width * 0.5f;
        float num3 = A_0.Height * 0.5f;
        float num4 = num3 * num3;
        float num5 = num2 * num2;
        float num6 = (float) Math.Sqrt((double) ((num5 * num4) / (num4 + ((num * num) * num5))));
        float num7 = num * num6;
        float num8 = -num6;
        float num9 = num * num8;
        PointF location = new PointF(num8 + num2, num9 + num3);
        PointF tf2 = new PointF(num6 + num2, num7 + num3);
        return new RectangleF(location, new SizeF(tf2.X - location.X, tf2.Y - location.Y));
    }

    private static void smethod_15(Class672 A_0, int A_1, Size A_2)
    {
        int num;
        int num2;
        if (A_0.method_32().Width > A_0.method_32().Height)
        {
            num = A_1;
            num2 = (int) ((A_0.method_32().Height / A_0.method_32().Width) * A_1);
        }
        else
        {
            num2 = A_1;
            num = (int) ((A_0.method_32().Width / A_0.method_32().Height) * A_1);
        }
        A_0.method_13(new Class679[10]);
        PointF[] tfArray = new PointF[] { PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty };
        A_0.method_15(tfArray);
        A_0.method_12()[0] = new Class679(PathType.MoveTo, 0);
        A_0.method_14()[0] = new PointF(0f, (float) num);
        A_0.method_12()[1] = new Class679(PathType.EllipticalQuadrantY, 1);
        A_0.method_14()[1] = new PointF((float) num2, 0f);
        A_0.method_12()[2] = new Class679(PathType.LineTo, 1);
        A_0.method_14()[2] = new PointF((float) (A_2.Width - num2), 0f);
        A_0.method_12()[3] = new Class679(PathType.EllipticalQuadrantX, 1);
        A_0.method_14()[3] = new PointF((float) A_2.Width, (float) num);
        A_0.method_12()[4] = new Class679(PathType.LineTo, 1);
        A_0.method_14()[4] = new PointF((float) A_2.Width, (float) (A_2.Height - num));
        A_0.method_12()[5] = new Class679(PathType.EllipticalQuadrantY, 1);
        A_0.method_14()[5] = new PointF((float) (A_2.Width - num2), (float) A_2.Height);
        A_0.method_12()[6] = new Class679(PathType.LineTo, 1);
        A_0.method_14()[6] = new PointF((float) num2, (float) A_2.Height);
        A_0.method_12()[7] = new Class679(PathType.EllipticalQuadrantX, 1);
        A_0.method_14()[7] = new PointF(0f, (float) (A_2.Height - num));
        A_0.method_12()[8] = new Class679(PathType.Close, 1);
        A_0.method_12()[9] = new Class679(PathType.End, 0);
    }

    private static float smethod_16(Class623 A_0, int[] A_1)
    {
        return (A_0.method_0() ? ((float) A_1[A_0.method_1() - 3]) : ((float) A_0.method_1()));
    }

    private static float smethod_17(Class623 A_0, int[] A_1)
    {
        if (A_0.method_0() && (A_1 == null))
        {
            return 0f;
        }
        return (A_0.method_0() ? ((float) A_1[A_0.method_1()]) : ((float) A_0.method_1()));
    }

    internal static int[] smethod_18(ShapeObject A_0)
    {
        Class456[] formulas = A_0.Formulas;
        if ((formulas == null) || (formulas.Length == 0))
        {
            return null;
        }
        int[] numArray = new int[formulas.Length];
        for (int i = 0; i < formulas.Length; i++)
        {
            int num3;
            Class456 class2 = formulas[i];
            int num2 = class2.method_0() ? smethod_19(A_0, numArray, class2.int_1) : class2.int_1;
            int num = class2.method_1() ? smethod_19(A_0, numArray, class2.int_2) : class2.int_2;
            int num4 = class2.method_2() ? smethod_19(A_0, numArray, class2.int_3) : class2.int_3;
            switch (class2.operation_0)
            {
                case Operation.Sum:
                    num3 = (num2 + num) - num4;
                    break;

                case Operation.Prod:
                    num3 = num2 * num;
                    if (num4 != 0)
                    {
                        num3 /= num4;
                    }
                    break;

                case Operation.Mid:
                    num3 = (num2 + num) / 2;
                    break;

                case Operation.Abs:
                    num3 = Math.Abs(num2);
                    break;

                case Operation.Min:
                    num3 = Math.Min(num2, num);
                    break;

                case Operation.Max:
                    num3 = Math.Max(num2, num);
                    break;

                case Operation.If:
                    num3 = (num2 > 0) ? num : num4;
                    break;

                case Operation.Mod:
                    num3 = (int) Math.Sqrt((double) (((num2 * num2) + (num * num)) + (num4 * num4)));
                    break;

                case Operation.Atan2:
                    num3 = (int) (Class1133.smethod_1(Math.Atan2((double) num, (double) num2)) * 65536.0);
                    break;

                case Operation.Sin:
                    num3 = (int) (num2 * Math.Sin(Class1133.smethod_0((double) (((float) num) / 65536f))));
                    break;

                case Operation.Cos:
                    num3 = (int) (num2 * Math.Cos(Class1133.smethod_0((double) (((float) num) / 65536f))));
                    break;

                case Operation.CosAtan2:
                    num3 = (int) (num2 * Math.Cos(Math.Atan2((double) num4, (double) num)));
                    break;

                case Operation.SinAtan2:
                    num3 = (int) (num2 * Math.Sin(Math.Atan2((double) num4, (double) num)));
                    break;

                case Operation.Sqrt:
                    num3 = (int) Math.Floor(Math.Sqrt((double) num2));
                    break;

                case Operation.SumAngle:
                    num3 = (num2 + (num * 0x10000)) - (num4 * 0x10000);
                    break;

                case Operation.Ellipse:
                    num3 = (int) (num4 * Math.Sqrt(1.0 - Math.Pow(((double) num2) / ((double) num), 2.0)));
                    break;

                case Operation.Tan:
                    num3 = (int) (num2 * Math.Tan(Class1133.smethod_0((double) (((float) num) / 65536f))));
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            numArray[i] = num3;
        }
        return numArray;
    }

    private static int smethod_19(ShapeObject A_0, int[] A_1, int A_2)
    {
        int num = 14;
        if ((A_2 >= 0x400) && (A_2 <= 0x47f))
        {
            return A_1[A_2 - 0x400];
        }
        switch (A_2)
        {
            case 320:
                return (A_0.CoordOriginX + (A_0.CoordSizeWidth / 2));

            case 0x141:
                return (A_0.CoordOriginY + (A_0.CoordSizeHeight / 2));

            case 0x142:
                return A_0.CoordSizeWidth;

            case 0x143:
                return A_0.CoordSizeHeight;

            case 0x147:
                return A_0.method_60(1);

            case 0x148:
                return A_0.method_60(2);

            case 0x149:
                return A_0.method_60(3);

            case 330:
                return A_0.method_60(4);

            case 0x14b:
                return A_0.method_60(5);

            case 0x14c:
                return A_0.method_60(6);

            case 0x14d:
                return A_0.method_60(7);

            case 0x14e:
                return A_0.method_60(8);

            case 0x153:
                return A_0.LimoX;

            case 340:
                return A_0.LimoY;

            case 0x1fc:
                if (!A_0.IsStroked)
                {
                    return 0;
                }
                return 1;

            case 0x4f7:
                return (int) Class969.smethod_50((int) A_0.LineWidth);

            case 0x4f8:
                return (int) Class509.smethod_0(A_0.Width);

            case 0x4f9:
                return (int) Class509.smethod_0(A_0.Height);

            case 0x4fc:
                return Class969.smethod_40(A_0.Width);

            case 0x4fd:
                return Class969.smethod_40(A_0.Height);

            case 0x4fe:
                return Class969.smethod_40(A_0.Width * 0.5);

            case 0x4ff:
                return Class969.smethod_40(A_0.Height * 0.5);
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("䐳圵䨷嬹儻", num), string.Format(BookmarkStart.b("爳夵䨷圹䤻刽ℿ扁❃❅⑇⥉㥋≍ㅏ♑ㅓ㉕硗⩙㵛ⱝşཡţብ൧ᡩ䱫٭ᅯű味u᥷ᙹॻ᭽ꁿ벅ꢇ벋", num), A_2));
    }

    private static PointF[] smethod_2(Class891[] A_0, int[] A_1)
    {
        if (A_0 == null)
        {
            return null;
        }
        PointF[] tfArray = new PointF[A_0.Length];
        for (int i = 0; i < A_0.Length; i++)
        {
            Class891 class2 = A_0[i];
            int num2 = class2.method_0().method_1();
            int num3 = class2.method_1().method_1();
            if (A_1 != null)
            {
                if (class2.method_0().method_0())
                {
                    num2 = A_1[class2.method_0().method_1()];
                }
                if (class2.method_1().method_0())
                {
                    num3 = A_1[class2.method_1().method_1()];
                }
            }
            tfArray[i] = new PointF((float) num2, (float) num3);
        }
        return tfArray;
    }

    private static RectangleF smethod_3(ShapeObject A_0, int[] A_1)
    {
        bool flag = smethod_5(A_0);
        Class70[] textBoxRects = A_0.TextBoxRects;
        switch (textBoxRects.Length)
        {
            case 1:
                return smethod_9(textBoxRects[0], A_1);

            case 2:
                return smethod_9(flag ? textBoxRects[0] : textBoxRects[3], A_1);

            case 3:
                return smethod_4(A_0, textBoxRects, A_1);

            case 6:
                return smethod_4(A_0, textBoxRects, A_1);
        }
        return new RectangleF(0f, 0f, (float) A_0.CoordSizeWidth, (float) A_0.CoordSizeHeight);
    }

    private static RectangleF smethod_4(ShapeObject A_0, Class70[] A_1, int[] A_2)
    {
        float num2;
        float num3;
        RectangleF ef;
        RectangleF ef2;
        float num6;
        int index = 0;
        if ((A_1.Length == 6) && !smethod_5(A_0))
        {
            index = 3;
        }
        if ((A_0.Handles == null) || (A_0.Handles.Length == 0))
        {
            return smethod_9(A_1[index], A_2);
        }
        Class784 class2 = A_0.Handles[0];
        int num5 = A_0.method_60(1);
        if ((class2.class72_0.method_1() == HandlePositionType.Adjust) && (class2.class72_0.method_2() == 0))
        {
            num2 = smethod_16(class2.class623_2, A_2);
            num3 = smethod_16(class2.class623_3, A_2);
        }
        else
        {
            num2 = smethod_16(class2.class623_4, A_2);
            num3 = smethod_16(class2.class623_5, A_2);
        }
        float num4 = num2 + ((num3 - num2) / 2f);
        if (num5 < num4)
        {
            ef = smethod_9(A_1[index], A_2);
            ef2 = smethod_9(A_1[index + 1], A_2);
            num6 = smethod_6(num2, num4, (float) num5);
        }
        else
        {
            ef = smethod_9(A_1[index + 1], A_2);
            ef2 = smethod_9(A_1[index + 2], A_2);
            num6 = smethod_6(num4, num3, num5 - num4);
        }
        return smethod_7(ef, ef2, num6);
    }

    private static bool smethod_5(ShapeObject A_0)
    {
        if (A_0.TextBox.method_10() != LayoutFlow.Horizontal)
        {
            return (A_0.TextBox.method_10() == LayoutFlow.HorizontalIdeographic);
        }
        return true;
    }

    private static float smethod_6(float A_0, float A_1, float A_2)
    {
        return (A_2 / (A_1 - A_0));
    }

    private static RectangleF smethod_7(RectangleF A_0, RectangleF A_1, float A_2)
    {
        float x = smethod_8(A_0.X, A_1.X, A_2);
        float y = smethod_8(A_0.Y, A_1.Y, A_2);
        float width = smethod_8(A_0.Right, A_1.Right, A_2) - x;
        return new RectangleF(x, y, width, smethod_8(A_0.Bottom, A_1.Bottom, A_2) - y);
    }

    private static float smethod_8(float A_0, float A_1, float A_2)
    {
        return (A_0 + ((A_1 - A_0) * A_2));
    }

    private static RectangleF smethod_9(Class70 A_0, int[] A_1)
    {
        float x = smethod_17(A_0.class623_0, A_1);
        float y = smethod_17(A_0.class623_1, A_1);
        float width = smethod_17(A_0.class623_2, A_1) - x;
        return new RectangleF(x, y, width, smethod_17(A_0.class623_3, A_1) - y);
    }
}

