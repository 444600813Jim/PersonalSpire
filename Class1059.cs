using System;
using System.IO;

internal class Class1059 : Interface35
{
    internal bool bool_0;
    internal const int int_0 = 2;

    internal Class1059()
    {
    }

    internal Class1059(BinaryReader A_0)
    {
        this.bool_0 = A_0.ReadInt16() != 0;
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write(this.bool_0 ? ((short) 1) : ((short) 0));
    }
}

