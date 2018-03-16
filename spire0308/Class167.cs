using System;
using System.IO;

internal class Class167
{
    private readonly int int_0;
    private readonly int int_1;
    private readonly string string_0;

    internal Class167(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
        this.string_0 = Class813.smethod_1(A_0, true, false);
    }

    internal Class167(int A_0, int A_1, string A_2)
    {
        this.int_0 = A_0;
        this.int_1 = A_1;
        this.string_0 = A_2;
    }

    internal void method_0(BinaryWriter A_0)
    {
        A_0.Write(this.int_0);
        A_0.Write(this.int_1);
        Class813.smethod_2(this.string_0, this.string_0.Length, A_0, true, false);
    }

    internal int method_1()
    {
        return this.int_0;
    }

    internal int method_2()
    {
        return this.int_1;
    }

    internal string method_3()
    {
        return this.string_0;
    }
}

