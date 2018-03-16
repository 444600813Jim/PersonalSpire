using System;
using System.Drawing;

internal class Class1122
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private float[] float_0;
    private int int_0;
    private PointF[] pointF_0;

    internal Class1122(bool A_0, bool A_1, bool A_2, int A_3, PointF[] A_4, float[] A_5)
    {
        this.method_1(A_0);
        this.method_3(A_1);
        this.method_5(A_2);
        this.method_7(A_3);
        this.method_9(A_4);
        this.method_11(A_5);
    }

    internal bool method_0()
    {
        return this.bool_0;
    }

    internal void method_1(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal float[] method_10()
    {
        return this.float_0;
    }

    internal void method_11(float[] A_0)
    {
        this.float_0 = A_0;
    }

    internal bool method_2()
    {
        return this.bool_1;
    }

    internal void method_3(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal bool method_4()
    {
        return this.bool_2;
    }

    internal void method_5(bool A_0)
    {
        this.bool_2 = A_0;
    }

    internal int method_6()
    {
        return this.int_0;
    }

    internal void method_7(int A_0)
    {
        this.int_0 = A_0;
    }

    internal PointF[] method_8()
    {
        return this.pointF_0;
    }

    internal void method_9(PointF[] A_0)
    {
        this.pointF_0 = A_0;
    }

    internal static Class1122 smethod_0()
    {
        return new Class1122(false, false, false, 0, null, null);
    }
}

