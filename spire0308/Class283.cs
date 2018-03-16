using System;
using System.IO;

internal class Class283 : Class266
{
    private int[] int_0;

    internal Class283() : base(EscherRecordType.SplitMenuColors, 0)
    {
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        int num = base.method_3().method_6();
        this.int_0 = new int[num];
        for (int i = 0; i < num; i++)
        {
            this.int_0[i] = A_0.ReadInt32();
        }
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        base.method_3().method_7(this.int_0.Length);
        for (int i = 0; i < this.int_0.Length; i++)
        {
            A_0.Write(this.int_0[i]);
        }
    }
}

