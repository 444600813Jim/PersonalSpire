using System;
using System.IO;

internal class Class286 : Class266
{
    internal int int_0;
    internal int int_1;
    internal int int_2;
    internal int int_3;
    internal int int_4;
    internal int int_5;

    internal Class286() : base(EscherRecordType.ConnectorRule, 1)
    {
    }

    internal Class286(int A_0, int A_1, Class74 A_2) : this()
    {
        this.int_0 = A_0;
        this.int_3 = A_1;
        if (A_2 != null)
        {
            this.int_1 = A_2.int_0;
            this.int_2 = A_2.int_1;
            this.int_4 = A_2.int_2;
            this.int_5 = A_2.int_3;
        }
        else
        {
            this.int_1 = 0;
            this.int_2 = 0;
            this.int_4 = -1;
            this.int_5 = -1;
        }
    }

    internal Class74 method_4()
    {
        return new Class74(this.int_1, this.int_2, this.int_4, this.int_5);
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
        this.int_2 = A_0.ReadInt32();
        this.int_3 = A_0.ReadInt32();
        this.int_4 = A_0.ReadInt32();
        this.int_5 = A_0.ReadInt32();
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        A_0.Write(this.int_0);
        A_0.Write(this.int_1);
        A_0.Write(this.int_2);
        A_0.Write(this.int_3);
        A_0.Write(this.int_4);
        A_0.Write(this.int_5);
    }
}

