using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct36
{
    public float float_0;
    public float float_1;
    public float float_2;
    public float float_3;
    public Struct36(float A_0, float A_1, float A_2, float A_3)
    {
        this.float_0 = A_0;
        this.float_1 = A_1;
        this.float_2 = A_2;
        this.float_3 = A_3;
    }

    public bool method_0()
    {
        return ((((this.float_0 == 0f) && (this.float_1 == 0f)) && (this.float_2 == 0f)) && (this.float_3 == 0f));
    }
}

