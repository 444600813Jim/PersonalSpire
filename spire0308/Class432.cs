using System;
using System.IO;

internal class Class432 : Class431
{
    internal Class432(byte[] A_0) : base(A_0)
    {
    }

    internal Class432(BinaryReader A_0)
    {
        int count = A_0.ReadInt16();
        base.method_3(A_0.ReadBytes(count));
    }

    internal void method_4(BinaryWriter A_0)
    {
        base.imethod_2(A_0, false);
    }
}

