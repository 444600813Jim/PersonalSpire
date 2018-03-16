using System;
using System.IO;

internal class Class739
{
    internal int int_0;
    internal int int_1;

    internal Class739(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
    }

    internal Class739(int A_0, int A_1)
    {
        this.int_0 = A_0;
        this.int_1 = A_1;
    }

    internal void method_0(BinaryWriter A_0)
    {
        A_0.Write(this.int_0);
        A_0.Write(this.int_1);
    }
}

