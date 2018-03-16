using Spire.Doc;
using System;
using System.Drawing;

internal class Class628
{
    internal static readonly Color color_0 = Color.Gray;
    private readonly Interface0 interface0_0;

    internal Class628(Interface0 A_0)
    {
        this.interface0_0 = A_0;
    }

    internal bool method_0()
    {
        return (bool) this.method_12(0x3b4);
    }

    internal void method_1(bool A_0)
    {
        this.method_13(0x3b4, A_0);
    }

    internal void method_10(double A_0)
    {
        this.method_11(A_0, false);
    }

    private void method_11(double A_0, bool A_1)
    {
        A_0 = Class567.smethod_23(A_0, 0.0, 0.0, 100.0, 100.0, A_1, BookmarkStart.b("䄰嘲䜴吶尸唺䤼", 11));
        this.method_13(0x393, smethod_1(A_0));
    }

    private object method_12(int A_0)
    {
        return this.interface0_0.imethod_2(A_0);
    }

    private void method_13(int A_0, object A_1)
    {
        this.interface0_0.imethod_3(A_0, A_1);
    }

    internal bool method_2()
    {
        return (bool) this.method_12(0x3b3);
    }

    internal void method_3(bool A_0)
    {
        this.method_13(0x3b3, A_0);
    }

    internal bool method_4()
    {
        return (bool) this.method_12(0x3b2);
    }

    internal void method_5(bool A_0)
    {
        this.method_13(0x3b2, A_0);
    }

    internal ShapeHorizontalAlignment method_6()
    {
        return (ShapeHorizontalAlignment) this.method_12(0x394);
    }

    internal void method_7(ShapeHorizontalAlignment A_0)
    {
        this.method_13(0x394, A_0);
    }

    internal double method_8()
    {
        return smethod_0((int) this.method_12(0x393));
    }

    internal void method_9(double A_0)
    {
        this.method_11(A_0, true);
    }

    private static double smethod_0(int A_0)
    {
        return (((double) A_0) / 10.0);
    }

    private static int smethod_1(double A_0)
    {
        return (int) (A_0 * 10.0);
    }
}

