using System;
using System.IO;

internal class Class175 : Class172
{
    private string string_0;

    internal Class175(int A_0, int A_1) : base(A_0, A_1)
    {
    }

    internal Class175(int A_0, string A_1) : base(A_0, Class813.smethod_11(A_1))
    {
        this.string_0 = A_1;
    }

    internal string method_3()
    {
        return this.string_0;
    }

    internal override void vmethod_2(BinaryReader A_0)
    {
        this.string_0 = Class813.smethod_5(A_0, base.method_1());
    }

    internal override void vmethod_3(BinaryWriter A_0)
    {
        Class813.smethod_8(this.string_0, A_0);
    }
}

