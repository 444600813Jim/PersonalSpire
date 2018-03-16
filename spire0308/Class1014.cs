using System;
using System.Drawing;

internal class Class1014
{
    internal byte[] byte_0;
    internal byte[] byte_1;
    internal short short_0;
    internal short short_1;
    internal short short_10;
    internal short short_11;
    internal short short_12;
    internal short short_13;
    internal short short_14;
    internal short short_15;
    internal short short_16;
    internal short short_2;
    internal short short_3;
    internal short short_4;
    internal short short_5;
    internal short short_6;
    internal short short_7;
    internal short short_8;
    internal short short_9;
    private const uint uint_0 = 0x80000000;
    private const uint uint_1 = 0x2df00000;
    internal uint uint_2;
    internal uint uint_3;
    internal uint uint_4;
    internal uint uint_5;
    internal uint uint_6;
    internal uint uint_7;
    private const ushort ushort_0 = 0x80;
    internal ushort ushort_1;
    internal ushort ushort_10;
    internal ushort ushort_11;
    internal ushort ushort_12;
    internal ushort ushort_2;
    internal ushort ushort_3;
    internal ushort ushort_4;
    internal ushort ushort_5;
    internal ushort ushort_6;
    internal ushort ushort_7;
    internal ushort ushort_8;
    internal ushort ushort_9;

    internal Class1014(Class303 A_0)
    {
        this.ushort_12 = A_0.method_4();
        this.short_6 = A_0.method_3();
        this.ushort_8 = A_0.method_4();
        this.ushort_9 = A_0.method_4();
        this.ushort_2 = A_0.method_4();
        this.short_10 = A_0.method_3();
        this.short_12 = A_0.method_3();
        this.short_9 = A_0.method_3();
        this.short_11 = A_0.method_3();
        this.short_14 = A_0.method_3();
        this.short_16 = A_0.method_3();
        this.short_13 = A_0.method_3();
        this.short_15 = A_0.method_3();
        this.short_8 = A_0.method_3();
        this.short_7 = A_0.method_3();
        this.short_1 = A_0.method_3();
        this.byte_1 = A_0.method_8(10);
        this.uint_4 = A_0.method_2();
        this.uint_5 = A_0.method_2();
        this.uint_6 = A_0.method_2();
        this.uint_7 = A_0.method_2();
        this.byte_0 = A_0.method_8(4);
        this.ushort_1 = A_0.method_4();
        this.ushort_5 = A_0.method_4();
        this.ushort_6 = A_0.method_4();
        this.short_2 = A_0.method_3();
        this.short_3 = A_0.method_3();
        this.short_4 = A_0.method_3();
        this.ushort_10 = A_0.method_4();
        this.ushort_11 = A_0.method_4();
        if (this.ushort_12 > 0)
        {
            this.uint_2 = A_0.method_2();
            this.uint_3 = A_0.method_2();
            if (this.ushort_12 > 1)
            {
                this.short_5 = A_0.method_3();
                this.short_0 = A_0.method_3();
                this.ushort_4 = A_0.method_4();
                this.ushort_3 = A_0.method_4();
                this.ushort_7 = A_0.method_4();
            }
        }
    }

    internal bool method_0()
    {
        return ((Class710.smethod_7(this.uint_5, 0x2df00000) && (this.ushort_12 < 4)) && (this.ushort_12 > 0));
    }

    internal bool method_1()
    {
        return Class710.smethod_8(this.ushort_1, 0x80);
    }

    internal bool method_2()
    {
        return Class710.smethod_7(this.uint_2, 0x80000000);
    }

    internal FontStyle method_3()
    {
        FontStyle regular = FontStyle.Regular;
        regular = FontStyle.Regular | (((this.ushort_1 & 1) != 0) ? FontStyle.Italic : FontStyle.Regular);
        regular |= ((this.ushort_1 & 2) != 0) ? FontStyle.Underline : FontStyle.Regular;
        regular |= ((this.ushort_1 & 0x10) != 0) ? FontStyle.Strikeout : FontStyle.Regular;
        return (regular | (((this.ushort_1 & 0x20) != 0) ? FontStyle.Bold : FontStyle.Regular));
    }
}

