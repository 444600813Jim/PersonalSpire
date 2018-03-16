using System;
using System.IO;

internal class Class662 : Interface35
{
    internal const int int_0 = 4;
    internal int int_1;
    internal int int_2;

    internal Class662()
    {
    }

    internal Class662(BinaryReader A_0)
    {
        this.int_1 = A_0.ReadUInt16();
        this.int_2 = A_0.ReadUInt16();
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write((ushort) this.int_1);
        A_0.Write((ushort) this.int_2);
    }
}

