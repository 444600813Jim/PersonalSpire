using System;
using System.IO;

internal class Class596 : Interface35
{
    internal Class429 class429_0;
    internal const int int_0 = 12;
    internal short short_0;
    internal short short_1;
    internal uint uint_0;
    internal uint uint_1;

    internal Class596()
    {
    }

    internal Class596(BinaryReader A_0)
    {
        this.short_0 = A_0.ReadInt16();
        this.uint_0 = A_0.ReadUInt32();
        this.short_1 = A_0.ReadInt16();
        this.uint_1 = A_0.ReadUInt32();
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write(this.short_0);
        A_0.Write(this.uint_0);
        A_0.Write(this.short_1);
        A_0.Write(this.uint_1);
    }
}

