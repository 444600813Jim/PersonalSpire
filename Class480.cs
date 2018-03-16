using System;
using System.IO;

internal class Class480 : Interface35
{
    internal bool bool_0;
    internal static bool bool_1;
    internal const int int_0 = 0x16;
    internal int int_1;
    internal int int_2;
    internal int int_3;
    internal int int_4;
    internal int int_5;

    internal Class480()
    {
    }

    internal Class480(BinaryReader A_0)
    {
        this.int_1 = A_0.ReadInt32();
        this.int_2 = A_0.ReadInt32();
        this.bool_0 = A_0.ReadInt16() != 0;
        this.int_3 = A_0.ReadInt32();
        this.int_4 = A_0.ReadInt32();
        this.int_5 = A_0.ReadInt32();
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write(this.int_1);
        A_0.Write(this.int_2);
        A_0.Write(this.bool_0 ? ((short) 1) : ((short) 0));
        A_0.Write(this.int_3);
        A_0.Write(this.int_4);
        A_0.Write(this.int_5);
    }
}

