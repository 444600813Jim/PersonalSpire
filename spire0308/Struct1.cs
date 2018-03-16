using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct1
{
    private double double_0;
    private double double_1;
    private double double_2;
    private double double_3;
    private double double_4;
    private double double_5;
    private bool bool_0;
    private double double_6;
    private double double_7;
    public double method_0()
    {
        return this.double_0;
    }

    public void method_1(double A_0)
    {
        this.double_0 = A_0;
    }

    internal double method_2()
    {
        if (Class59.smethod_5(this.method_7(), this.method_11(), 0.005) != 0)
        {
            return (this.method_0() + this.method_26());
        }
        return this.method_0();
    }

    internal double method_3()
    {
        if (this.method_7() <= 0.0)
        {
            return 1.0;
        }
        if (this.method_9() > 0.0)
        {
            return (this.method_9() / this.method_8());
        }
        return (this.method_0() / this.method_8());
    }

    public double method_4()
    {
        return this.double_1;
    }

    public void method_5(double A_0)
    {
        this.double_1 = A_0;
    }

    internal double method_6()
    {
        if (Class59.smethod_5(this.method_7(), this.method_11(), 0.005) != 0)
        {
            return (this.method_4() + this.method_26());
        }
        return this.method_4();
    }

    public double method_7()
    {
        return (this.double_0 + this.double_1);
    }

    public double method_8()
    {
        if (this.method_9() <= 0.0)
        {
            return this.method_7();
        }
        return (this.method_9() + this.double_1);
    }

    public double method_9()
    {
        return this.double_7;
    }

    public void method_10(double A_0)
    {
        this.double_7 = A_0;
    }

    public double method_11()
    {
        return this.double_2;
    }

    public void method_12(double A_0)
    {
        this.double_2 = A_0;
    }

    public double method_13()
    {
        if (this.method_9() <= 0.0)
        {
            return this.method_11();
        }
        return ((this.method_11() - this.method_0()) + this.method_9());
    }

    public double method_14()
    {
        double num = this.method_11() - this.method_7();
        if (num > 0.0)
        {
            return num;
        }
        return 0.0;
    }

    public double method_15()
    {
        return this.double_3;
    }

    public void method_16(double A_0)
    {
        this.double_3 = A_0;
    }

    public double method_17()
    {
        return this.double_4;
    }

    public void method_18(double A_0)
    {
        this.double_4 = A_0;
    }

    public double method_19()
    {
        return this.double_5;
    }

    public void method_20(double A_0)
    {
        this.double_5 = A_0;
    }

    public double method_21()
    {
        return this.method_27();
    }

    public bool method_22()
    {
        return this.bool_0;
    }

    public void method_23(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public double method_24()
    {
        return this.double_6;
    }

    public void method_25(double A_0)
    {
        this.double_6 = A_0;
    }

    public double method_26()
    {
        return (this.method_24() / 2.0);
    }

    private double method_27()
    {
        double num = Math.Max(this.double_4, this.double_0);
        double num2 = Math.Max(this.double_5, this.double_1);
        return (num + num2);
    }

    bool ValueType.Equals(object A_0)
    {
        Struct1 struct2 = (Struct1) A_0;
        return ((((struct2.method_0() == this.method_0()) && (struct2.method_4() == this.method_4())) && (struct2.method_11() == this.method_11())) && (struct2.method_24() == this.method_24()));
    }
}

