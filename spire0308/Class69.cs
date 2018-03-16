using System;
using System.Drawing;

internal class Class69
{
    private Class722 class722_0;
    private RectangleF rectangleF_0;
    private readonly spr➓ spr➓_0;

    internal Class69(spr➓ A_0)
    {
        this.spr➓_0 = A_0;
        this.rectangleF_0 = RectangleF.Empty;
    }

    internal void method_0(Class724 A_0)
    {
        this.rectangleF_0 = Class725.smethod_0(A_0, this.spr➓_0);
    }

    internal spr➓ method_1()
    {
        return this.spr➓_0;
    }

    internal Class722 method_2()
    {
        return this.class722_0;
    }

    internal void method_3(Class722 A_0)
    {
        this.class722_0 = A_0;
    }

    internal RectangleF method_4()
    {
        return this.rectangleF_0;
    }

    internal void method_5(RectangleF A_0)
    {
        this.rectangleF_0 = A_0;
    }
}

