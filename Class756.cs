using System;
using System.IO;

internal class Class756 : Interface35
{
    internal const int int_0 = 12;
    private int int_1;

    internal Class756() : this(0)
    {
    }

    internal Class756(int A_0)
    {
        this.int_1 = A_0;
    }

    internal Class756(BinaryReader A_0)
    {
        A_0.ReadUInt16();
        A_0.ReadUInt16();
        A_0.ReadUInt16();
        this.int_1 = A_0.ReadInt16();
        A_0.ReadInt32();
    }

    public void imethod_0(BinaryWriter A_0)
    {
        A_0.Write((ushort) 0);
        A_0.Write((ushort) 0x24);
        A_0.Write((ushort) 2);
        A_0.Write((ushort) this.int_1);
        A_0.Write(0);
    }

    internal int method_0()
    {
        return this.int_1;
    }

    internal void method_1(int A_0)
    {
        this.int_1 = A_0;
    }
}

