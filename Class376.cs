using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

[DefaultMember("Item")]
internal class Class376 : List<Class375>
{
    private Class375 class375_0;
    private Class500 class500_0;
    private PointF pointF_0;
    private RectangleF rectangleF_0;

    public Class376() : this(null)
    {
    }

    public Class376(Class375 A_0) : this(A_0, null)
    {
    }

    public Class376(Class375 A_0, Class500 A_1)
    {
        this.rectangleF_0 = new RectangleF();
        this.pointF_0 = new PointF();
        this.class375_0 = A_0;
        this.class500_0 = A_1;
    }

    public Class375 method_0()
    {
        if (base.Count > 0)
        {
            return this.method_4(base.Count - 1);
        }
        return null;
    }

    public Class375 method_1()
    {
        if (base.Count > 0)
        {
            return this.method_4(0);
        }
        return null;
    }

    internal void method_10()
    {
        int num = 0;
        int count = base.Count;
        while (num < count)
        {
            this.method_4(num).method_114();
            num++;
        }
    }

    public bool method_11(Class375 A_0)
    {
        this.method_14(A_0);
        return base.Remove(A_0);
    }

    public void method_12(int A_0)
    {
        if ((A_0 > -1) && (A_0 < base.Count))
        {
            Class375 class2 = this.method_4(A_0);
            this.method_14(class2);
        }
        base.RemoveAt(A_0);
    }

    public void method_13(int A_0, int A_1)
    {
        if ((A_0 > -1) && (A_1 <= base.Count))
        {
            int num = A_0;
            for (int i = 0; i < A_1; i++)
            {
                Class375 class2 = this.method_4(num);
                this.method_14(class2);
                num++;
            }
        }
        base.RemoveRange(A_0, base.Count);
    }

    private void method_14(Class375 A_0)
    {
        if ((A_0 != null) && (A_0.method_73().imethod_0() is Class210))
        {
            (A_0.method_73().imethod_0() as Class210).method_100();
        }
    }

    public RectangleF method_2()
    {
        return this.rectangleF_0;
    }

    public Class375 method_3()
    {
        return this.class375_0;
    }

    public Class375 method_4(int A_0)
    {
        return base[A_0];
    }

    public void method_5(int A_0, Class375 A_1)
    {
        base[A_0] = A_1;
        base[A_0].method_90(this.method_3());
        base[A_0].method_91(this.method_6());
    }

    public Class500 method_6()
    {
        if (this.class500_0 != null)
        {
            return this.class500_0;
        }
        if (this.class375_0 != null)
        {
            return this.class375_0.method_72();
        }
        return null;
    }

    public void method_7(Class375 A_0)
    {
        base.Add(A_0);
        A_0.method_90(this.method_3());
        A_0.method_91(this.method_6());
        if ((((this.method_3() != null) && (A_0 != null)) && ((this.method_3().method_73() is Paragraph) || ((this.method_3().method_73() is Class65) && ((this.method_3().method_73() as Class65).method_2() is Paragraph)))) && ((A_0.method_73() is Paragraph) || ((A_0.method_73() is Class65) && ((A_0.method_73() as Class65).method_2() is Paragraph))))
        {
            this.method_3().method_19(Math.Max(this.method_3().method_18(), A_0.method_69().Height));
        }
        if ((((this.method_3() != null) && (A_0 != null)) && A_0.method_0()) && ((this.method_3().method_73() is Paragraph) || ((this.method_3().method_73() is Class65) && ((this.method_3().method_73() as Class65).method_2() is Paragraph))))
        {
            this.method_3().method_1(A_0.method_0());
        }
    }

    public void method_8(Class375 A_0)
    {
        if (!base.Contains(A_0))
        {
            if (base.Count == 0)
            {
                this.pointF_0 = A_0.method_69().Location;
                this.rectangleF_0 = A_0.method_69();
            }
            else
            {
                this.rectangleF_0 = new RectangleF(this.pointF_0, new SizeF(Math.Max(this.rectangleF_0.Width, A_0.method_69().Width), A_0.method_69().Bottom - this.pointF_0.Y));
            }
            this.method_7(A_0);
        }
    }

    public void method_9(double A_0, double A_1, bool A_2, bool A_3)
    {
        this.rectangleF_0 = new RectangleF(new PointF(this.rectangleF_0.X + ((float) A_0), this.rectangleF_0.Y + ((float) A_1)), this.rectangleF_0.Size);
        int num = 0;
        int count = base.Count;
        while (num < count)
        {
            this.method_4(num).method_95(A_0, A_1, A_2, A_3);
            num++;
        }
    }
}

