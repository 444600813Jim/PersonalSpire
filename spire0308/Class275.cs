using System;
using System.IO;

internal class Class275 : Class272, Interface36
{
    internal Class275() : base(EscherRecordType.BstoreContainer)
    {
    }

    private Class268 imethod_0(int A_0)
    {
        int num = A_0 - 1;
        if ((num >= 0) && (num < base.method_7().Count))
        {
            return (Class268) base.method_7().method_0(num);
        }
        return null;
    }

    private int imethod_1(Class268 A_0)
    {
        int num = base.method_7().Count + 1;
        base.method_7().Add(A_0);
        return num;
    }

    internal void method_11(BinaryReader A_0)
    {
        foreach (Class268 class2 in base.method_7())
        {
            if (!class2.method_6())
            {
                class2.method_4(A_0);
            }
        }
    }

    internal void method_12(BinaryWriter A_0)
    {
        foreach (Class268 class2 in base.method_7())
        {
            if (!class2.method_6())
            {
                class2.method_5(A_0);
            }
        }
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        base.method_3().method_7(base.method_7().Count);
        base.vmethod_1(A_0);
    }
}

