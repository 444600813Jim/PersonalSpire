using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;

internal class Class781
{
    private const int int_0 = 5;
    private const int int_1 = 6;

    private Class781()
    {
    }

    internal static void smethod_0(Class43 A_0)
    {
        EsShapePath linesClosed = EsShapePath.LinesClosed;
        object obj2 = A_0.method_31(0x144);
        if (obj2 != null)
        {
            linesClosed = (EsShapePath) obj2;
            A_0.Remove(0x144);
        }
        Class891[] classArray = (Class891[]) A_0.method_31(0x145);
        if ((classArray == null) || (classArray.Length == 0))
        {
            return;
        }
        Class679[] classArray2 = (Class679[]) A_0.method_31(0x146);
        if ((classArray2 != null) && (classArray2.Length > 0))
        {
            return;
        }
        ShapeType type = (ShapeType) A_0.method_31(0x103b);
        if (type == ShapeType.Arc)
        {
            classArray2 = smethod_1();
        }
        else
        {
            switch (linesClosed)
            {
                case EsShapePath.Lines:
                    classArray2 = smethod_2(classArray);
                    goto Label_0151;

                case EsShapePath.LinesClosed:
                    classArray2 = new Class679[] { new Class679(PathType.MoveTo, 0), new Class679(PathType.LineTo, classArray.Length - 1), new Class679(PathType.Close, 1), new Class679(PathType.End, 0) };
                    goto Label_0151;

                case EsShapePath.Curves:
                {
                    classArray2 = new Class679[3];
                    classArray2[0] = new Class679(PathType.MoveTo, 0);
                    int num = (classArray.Length - 1) / 3;
                    classArray2[1] = new Class679(PathType.CurveTo, num);
                    classArray2[2] = new Class679(PathType.End, 0);
                    goto Label_0151;
                }
                case EsShapePath.CurvesClosed:
                {
                    classArray2 = new Class679[4];
                    classArray2[0] = new Class679(PathType.MoveTo, 0);
                    int num2 = (classArray.Length - 1) / 3;
                    classArray2[1] = new Class679(PathType.CurveTo, num2);
                    classArray2[2] = new Class679(PathType.Close, 1);
                    classArray2[3] = new Class679(PathType.End, 0);
                    goto Label_0151;
                }
            }
            classArray2 = smethod_2(classArray);
        }
    Label_0151:
        A_0.SetAttr(0x146, classArray2);
    }

    private static Class679[] smethod_1()
    {
        return (Class679[]) Class565.smethod_1(ShapeType.Arc).method_31(0x146);
    }

    private static Class679[] smethod_2(Class891[] A_0)
    {
        return new Class679[] { new Class679(PathType.MoveTo, 0), new Class679(PathType.LineTo, A_0.Length - 1), new Class679(PathType.End, 0) };
    }

    internal static Class679 smethod_3(int A_0)
    {
        int num = (A_0 & 0xe000) >> 13;
        if ((num != 5) && (num != 6))
        {
            return new Class679((PathType) num, A_0 & 0x1fff);
        }
        num = (A_0 & 0xff00) >> 8;
        return new Class679((PathType) num, A_0 & 0xff);
    }

    internal static int smethod_4(Class679 A_0)
    {
        if (A_0.method_0() >= PathType.EscapeBase)
        {
            return (A_0.method_1() | (((int) A_0.method_0()) << 8));
        }
        return (A_0.method_1() | (((int) A_0.method_0()) << 13));
    }
}

