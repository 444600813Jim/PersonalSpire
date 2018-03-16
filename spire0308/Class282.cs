using System;
using System.IO;

internal class Class282 : Class266
{
    private int int_0;

    internal Class282() : base(EscherRecordType.ClientTextbox, 0)
    {
    }

    internal int method_4()
    {
        return this.int_0;
    }

    internal void method_5(int A_0)
    {
        this.int_0 = A_0;
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        A_0.Write(this.int_0);
    }
}

