using System;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
internal class Class152 : Class147
{
    internal Class152() : base(0x1a)
    {
    }

    internal Class347 method_25(int A_0)
    {
        return (Class347) base.method_18(A_0);
    }

    protected override object vmethod_0(BinaryReader A_0)
    {
        return new Class347(A_0);
    }
}

