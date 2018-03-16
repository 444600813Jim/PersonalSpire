using System;
using System.IO;

internal class Class384 : Class380
{
    private byte[] byte_0;

    internal Class384(int A_0, int A_1) : base(A_0, A_1)
    {
    }

    internal override void vmethod_2(BinaryReader A_0)
    {
        this.byte_0 = A_0.ReadBytes(base.method_1());
    }

    internal override void vmethod_3(BinaryWriter A_0)
    {
        A_0.Write(this.byte_0);
    }
}

