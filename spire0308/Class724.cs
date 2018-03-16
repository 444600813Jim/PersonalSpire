using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;

internal class Class724 : Interface64
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private byte[] byte_0;
    private Class722 class722_0;
    private float float_0;
    private RectangleF rectangleF_0;
    private ShapeBase shapeBase_0;
    private SizeF sizeF_0;

    internal Class724(ShapeBase A_0)
    {
        int num = 0x13;
        this.sizeF_0 = SizeF.Empty;
        this.rectangleF_0 = RectangleF.Empty;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨸区尼伾⑀", num));
        }
        this.shapeBase_0 = A_0;
        this.float_0 = (float) A_0.Width;
    }

    internal Class724(ShapeBase A_0, SizeF A_1) : this(A_0)
    {
        this.sizeF_0 = A_1;
    }

    internal Class724(SizeF A_0, float A_1)
    {
        this.sizeF_0 = SizeF.Empty;
        this.rectangleF_0 = RectangleF.Empty;
        this.sizeF_0 = A_0;
        if (A_1 > 0f)
        {
            this.float_0 = A_1;
        }
    }

    internal Class724(ShapeBase A_0, SizeF A_1, float A_2) : this(A_0, A_1)
    {
        if (A_2 > 0f)
        {
            this.float_0 = A_2;
        }
    }

    internal Class724(ShapeBase A_0, SizeF A_1, float A_2, byte[] A_3, bool A_4, bool A_5, bool A_6, bool A_7) : this(A_0, A_1, A_2)
    {
        this.byte_0 = A_3;
        this.bool_2 = A_4;
        this.bool_0 = A_5;
        this.bool_3 = A_6;
        this.bool_1 = A_7;
    }

    RectangleF Interface64.imethod_0()
    {
        return this.rectangleF_0;
    }

    internal Class724 method_0()
    {
        return (Class724) base.MemberwiseClone();
    }

    internal float method_1()
    {
        return this.float_0;
    }

    internal bool method_10()
    {
        return this.bool_0;
    }

    internal byte[] method_11()
    {
        return this.byte_0;
    }

    internal Class722 method_12()
    {
        return this.class722_0;
    }

    internal void method_13(Class722 A_0)
    {
        this.class722_0 = A_0;
    }

    internal bool method_14()
    {
        return false;
    }

    internal bool method_15()
    {
        return false;
    }

    public void method_2(RectangleF A_0)
    {
        this.rectangleF_0 = A_0;
    }

    internal ShapeBase method_3()
    {
        return this.shapeBase_0;
    }

    internal SizeF method_4()
    {
        return this.sizeF_0;
    }

    internal void method_5(SizeF A_0)
    {
        this.sizeF_0 = A_0;
    }

    internal bool method_6()
    {
        return this.bool_4;
    }

    internal bool method_7()
    {
        return this.bool_3;
    }

    internal bool method_8()
    {
        return this.bool_2;
    }

    internal bool method_9()
    {
        return this.bool_1;
    }
}

