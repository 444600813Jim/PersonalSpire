using System;
using System.IO;

internal class Class688
{
    public const int int_0 = 14;
    internal uint uint_0;
    internal uint uint_1;
    internal ushort ushort_0;
    internal ushort ushort_1;
    internal ushort ushort_2 = 0x4d42;

    internal Class688()
    {
    }

    internal void method_0(BinaryReader A_0)
    {
        this.ushort_2 = A_0.ReadUInt16();
        this.uint_1 = A_0.ReadUInt32();
        this.ushort_0 = A_0.ReadUInt16();
        this.ushort_1 = A_0.ReadUInt16();
        this.uint_0 = A_0.ReadUInt32();
    }

    internal void method_1(BinaryWriter A_0)
    {
        A_0.Write((short) this.ushort_2);
        A_0.Write((int) this.uint_1);
        A_0.Write((short) this.ushort_0);
        A_0.Write((short) this.ushort_1);
        A_0.Write((int) this.uint_0);
    }
}

