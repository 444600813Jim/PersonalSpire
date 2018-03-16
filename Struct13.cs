using System;
using System.Drawing;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct13
{
    public int int_0;
    public int int_1;
    public Struct13(int A_0, int A_1)
    {
        this.int_0 = A_0;
        this.int_1 = A_1;
    }

    public Struct13(int A_0)
    {
        this.int_0 = A_0 & 0xffff;
        this.int_1 = A_0 >> 0x10;
    }

    public static Point smethod_0(Struct13 A_0)
    {
        return new Point(A_0.int_0, A_0.int_1);
    }

    public static PointF smethod_1(Struct13 A_0)
    {
        return new PointF((float) A_0.int_0, (float) A_0.int_1);
    }

    public static Struct13 smethod_2(Point A_0)
    {
        return new Struct13(A_0.X, A_0.Y);
    }
}

