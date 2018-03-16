using System;
using System.IO;

internal class Class290 : Class266
{
    private byte[] byte_1;

    internal byte[] method_4()
    {
        return this.byte_1;
    }

    internal void method_5(byte[] A_0)
    {
        this.byte_1 = A_0;
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        this.byte_1 = A_0.ReadBytes(base.method_3().method_10());
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        A_0.Write(this.byte_1);
    }
}

