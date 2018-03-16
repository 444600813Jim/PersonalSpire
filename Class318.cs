using System;
using System.Drawing;

internal class Class318
{
    private bool bool_0;
    private float[] float_0;
    private float[] float_1;
    private int int_0;
    private PointF[] pointF_0;

    internal Class318(bool A_0, int A_1, float[] A_2, float[] A_3, PointF[] A_4)
    {
        this.method_1(A_0);
        this.method_3(A_1);
        this.method_5(A_2);
        this.method_7(A_3);
        this.method_9(A_4);
    }

    internal bool method_0()
    {
        return this.bool_0;
    }

    internal void method_1(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal int method_2()
    {
        return this.int_0;
    }

    internal void method_3(int A_0)
    {
        this.int_0 = A_0;
    }

    internal float[] method_4()
    {
        return this.float_0;
    }

    internal void method_5(float[] A_0)
    {
        this.float_0 = A_0;
    }

    internal float[] method_6()
    {
        return this.float_1;
    }

    internal void method_7(float[] A_0)
    {
        this.float_1 = A_0;
    }

    internal PointF[] method_8()
    {
        return this.pointF_0;
    }

    internal void method_9(PointF[] A_0)
    {
        this.pointF_0 = A_0;
    }

    internal static Class318 smethod_0()
    {
        return new Class318(false, 0, null, null, null);
    }
}

