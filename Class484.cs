using System;
using System.IO;

internal class Class484 : Class483, Interface16
{
    internal static bool bool_0;
    private Class158 class158_0;

    internal Class484(BinaryReader A_0) : base(A_0)
    {
    }

    private void imethod_0(BinaryReader A_0, int A_1, int A_2)
    {
        int num = A_0.ReadByte();
        long position = A_0.BaseStream.Position;
        try
        {
            Class431 class2;
            if (num != 0)
            {
                long offset = base.method_0() + (num * 2);
                A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
                class2 = new Class431(A_0, true);
            }
            else
            {
                class2 = new Class431();
            }
            this.class158_0.method_5(A_1, A_2, class2);
        }
        finally
        {
            A_0.BaseStream.Seek(position, SeekOrigin.Begin);
        }
    }

    internal void method_3(Class158 A_0)
    {
        this.class158_0 = A_0;
        Class144.smethod_1(base.method_2(), base.method_1(), this);
    }
}

