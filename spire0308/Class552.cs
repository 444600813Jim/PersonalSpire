using Spire.Doc.Fields.Shape.Ps;
using System;
using System.Drawing;

internal class Class552
{
    private readonly BorderGridType borderGridType_0;
    private readonly Class676 class676_0;
    private Class952 class952_0;
    private Class952 class952_1;
    private Class952 class952_2;
    private Class952 class952_3;
    private Class952 class952_4;
    private const float float_0 = 0.005f;

    internal Class552(BorderGridType A_0)
    {
        this.borderGridType_0 = A_0;
        this.class676_0 = new Class676();
    }

    internal void method_0()
    {
        if (this.class952_1 != null)
        {
            this.class952_1 = this.class952_4;
            this.class952_2 = this.class952_1.method_15();
            this.class952_3 = null;
        }
    }

    internal void method_1(RectangleF A_0, Class1031 A_1, Class1031 A_2, Class1031 A_3, Class1031 A_4)
    {
        RectangleF ef = smethod_0(A_0, A_1, A_2, A_3, A_4);
        PointF tf = new PointF(ef.X, ef.Y);
        this.method_2(tf);
        this.method_3(tf);
        this.method_4(ef.Right, A_3);
        this.method_5(ef.X, A_3);
        this.method_6(ef.Right, A_3);
        this.method_7(ef.Height, A_1);
        Class952 class2 = this.method_8(A_4, A_2);
        this.class952_1 = this.class952_2;
        this.class952_2 = this.class952_1.method_15();
        this.class952_3 = class2;
    }

    internal void method_10(Class319 A_0)
    {
        if (this.method_19())
        {
            this.method_13();
            this.method_16(A_0);
            this.method_17(A_0);
            this.method_15();
        }
    }

    internal spr➓ method_11()
    {
        spr➓ r➓ = null;
        if (this.method_19())
        {
            r➓ = new spr➓();
            Class319 class2 = new Class319(r➓);
            this.method_13();
            this.method_16(class2);
            this.method_17(class2);
            this.method_15();
        }
        return r➓;
    }

    internal void method_12(float A_0, float A_1)
    {
        for (Class952 class2 = this.class952_0; class2 != null; class2 = smethod_1(class2))
        {
            for (Class952 class3 = class2; class3 != null; class3 = class3.method_15())
            {
                class3.method_30(A_0, A_1);
            }
        }
    }

    private void method_13()
    {
        this.method_14();
        for (Class952 class2 = this.class952_0; class2 != null; class2 = smethod_1(class2))
        {
            for (Class952 class3 = class2; class3 != null; class3 = class3.method_15())
            {
                class3.method_0();
            }
        }
    }

    private void method_14()
    {
        if (this.borderGridType_0 == BorderGridType.Paragraph)
        {
            float num = 2.147484E+09f;
            float num2 = -2.147484E+09f;
            for (Class952 class2 = this.class952_0; class2 != null; class2 = class2.method_19())
            {
                num = Math.Min(num, class2.method_1().X);
                num2 = Math.Max(num2, class2.method_15().method_1().X - num);
            }
            for (Class952 class3 = this.class952_0; class3 != null; class3 = class3.method_19())
            {
                class3.method_2(new PointF(num, class3.method_1().Y));
                class3.method_15().method_2(new PointF(num + num2, class3.method_1().Y));
            }
        }
    }

    private void method_15()
    {
        this.class952_0 = null;
        this.class952_1 = null;
        this.class952_2 = null;
        this.class952_3 = null;
        this.class952_4 = null;
    }

    private void method_16(Class319 A_0)
    {
        for (Class952 class2 = this.class952_0; class2 != null; class2 = smethod_1(class2))
        {
            for (Class952 class3 = class2; class3 != null; class3 = class3.method_15())
            {
                if (class3.method_5())
                {
                    Class952 class4 = class3;
                    for (Class952 class5 = class3.method_19(); class5 != null; class5 = class5.method_19())
                    {
                        if (!class4.method_12().method_7())
                        {
                            class4 = class5;
                        }
                        else if (!class5.method_23())
                        {
                            this.class676_0.method_0(class4, class5, this.borderGridType_0 == BorderGridType.Table, true, A_0);
                            class4 = class5;
                        }
                    }
                }
            }
        }
    }

    private void method_17(Class319 A_0)
    {
        for (Class952 class2 = this.class952_0; class2 != null; class2 = smethod_1(class2))
        {
            Class952 class4 = class2;
            for (Class952 class3 = class4.method_15(); class3 != null; class3 = class3.method_15())
            {
                if (!class4.method_9().method_7())
                {
                    class4 = class3;
                }
                else if (!class3.method_22())
                {
                    this.class676_0.method_0(class4, class3, this.borderGridType_0 == BorderGridType.Table, false, A_0);
                    class4 = class3;
                }
            }
        }
    }

    internal Class952 method_18()
    {
        return this.class952_0;
    }

    internal bool method_19()
    {
        return (this.class952_0 != null);
    }

    private void method_2(PointF A_0)
    {
        if (this.class952_1 == null)
        {
            this.class952_1 = new Class952();
            this.class952_1.method_2(A_0);
            this.class952_0 = this.class952_1;
        }
    }

