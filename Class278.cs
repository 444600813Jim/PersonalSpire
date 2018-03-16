using System;
using System.IO;

internal class Class278 : Class272, Interface68
{
    internal Class278() : base(EscherRecordType.SolverContainer)
    {
    }

    private Class74 imethod_0(int A_0)
    {
        for (int i = 0; i < base.method_8(); i++)
        {
            Class266 class2 = base.method_7().method_0(i);
            if (class2 is Class286)
            {
                Class286 class3 = (Class286) class2;
                if (class3.int_3 == A_0)
                {
                    return class3.method_4();
                }
            }
        }
        return null;
    }

    private void imethod_1(int A_0, Class74 A_1)
    {
        int num = base.method_8() + 1;
        Class286 class2 = new Class286(num, A_0, A_1);
        base.method_7().Add(class2);
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        base.vmethod_1(A_0);
        base.method_3().method_7(base.method_7().Count);
    }
}

