using System;
using System.IO;

internal class Class1110 : Interface35
{
    internal const int int_0 = 6;
    internal int int_1;
    internal int int_2;
    internal int int_3;

    internal Class1110()
    {
    }

    internal Class1110(BinaryReader A_0)
    {
        this.int_1 = A_0.ReadUInt16();
        this.int_2 = A_0.ReadUInt16();
        this.int_3 = A_0.ReadInt16();
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write((ushort) this.int_1);
        A_0.Write((ushort) this.int_2);
        A_0.Write((short) this.int_3);
    }
}