    private void method_3(PointF A_0)
    {
        float num = A_0.Y - this.class952_1.method_1().Y;
        if (num > 0.005f)
        {
            this.class952_4 = new Class952();
            this.class952_4.method_2(A_0);
            this.class952_1.method_20(this.class952_4);
            this.class952_4.method_18(this.class952_1);
            this.class952_4.method_11(Class1031.class1031_0);
            this.method_0();
        }
    }

    private void method_4(float A_0, Class1031 A_1)
    {
        if (this.class952_2 == null)
        {
            this.class952_2 = new Class952();
            this.class952_2.method_2(new PointF(A_0, this.class952_1.method_1().Y));
            this.class952_2.method_8(A_1);
            this.class952_1.method_16(this.class952_2);
            this.class952_2.method_14(this.class952_1);
        }
    }

    private void method_5(float A_0, Class1031 A_1)
    {
        Class952 class3;
        Class952 class2 = this.class952_1;
        while ((A_0 - class2.method_1().X) > 0.005f)
        {
            if (class2.method_4())
            {
                break;
            }
            class2 = class2.method_15();
        }
        if (Math.Abs((float) (A_0 - class2.method_1().X)) < 0.005f)
        {
            class3 = class2;
            class2 = class2.method_15();
        }
        else if (A_0 > class2.method_1().X)
        {
            class3 = class2.method_31(A_0);
            class3.method_8(Class1031.class1031_0);
            class2 = null;
        }
        else if (class2.method_3())
        {
            class3 = class2.method_32(A_0);
            class2.method_8(Class1031.class1031_0);
        }
        else
        {
            class3 = class2.method_32(A_0);
            class3.method_8(class2.method_7());
        }
        this.class952_1 = class3;
        this.class952_2 = class2;
    }

    private void method_6(float A_0, Class1031 A_1)
    {
        Class952 class4;
        Class952 class2 = this.class952_2;
        Class952 class3 = this.class952_1;
        while (class2 != null)
        {
            if ((A_0 - class2.method_1().X) <= 0.005f)
            {
                break;
            }
            class2.method_8(Class1031.smethod_7(class2.method_7(), A_1));
            class3 = class2;
            class2 = class2.method_15();
        }
        if (class2 == null)
        {
            class4 = class3.method_31(A_0);
            class4.method_8(A_1);
        }
        else if (Math.Abs((float) (A_0 - class2.method_1().X)) < 0.005f)
        {
            class4 = class2;
            class2.method_8(Class1031.smethod_7(class2.method_7(), A_1));
        }
        else
        {
            class4 = class3.method_31(A_0);
            class4.method_8(Class1031.smethod_7(class2.method_7(), A_1));
        }
        this.class952_2 = class4;
    }

    private void method_7(float A_0, Class1031 A_1)
    {
        if (this.class952_3 == null)
        {
            this.class952_3 = new Class952();
            this.class952_3.method_2(new PointF(this.class952_1.method_1().X, this.class952_1.method_1().Y + A_0));
            this.class952_3.method_11(A_1);
            this.class952_1.method_20(this.class952_3);
            this.class952_3.method_18(this.class952_1);
            this.class952_4 = this.class952_3;
        }
        else
        {
            this.class952_3.method_11(Class1031.smethod_7(this.class952_3.method_10(), A_1));
        }
    }

    private Class952 method_8(Class1031 A_0, Class1031 A_1)
    {
        Class952 class2 = new Class952();
        class2.method_2(new PointF(this.class952_2.method_1().X, this.class952_3.method_1().Y));
        class2.method_8(A_0);
        class2.method_11(A_1);
        this.class952_2.method_20(class2);
        class2.method_18(this.class952_2);
        this.class952_3.method_16(class2);
        class2.method_14(this.class952_3);
        return class2;
    }

    internal void method_9(spr➓ A_0)
    {
        if (this.method_19())
        {
            Class319 class2 = new Class319(A_0);
            this.method_13();
            this.method_16(class2);
            this.method_17(class2);
            this.method_15();
        }
    }

    private static RectangleF smethod_0(RectangleF A_0, Class1031 A_1, Class1031 A_2, Class1031 A_3, Class1031 A_4)
    {
        float x = A_0.X;
        float y = A_0.Y;
        float width = A_0.Width;
        float height = A_0.Height;
        if (A_1.method_16())
        {
            x += A_1.method_8();
            width -= A_1.method_8();
        }
        if (A_2.method_16())
        {
            width -= A_2.method_8();
        }
        if (A_3.method_16())
        {
            y += A_3.method_8();
            height -= A_3.method_8();
        }
        if (A_4.method_16())
        {
            height -= A_4.method_8();
        }
        return new RectangleF(x, y, width, height);
    }

    private static Class952 smethod_1(Class952 A_0)
    {
        Class952 class3;
        Class952 class2 = A_0;
        do
        {
            class3 = class2.method_19();
            class2 = class2.method_15();
        }
        while ((class3 == null) && (class2 != null));
        if (class3 != null)
        {
            return class3.method_33();
        }
        return null;
    }
}

