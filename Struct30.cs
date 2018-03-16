using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct30
{
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private bool bool_0;
    public Struct30(int A_0, int A_1)
    {
        this.int_0 = A_0;
        this.int_1 = A_1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.bool_0 = true;
    }

    public int method_0()
    {
        return this.int_0;
    }

    public void method_1(int A_0)
    {
        this.int_0 = A_0;
        this.bool_0 = true;
    }

    public int method_2()
    {
        return this.int_2;
    }

    public void method_3(int A_0)
    {
        this.int_2 = A_0;
        this.bool_0 = true;
    }

    public int method_4()
    {
        return this.int_3;
    }

    public void method_5(int A_0)
    {
        this.int_3 = A_0;
        this.bool_0 = true;
    }

    public int method_6()
    {
        return this.int_1;
    }

    public void method_7(int A_0)
    {
        this.int_1 = A_0;
        this.bool_0 = true;
    }

    public bool method_8()
    {
        return this.bool_0;
    }
}

