using System;

internal class Class828 : Interface31
{
    private int int_0;

    bool Interface31.imethod_0()
    {
        return false;
    }

    Interface31 Interface31.imethod_1()
    {
        return (Interface31) base.MemberwiseClone();
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal void method_1(int A_0)
    {
        this.int_0 = (A_0 > 0xff) ? 0xff : ((A_0 < 0) ? 0 : A_0);
    }

    internal bool method_2()
    {
        return (this.int_0 == 0);
    }
}

