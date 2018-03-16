using System;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
internal class Class160 : Class147
{
    internal readonly BinaryReader binaryReader_0;
    internal static bool bool_0;

    internal Class160() : base(12)
    {
    }

    internal Class160(Class703 A_0, BinaryReader A_1, BinaryReader A_2) : this()
    {
        this.binaryReader_0 = A_1;
        base.method_23(A_2, A_0.class597_0.class1111_6);
    }

    internal Class596 method_25(int A_0)
    {
        return (Class596) base.method_18(A_0);
    }

    internal void method_26(BinaryWriter A_0)
    {
        for (int i = 0; i < base.method_4(); i++)
        {
            Class596 class2 = this.method_25(i);
            class2.uint_1 = uint.MaxValue;
            if (class2.class429_0.method_2().Length > 0)
            {
                class2.uint_0 = (uint) A_0.BaseStream.Position;
                class2.class429_0.method_4(A_0);
            }
            else
            {
                class2.uint_0 = uint.MaxValue;
            }
        }
    }

    protected override object vmethod_0(BinaryReader A_0)
    {
        Class596 class2 = new Class596(A_0);
        if (class2.uint_0 != uint.MaxValue)
        {
            this.binaryReader_0.BaseStream.Seek((long) class2.uint_0, SeekOrigin.Begin);
            class2.class429_0 = new Class429(this.binaryReader_0);
        }
        return class2;
    }
}

