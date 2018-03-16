using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.IO;

internal class Class165 : Class147
{
    internal static bool bool_0;
    internal const int int_2 = 6;
    internal const int int_3 = 6;
    private readonly int int_4;

    internal Class165() : base(0)
    {
    }

    internal Class165(Class703 A_0, BinaryReader A_1, int A_2) : this()
    {
        this.int_4 = A_2;
        base.method_23(A_1, A_0.class597_0.class1111_11);
    }

    internal Class760 method_25(int A_0, HeaderFooterType A_1)
    {
        int num = (6 + (A_0 * 6)) + A_1;
        return this.method_27(num);
    }

    internal Class760 method_26(FootnoteSeparatorType A_0)
    {
        return this.method_27((int) A_0);
    }

    private Class760 method_27(int A_0)
    {
        int num = base.method_3() - 1;
        if (this.method_28())
        {
            num--;
        }
        num--;
        if (A_0 > num)
        {
            return null;
        }
        Class760 class2 = new Class760(base.method_16(A_0), base.method_16(A_0 + 1));
        if ((A_0 == num) && !this.method_28())
        {
            class2.method_5(class2.method_4() - 1);
        }
        return class2;
    }

    private bool method_28()
    {
        int num = ((6 + (this.int_4 * 6)) + 1) + 1;
        return (num == base.method_3());
    }

    internal override int vmethod_1(BinaryWriter A_0)
    {
        if (base.method_4() <= 6)
        {
            return 0;
        }
        return base.vmethod_1(A_0);
    }
}

