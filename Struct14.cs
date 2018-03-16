using System;
using System.Drawing;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct14
{
    public short short_0;
    public short short_1;
    public Struct14(short A_0, short A_1)
    {
        this.short_0 = A_0;
        this.short_1 = A_1;
    }

    public static Point smethod_0(Struct14 A_0)
    {
        return new Point(A_0.short_0, A_0.short_1);
    }

    public static PointF smethod_1(Struct14 A_0)
    {
        return new PointF((float) A_0.short_0, (float) A_0.short_1);
    }

    public static Struct14 smethod_2(Point A_0)
    {
        return new Struct14((short) A_0.X, (short) A_0.Y);
    }

    public static Struct14 smethod_3(PointF A_0)
    {
        return new Struct14((short) A_0.X, (short) A_0.Y);
    }
}

