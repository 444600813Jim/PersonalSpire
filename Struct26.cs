using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct26
{
    private float? nullable_0;
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    public bool method_0()
    {
        return this.nullable_0.HasValue;
    }

    public float? method_1()
    {
        return this.nullable_0;
    }

    public void method_2(float? A_0)
    {
        this.nullable_0 = A_0;
    }

    public bool method_3()
    {
        return this.bool_0;
    }

    public void method_4(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public bool method_5()
    {
        return this.bool_1;
    }

    public void method_6(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public bool method_7()
    {
        return this.bool_3;
    }

    public void method_8(bool A_0)
    {
        this.bool_3 = A_0;
    }

    public bool method_9()
    {
        return this.bool_2;
    }

    public void method_10(bool A_0)
    {
        this.bool_2 = A_0;
    }
}

