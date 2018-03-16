using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct2
{
    private bool bool_0;
    private bool bool_1;
    public bool method_0()
    {
        return this.bool_0;
    }

    public void method_1(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public bool method_2()
    {
        return this.bool_1;
    }

    public void method_3(bool A_0)
    {
        this.bool_1 = A_0;
    }
}

