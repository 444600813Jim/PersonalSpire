using System;
using System.IO;

internal class Class873 : Interface35
{
    internal const int int_0 = 13;
    internal const int int_1 = 12;
    internal int int_2;

    internal Class873(int A_0)
    {
        this.int_2 = A_0;
    }

    internal Class873(BinaryReader A_0)
    {
        this.int_2 = A_0.ReadByte();
        A_0.BaseStream.Seek(12L, SeekOrigin.Current);
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write((byte) this.int_2);
        A_0.BaseStream.Seek(12L, SeekOrigin.Current);
    }
}

