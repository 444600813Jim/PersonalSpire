using System;
using System.IO;

internal class Class429 : Class428
{
    internal Class429()
    {
    }

    internal Class429(byte[] A_0) : base(A_0)
    {
    }

    internal Class429(BinaryReader A_0)
    {
        int count = A_0.ReadInt16();
        base.method_3(A_0.ReadBytes(count));
    }

    internal void method_4(BinaryWriter A_0)
    {
        A_0.Write((short) base.method_2().Length);
        A_0.Write(base.method_2());
    }
}

