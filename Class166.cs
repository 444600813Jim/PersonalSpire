using System;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
internal class Class166 : Class147
{
    internal Class166() : base(0x16)
    {
    }

    internal Class480 method_25(int A_0)
    {
        return (Class480) base.method_18(A_0);
    }

    protected override object vmethod_0(BinaryReader A_0)
    {
        return new Class480(A_0);
    }
}

