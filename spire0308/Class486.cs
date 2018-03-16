using System;
using System.IO;

internal class Class486 : Interface35
{
    internal const int int_0 = 4;
    internal int int_1;
    internal int int_2;

    internal Class486()
    {
    }

    internal Class486(BinaryReader A_0)
    {
        this.int_1 = A_0.ReadUInt16();
        this.int_2 = A_0.ReadInt16();
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write((ushort) this.int_1);
        A_0.Write((short) this.int_2);
    }
}

