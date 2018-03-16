using System;
using System.IO;

internal class Class872 : Interface35
{
    internal DateTime dateTime_0;
    internal const int int_0 = 30;
    internal const int int_1 = 0x12;
    private const int int_2 = 20;
    internal int int_3;
    internal int int_4;
    private int int_5;
    private int int_6;
    private int int_7;
    internal string string_0;

    internal Class872()
    {
        this.dateTime_0 = DateTime.MinValue;
    }

    internal Class872(BinaryReader A_0)
    {
        this.dateTime_0 = DateTime.MinValue;
        this.string_0 = Class813.smethod_3(A_0, 20);
        this.int_3 = A_0.ReadInt16();
        A_0.ReadInt16();
        A_0.ReadInt16();
        this.int_4 = A_0.ReadInt32();
    }

    public void imethod_0(BinaryWriter A_0)
    {
        Class813.smethod_4(this.string_0, A_0, 20);
        A_0.Write((short) this.int_3);
        A_0.Write((short) 0);
        A_0.Write((short) 0);
        A_0.Write(this.int_4);
    }

    internal void method_0(BinaryReader A_0)
    {
        this.dateTime_0 = Class353.smethod_2(A_0);
        A_0.ReadInt16();
        this.int_5 = A_0.ReadInt32();
        this.int_6 = A_0.ReadInt32();
        this.int_7 = A_0.ReadInt32();
    }

    public void method_1(BinaryWriter A_0)
    {
        Class353.smethod_3(this.dateTime_0, A_0);
        A_0.Write((short) 0);
        A_0.Write(0);
        A_0.Write(0);
        A_0.Write(0);
    }
}

