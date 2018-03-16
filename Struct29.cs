using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct29
{
    private Struct30 struct30_0;
    private Struct30 struct30_1;
    private bool bool_0;
    public Struct30 method_0()
    {
        return this.struct30_0;
    }

    public void method_1(Struct30 A_0)
    {
        this.struct30_0 = A_0;
        this.bool_0 = true;
    }

    public Struct30 method_2()
    {
        return this.struct30_1;
    }

    public void method_3(Struct30 A_0)
    {
        this.struct30_1 = A_0;
        this.bool_0 = true;
    }

    public bool method_4()
    {
        return this.bool_0;
    }
}

