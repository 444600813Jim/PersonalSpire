using System;
using System.IO;

internal class Class435 : Class434, Interface35
{
    internal const int int_2 = 8;

    internal Class435()
    {
    }

    internal Class435(BinaryReader A_0)
    {
        this.method_1(A_0.ReadInt32());
        base.int_0 = A_0.ReadInt32();
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write(this.method_0());
        A_0.Write(base.int_0);
    }

    internal int method_0()
    {
        return base.int_1;
    }

    internal void method_1(int A_0)
    {
        base.int_1 = A_0;
    }
}

