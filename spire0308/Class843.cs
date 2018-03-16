using System;
using System.Drawing;

internal class Class843
{
    private bool bool_0 = true;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private int int_4;
    private int int_5;

    public int method_0()
    {
        return this.int_0;
    }

    public void method_1(int A_0)
    {
        this.int_0 = A_0;
        this.bool_0 = false;
        if (this.int_3 == 0)
        {
            this.int_3 = 0xff;
        }
    }

    public int method_2()
    {
        return this.int_1;
    }

    public void method_3(int A_0)
    {
        this.int_1 = A_0;
        this.bool_0 = false;
        if (this.int_3 == 0)
        {
            this.int_3 = 0xff;
        }
    }

    public int method_4()
    {
        return this.int_2;
    }

    public void method_5(int A_0)
    {
        this.int_2 = A_0;
        this.bool_0 = false;
        if (this.int_3 == 0)
        {
            this.int_3 = 0xff;
        }
    }

    public int method_6()
    {
        return this.int_3;
    }

    public void method_7(int A_0)
    {
        this.int_3 = A_0;
        this.bool_0 = false;
    }

    public bool method_8()
    {
        return this.bool_0;
    }

    public Color method_9()
    {
        if (this.bool_0)
        {
            return Color.Empty;
        }
        return Color.FromArgb(this.int_3, this.int_0, this.int_1, this.int_2);
    }

    public static Color smethod_0(Class843 A_0)
    {
        if (A_0.method_8())
        {
            return Color.Empty;
        }
        return Color.FromArgb(A_0.method_6(), A_0.method_0(), A_0.method_2(), A_0.method_4());
    }
}

