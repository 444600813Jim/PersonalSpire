using System;
using System.IO;

internal class Class1064
{
    internal int int_0;
    internal int int_1;

    internal Class1064()
    {
    }

    internal Class1064(BinaryReader A_0)
    {
        A_0.ReadByte();
        A_0.ReadByte();
        this.int_0 = A_0.ReadUInt16();
        this.int_1 = A_0.ReadUInt16();
        A_0.ReadUInt16();
        A_0.ReadInt32();
        A_0.ReadInt32();
        A_0.ReadInt32();
        A_0.ReadInt32();
    }

    internal void method_0(BinaryWriter A_0)
    {
        A_0.Write((byte) 0x56);
        A_0.Write((byte) 0);
        A_0.Write((ushort) this.int_0);
        A_0.Write((ushort) this.int_1);
        A_0.Write((ushort) 0xffff);
        A_0.Write(0);
        A_0.Write(0);
        A_0.Write(0);
        A_0.Write(0);
    }
}

