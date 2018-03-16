using System;
using System.IO;

internal class Class811 : Interface35
{
    internal static bool bool_0;
    internal const int int_0 = 6;
    internal int int_1;
    internal int int_2;
    internal int int_3;

    internal Class811()
    {
    }

    internal Class811(BinaryReader A_0)
    {
        this.method_0(A_0);
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write((short) this.int_1);
        A_0.Write((short) this.int_2);
        A_0.Write((short) this.int_3);
    }

    internal void method_0(BinaryReader A_0)
    {
        this.int_1 = A_0.ReadInt16();
        this.int_2 = A_0.ReadInt16();
        this.int_3 = A_0.ReadInt16();
    }
}

