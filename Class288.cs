using System;
using System.IO;

internal class Class288 : Class266
{
    internal int int_0;
    internal int int_1;

    internal Class288() : base(EscherRecordType.ArcRule, 0)
    {
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        A_0.Write(this.int_0);
        A_0.Write(this.int_1);
    }
}

