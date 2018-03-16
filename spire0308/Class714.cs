using System;
using System.Runtime.CompilerServices;

internal class Class714 : IComparable
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    [CompilerGenerated]
    private bool bool_7;
    [CompilerGenerated]
    private bool bool_8;
    private float float_0;
    private float float_1;
    private float float_2;
    private float float_3;
    private float float_4;
    private float float_5;
    private float float_6;
    private int int_0 = -1;
    private int int_1 = -2147483648;
    private int int_2 = -2147483648;

    public float method_0()
    {
        return this.float_3;
    }

    public void method_1(float A_0)
    {
        this.float_3 = A_0;
    }

    public float method_10()
    {
        return this.float_1;
    }

    public void method_11(float A_0)
    {
        this.float_1 = A_0;
    }

    public float method_12()
    {
        return this.float_2;
    }

    public void method_13(float A_0)
    {
        this.float_2 = A_0;
    }

    public bool method_14()
    {
        return this.bool_0;
    }

    public void method_15(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public int method_16()
    {
        return this.int_0;
    }

    public void method_17(int A_0)
    {
        this.int_0 = A_0;
    }

    [CompilerGenerated]
    public bool method_18()
    {
        return this.bool_7;
    }

    [CompilerGenerated]
    public void method_19(bool A_0)
    {
        this.bool_7 = A_0;
    }

    public float method_2()
    {
        return this.float_4;
    }

    [CompilerGenerated]
    public bool method_20()
    {
        return this.bool_8;
    }

    [CompilerGenerated]
    public void method_21(bool A_0)
    {
        this.bool_8 = A_0;
    }

    public bool method_22()
    {
        if (((this.bool_4 || (this.method_8() > 0f)) || (this.method_10() <= 0f)) && ((this.method_8() <= 0f) || ((this.method_10() - this.method_8()) <= 1f)))
        {
            return this.bool_4;
        }
        return true;
    }

    public void method_23(bool A_0)
    {
        this.bool_4 = A_0;
    }

    public bool method_24()
    {
        return this.bool_5;
    }

    public void method_25(bool A_0)
    {
        this.bool_5 = A_0;
    }

    public bool method_26()
    {
        return this.bool_6;
    }

    public void method_27(bool A_0)
    {
        this.bool_6 = A_0;
    }

    public bool method_28()
    {
        return (((this.float_0 == 0f) && (this.float_1 == 0f)) && (this.method_4() == 0f));
    }

    public bool method_29()
    {
        return this.bool_1;
    }

    public void method_3(float A_0)
    {
        this.float_4 = A_0;
    }

    public void method_30(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public bool method_31()
    {
        return this.bool_2;
    }

    public void method_32(bool A_0)
    {
        this.bool_2 = A_0;
    }

    public bool method_33()
    {
        return this.bool_3;
    }

    public void method_34(bool A_0)
    {
        this.bool_3 = A_0;
    }

    internal int method_35()
    {
        if (this.int_1 == -2147483648)
        {
            this.int_1 = (int) Math.Abs((float) (this.method_8() - this.method_10()));
        }
        return this.int_1;
    }

    internal int method_36()
    {
        if (this.int_2 == -2147483648)
        {
            this.int_2 = (int) Math.Abs((float) (this.method_8() - this.method_4()));
        }
        return this.int_2;
    }

    public float method_4()
    {
        return this.float_5;
    }

    public void method_5(float A_0)
    {
        this.float_5 = A_0;
    }

    public float method_6()
    {
        return this.float_6;
    }

    public void method_7(float A_0)
    {
        this.float_6 = A_0;
    }

    public float method_8()
    {
        return this.float_0;
    }

    public void method_9(float A_0)
    {
        this.float_0 = A_0;
    }

    int IComparable.CompareTo(object A_0)
    {
        Class714 class2 = (Class714) A_0;
        return this.method_35().CompareTo(class2.method_35());
    }
}

