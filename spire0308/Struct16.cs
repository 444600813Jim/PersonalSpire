using System;
using System.Drawing;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct16
{
    public int int_0;
    public int int_1;
    public static SizeF smethod_0(Struct16 A_0)
    {
        return new SizeF((float) A_0.int_0, (float) A_0.int_1);
    }
}

