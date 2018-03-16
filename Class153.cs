using System;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
internal class Class153 : Class147
{
    internal Class153() : base(30)
    {
    }

    internal Class872 method_25(int A_0)
    {
        return (Class872) base.method_18(A_0);
    }

    internal void method_26(BinaryReader A_0, int A_1, int A_2)
    {
        A_0.BaseStream.Position = A_1;
        int num = A_2 / 0x12;
        for (int i = 0; i < num; i++)
        {
            this.method_25(i).method_0(A_0);
        }
    }

    internal int method_27(BinaryWriter A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        for (int i = 0; i < base.method_4(); i++)
        {
            this.method_25(i).method_1(A_0);
        }
        return (((int) A_0.BaseStream.Position) - position);
    }

    protected override object vmethod_0(BinaryReader A_0)
    {
        return new Class872(A_0);
    }
}

