using System;
using System.IO;

internal class Class699 : Interface35
{
    internal const int int_0 = 4;
    internal int int_1;

    internal Class699(int A_0)
    {
        this.int_1 = A_0;
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write(this.int_1);
    }
}

