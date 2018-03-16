using System;
using System.IO;

internal class Class485 : Class483, Interface16
{
    internal static bool bool_0;
    private Class159 class159_0;

    internal Class485(BinaryReader A_0) : base(A_0)
    {
    }

    private void imethod_0(BinaryReader A_0, int A_1, int A_2)
    {
        Class873 class2 = new Class873(A_0);
        long position = A_0.BaseStream.Position;
        try
        {
            Class430 class3;
            if (class2.int_2 != 0)
            {
                long offset = base.method_0() + (class2.int_2 * 2);
                A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
                class3 = new Class430(A_0, true);
            }
            else
            {
                class3 = new Class430();
            }
            this.class159_0.method_5(A_1, A_2, class3);
        }
        finally
        {
            A_0.BaseStream.Seek(position, SeekOrigin.Begin);
        }
    }

    internal void method_3(Class159 A_0)
    {
        this.class159_0 = A_0;
        Class144.smethod_1(base.method_2(), base.method_1(), this);
    }
}

