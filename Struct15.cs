using Spire.Doc;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct15
{
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public Struct15(int A_0, int A_1, int A_2, int A_3)
    {
        this.int_0 = A_0;
        this.int_1 = A_1;
        this.int_2 = A_2;
        this.int_3 = A_3;
    }

    public int method_0()
    {
        return (this.int_2 - this.int_0);
    }

    public int method_1()
    {
        return (this.int_3 - this.int_1);
    }

    public Point method_2()
    {
        return new Point(this.int_0, this.int_1);
    }

    public Size method_3()
    {
        return new Size(this.method_0(), this.method_1());
    }

    string ValueType.ToString()
    {
        return string.Format(BookmarkStart.b("崥ᠧ圩含唭į伱", 0), this.method_2(), this.method_3());
    }

    public static Rectangle smethod_0(Struct15 A_0)
    {
        return Rectangle.FromLTRB(A_0.int_0, A_0.int_1, A_0.int_2, A_0.int_3);
    }

    public static RectangleF smethod_1(Struct15 A_0)
    {
        return RectangleF.FromLTRB((float) A_0.int_0, (float) A_0.int_1, (float) A_0.int_2, (float) A_0.int_3);
    }

    public static Size smethod_2(Struct15 A_0)
    {
        return new Size(A_0.int_2 - A_0.int_0, A_0.int_3 - A_0.int_1);
    }

    public static Struct15 smethod_3(Rectangle A_0)
    {
        return new Struct15 { int_0 = A_0.Left, int_2 = A_0.Right, int_1 = A_0.Top, int_3 = A_0.Bottom };
    }
}

