using System;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
internal class Class161 : Class147
{
    internal Class161() : base(2)
    {
    }

    internal Class1059 method_25(int A_0)
    {
        return (Class1059) base.method_18(A_0);
    }

    protected override object vmethod_0(BinaryReader A_0)
    {
        return new Class1059(A_0);
    }
}

