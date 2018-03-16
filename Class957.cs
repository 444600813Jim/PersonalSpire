using System;

internal class Class957
{
    internal const int int_0 = 0x5024;
    private const int int_1 = 1;
    private const int int_10 = 0x400;
    private const int int_11 = 0x800;
    private const int int_12 = 0x1000;
    private const int int_13 = 0x2000;
    private const int int_14 = 0x4000;
    private const int int_15 = 0x8000;
    private int int_16;
    private const int int_2 = 2;
    private const int int_3 = 4;
    private const int int_4 = 8;
    private const int int_5 = 0x20;
    private const int int_6 = 0x40;
    private const int int_7 = 0x80;
    private const int int_8 = 0x100;
    private const int int_9 = 0x200;

    internal Class957()
    {
        this.int_16 = 0x5024;
    }

    internal Class957(int A_0)
    {
        this.int_16 = A_0;
    }

    internal int method_0()
    {
        return this.int_16;
    }

    internal bool method_1()
    {
        return this.method_31(this.int_16, 1);
    }

    internal void method_10(bool A_0)
    {
        this.method_32(0x20, A_0);
    }

    internal bool method_11()
    {
        return this.method_31(this.int_16, 0x40);
    }

    internal void method_12(bool A_0)
    {
        this.method_32(0x40, A_0);
    }

    internal bool method_13()
    {
        return this.method_31(this.int_16, 0x80);
    }

    internal void method_14(bool A_0)
    {
        this.method_32(0x80, A_0);
    }

    internal bool method_15()
    {
        return this.method_31(this.int_16, 0x100);
    }

    internal void method_16(bool A_0)
    {
        this.method_32(0x100, A_0);
    }

    internal bool method_17()
    {
        return this.method_31(this.int_16, 0x200);
    }

    internal void method_18(bool A_0)
    {
        this.method_32(0x200, A_0);
    }

    internal bool method_19()
    {
        return this.method_31(this.int_16, 0x400);
    }

    internal void method_2(bool A_0)
    {
        this.method_32(1, A_0);
    }

    internal void method_20(bool A_0)
    {
        this.method_32(0x400, A_0);
    }

    internal bool method_21()
    {
        return this.method_31(this.int_16, 0x800);
    }

    internal void method_22(bool A_0)
    {
        this.method_32(0x800, A_0);
    }

    internal bool method_23()
    {
        return this.method_31(this.int_16, 0x1000);
    }

    internal void method_24(bool A_0)
    {
        this.method_32(0x1000, A_0);
    }

    internal bool method_25()
    {
        return this.method_31(this.int_16, 0x2000);
    }

    internal void method_26(bool A_0)
    {
        this.method_32(0x2000, A_0);
    }

    internal bool method_27()
    {
        return this.method_31(this.int_16, 0x4000);
    }

    internal void method_28(bool A_0)
    {
        this.method_32(0x4000, A_0);
    }

    internal bool method_29()
    {
        return this.method_31(this.int_16, 0x8000);
    }

    internal bool method_3()
    {
        return this.method_31(this.int_16, 2);
    }

    internal void method_30(bool A_0)
    {
        this.method_32(0x8000, A_0);
    }

    private bool method_31(int A_0, int A_1)
    {
        return ((A_0 & A_1) != 0);
    }

    private void method_32(int A_0, bool A_1)
    {
        this.int_16 = smethod_0(this.int_16, A_0, A_1);
    }

    internal void method_4(bool A_0)
    {
        this.method_32(2, A_0);
    }

    internal bool method_5()
    {
        return this.method_31(this.int_16, 4);
    }

    internal void method_6(bool A_0)
    {
        this.method_32(4, A_0);
    }

    internal bool method_7()
    {
        return this.method_31(this.int_16, 8);
    }

    internal void method_8(bool A_0)
    {
        this.method_32(8, A_0);
    }

    internal bool method_9()
    {
        return this.method_31(this.int_16, 0x20);
    }

    public static int smethod_0(int A_0, int A_1, bool A_2)
    {
        if (A_2)
        {
            return (A_0 | A_1);
        }
        return (A_0 & ~A_1);
    }
}

