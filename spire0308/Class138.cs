using System;
using System.IO;

internal class Class138
{
    private readonly byte[] byte_0;
    private readonly string string_0;

    internal Class138(BinaryReader A_0, int A_1)
    {
        int count = A_0.ReadInt16();
        int num2 = A_0.ReadInt16();
        this.byte_0 = A_0.ReadBytes(count);
        this.string_0 = Class813.smethod_16(A_0, num2, A_1);
    }

    internal void method_0(BinaryWriter A_0, int A_1)
    {
        A_0.Write((short) this.byte_0.Length);
        A_0.Write((short) (this.string_0.Length + 1));
        A_0.Write(this.byte_0);
        Class813.smethod_20(A_0, this.string_0, A_1, false);
    }

    internal byte[] method_1()
    {
        return this.byte_0;
    }

    internal string method_2()
    {
        return this.string_0;
    }
}

