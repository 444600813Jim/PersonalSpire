using System;
using System.IO;

internal abstract class Class380 : Class379
{
    private int int_1;

    protected Class380(int A_0, int A_1) : base(A_0)
    {
        this.int_1 = A_1;
    }

    internal int method_1()
    {
        return this.int_1;
    }

    internal void method_2(int A_0)
    {
        this.int_1 = A_0;
    }

    internal override bool vmethod_0()
    {
        return true;
    }

    internal override int vmethod_1()
    {
        return 0;
    }

    internal abstract void vmethod_2(BinaryReader A_0);
    internal abstract void vmethod_3(BinaryWriter A_0);
}

