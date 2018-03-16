using System;
using System.Collections;
using System.Drawing;

internal class Class887
{
    private readonly ArrayList[] arrayList_0;
    private readonly ArrayList[] arrayList_1;
    private readonly ArrayList[] arrayList_2;
    private readonly ArrayList[] arrayList_3;
    private bool bool_0;
    private readonly Class722 class722_0;
    private readonly Class722 class722_1;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private PointF pointF_0;
    private PointF pointF_1;
    private PointF pointF_2;

    internal Class887(Class722 A_0, Class722 A_1)
    {
        this.class722_0 = A_0;
        this.class722_1 = A_1;
        this.arrayList_0 = new ArrayList[A_0.method_19()];
        this.arrayList_1 = new ArrayList[A_1.method_19()];
        this.arrayList_2 = new ArrayList[A_0.method_19()];
        this.arrayList_3 = new ArrayList[A_1.method_19()];
    }

    internal Class722 method_0()
    {
        return this.class722_0;
    }

    internal Class722 method_1()
    {
        return this.class722_1;
    }

    internal int method_10()
    {
        return this.int_0;
    }

    internal void method_11(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_12()
    {
        return this.int_1;
    }

    internal void method_13(int A_0)
    {
        this.int_1 = A_0;
    }

    internal int method_14()
    {
        return this.int_2;
    }

    internal void method_15(int A_0)
    {
        this.int_2 = A_0;
    }

    internal int method_16()
    {
        return this.int_3;
    }

    internal void method_17(int A_0)
    {
        this.int_3 = A_0;
    }

    internal ArrayList method_18(int A_0)
    {
        if (this.arrayList_0[A_0] == null)
        {
            this.arrayList_0[A_0] = new ArrayList();
        }
        return this.arrayList_0[A_0];
    }

    internal ArrayList method_19(int A_0)
    {
        if (this.arrayList_1[A_0] == null)
        {
            this.arrayList_1[A_0] = new ArrayList();
        }
        return this.arrayList_1[A_0];
    }

    internal PointF method_2()
    {
        return this.pointF_0;
    }

    internal ArrayList method_20(int A_0)
    {
        if (this.arrayList_2[A_0] == null)
        {
            this.arrayList_2[A_0] = new ArrayList();
        }
        return this.arrayList_2[A_0];
    }

    internal ArrayList method_21(int A_0)
    {
        if (this.arrayList_3[A_0] == null)
        {
            this.arrayList_3[A_0] = new ArrayList();
        }
        return this.arrayList_3[A_0];
    }

    internal void method_3(PointF A_0)
    {
        this.pointF_0 = A_0;
    }

    internal PointF method_4()
    {
        return this.pointF_1;
    }

    internal void method_5(PointF A_0)
    {
        this.pointF_1 = A_0;
    }

    internal PointF method_6()
    {
        return this.pointF_2;
    }

    internal void method_7(PointF A_0)
    {
        this.pointF_2 = A_0;
    }

    internal bool method_8()
    {
        return this.bool_0;
    }

    internal void method_9(bool A_0)
    {
        this.bool_0 = A_0;
    }
}

