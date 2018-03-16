using System;
using System.IO;

internal class Class291 : Class266
{
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;

    internal Class291() : base(EscherRecordType.ChildAnchor, 0)
    {
    }

    internal int method_10()
    {
        return this.int_3;
    }

    internal void method_11(int A_0)
    {
        this.int_3 = A_0;
    }

    internal int method_4()
    {
        return this.int_0;
    }

    internal void method_5(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_6()
    {
        return this.int_1;
    }

    internal void method_7(int A_0)
    {
        this.int_1 = A_0;
    }

    internal int method_8()
    {
        return this.int_2;
    }

    internal void method_9(int A_0)
    {
        this.int_2 = A_0;
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
        int num = A_0.ReadInt32();
        this.method_9(num - this.int_0);
        int num2 = A_0.ReadInt32();
        this.method_11(num2 - this.int_1);
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        A_0.Write(this.int_0);
        A_0.Write(this.int_1);
        A_0.Write((int) (this.int_0 + this.int_2));
        A_0.Write((int) (this.int_1 + this.int_3));
    }
}

