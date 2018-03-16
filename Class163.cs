using System;
using System.IO;

internal class Class163 : Class147
{
    private const int int_2 = 4;

    internal Class163() : base(4)
    {
    }

    internal int method_25(int A_0)
    {
        return (((int) base.method_18(A_0)) * 0x200);
    }

    protected override object vmethod_0(BinaryReader A_0)
    {
        return A_0.ReadInt32();
    }
}

