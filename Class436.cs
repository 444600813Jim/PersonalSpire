using System;
using System.IO;

internal class Class436 : Class434, Interface35
{
    internal const int int_2 = 10;
    internal int int_3;

    internal Class436()
    {
    }

    internal Class436(BinaryReader A_0)
    {
        this.method_1(A_0.ReadInt32());
        this.int_3 = A_0.ReadUInt16();
        base.int_0 = A_0.ReadInt32();
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write(this.method_0());
        A_0.Write((ushort) this.int_3);
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

