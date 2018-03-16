using System;
using System.Drawing;

internal class Class1044
{
    private readonly bool bool_0;
    private readonly double double_0;
    private readonly double double_1;
    private readonly int int_0;
    private readonly int int_1;
    private readonly int int_2;
    private readonly int int_3;

    private Class1044(int A_0, int A_1, int A_2, int A_3, double A_4, double A_5)
    {
        this.int_1 = A_0;
        this.int_2 = A_1;
        this.int_3 = A_2;
        this.int_0 = A_3;
        this.double_0 = A_4;
        this.double_1 = A_5;
        if ((A_4 == 0.0) || (A_5 == 0.0))
        {
            this.bool_0 = true;
            this.double_0 = 96.0;
            this.double_1 = 96.0;
        }
    }

    public int method_0()
    {
        return this.int_1;
    }

    public int method_1()
    {
        return this.int_2;
    }

    public double method_10()
    {
        return Class969.smethod_10((double) this.int_0, this.double_1);
    }

    public int method_11()
    {
        return Class969.smethod_40(this.method_9());
    }

    public int method_12()
    {
        return Class969.smethod_40(this.method_10());
    }

    public int method_13()
    {
        return Class969.smethod_11((double) this.method_4(), this.method_6());
    }

    public int method_14()
    {
        return Class969.smethod_11((double) this.method_5(), this.method_7());
    }

    public Size method_15()
    {
        return new Size(this.int_3, this.int_0);
    }

    public SizeF method_16()
    {
        return new SizeF((float) this.int_3, (float) this.int_0);
    }

    public int method_2()
    {
        return (this.method_0() + this.method_4());
    }

    public int method_3()
    {
        return (this.method_1() + this.method_5());
    }

    public int method_4()
    {
        return this.int_3;
    }

    public int method_5()
    {
        return this.int_0;
    }

    public double method_6()
    {
        return this.double_0;
    }

    public double method_7()
    {
        return this.double_1;
    }

    public bool method_8()
    {
        return this.bool_0;
    }

    public double method_9()
    {
        return Class969.smethod_10((double) this.int_3, this.double_0);
    }

    public static Class1044 smethod_0()
    {
        return new Class1044(0, 0, 0, 0, 0.0, 0.0);
    }

    public static Class1044 smethod_1(int A_0, int A_1, double A_2, double A_3)
    {
        return new Class1044(0, 0, A_0, A_1, A_2, A_3);
    }

    public static Class1044 smethod_2(int A_0, int A_1, int A_2, int A_3, double A_4, double A_5)
    {
        int num = A_2 - A_0;
        return new Class1044(A_0, A_1, num, A_3 - A_1, A_4, A_5);
    }

    public static Class1044 smethod_3(int A_0, int A_1, int A_2, int A_3, int A_4, int A_5)
    {
        int num = A_2 - A_0;
        int num2 = A_3 - A_1;
        double num3 = (A_4 != 0) ? (((double) num) / Class969.smethod_49(A_4)) : 0.0;
        return new Class1044(A_0, A_1, num, num2, num3, (A_5 != 0) ? (((double) num2) / Class969.smethod_49(A_5)) : 0.0);
    }
}

