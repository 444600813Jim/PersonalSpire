using Spire.Doc;
using System;
using System.IO;

internal class Class766 : Interface35
{
    internal const int int_0 = 2;
    private int int_1;
    private int int_2;

    internal Class766(BinaryReader A_0)
    {
        this.int_1 = A_0.ReadByte();
        this.int_2 = A_0.ReadByte();
    }

    internal Class766(int A_0, int A_1)
    {
        this.int_1 = A_0;
        this.int_2 = A_1;
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write((byte) this.int_1);
        A_0.Write((byte) this.int_2);
    }

    internal int method_0()
    {
        return this.int_2;
    }

    internal void method_1(int A_0)
    {
        this.int_2 = A_0;
    }

    internal void method_10(bool A_0)
    {
        this.int_2 = (byte) Class336.smethod_5(this.int_2, 0x10, A_0);
    }

    internal bool method_11()
    {
        return ((this.int_2 & 8) != 0);
    }

    internal void method_12(bool A_0)
    {
        this.int_2 = (byte) Class336.smethod_5(this.int_2, 8, A_0);
    }

    internal bool method_13()
    {
        return ((this.int_2 & 4) != 0);
    }

    internal void method_14(bool A_0)
    {
        this.int_2 = (byte) Class336.smethod_5(this.int_2, 4, A_0);
    }

    internal FieldType method_2()
    {
        return (FieldType) this.int_2;
    }

    internal bool method_3()
    {
        return ((this.int_2 & 0x80) != 0);
    }

    internal void method_4(bool A_0)
    {
        this.int_2 = (byte) Class336.smethod_5(this.int_2, 0x80, A_0);
    }

    internal bool method_5()
    {
        return ((this.int_2 & 0x40) != 0);
    }

    internal void method_6(bool A_0)
    {
        this.int_2 = (byte) Class336.smethod_5(this.int_2, 0x40, A_0);
    }

    internal bool method_7()
    {
        return ((this.int_2 & 0x20) != 0);
    }

    internal void method_8(bool A_0)
    {
        this.int_2 = (byte) Class336.smethod_5(this.int_2, 0x20, A_0);
    }

    internal bool method_9()
    {
        return ((this.int_2 & 0x10) != 0);
    }
}

