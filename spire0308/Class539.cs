using System;
using System.IO;

internal class Class539
{
    internal const int int_0 = 8;
    internal int int_1;
    internal int int_2;
    internal int int_3;
    internal string string_0;

    internal Class539()
    {
    }

    internal Class539(string A_0, BinaryReader A_1)
    {
        this.string_0 = A_0;
        this.int_1 = A_1.ReadInt16();
        this.int_2 = A_1.ReadByte();
        this.int_3 = A_1.ReadByte();
        A_1.ReadInt32();
    }

    internal void method_0(BinaryWriter A_0)
    {
        A_0.Write((short) this.int_1);
        A_0.Write((byte) this.int_2);
        A_0.Write((byte) this.int_3);
        A_0.Write(0);
    }
}

