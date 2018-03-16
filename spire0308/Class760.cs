using System;

internal class Class760
{
    private int int_0;
    private int int_1;

    internal Class760()
    {
    }

    internal Class760(int A_0, int A_1)
    {
        this.int_0 = A_0;
        this.int_1 = A_1;
    }

    internal bool method_0(int A_0)
    {
        return ((A_0 >= this.int_0) && (A_0 < this.int_1));
    }

    internal bool method_1()
    {
        return (this.int_0 == this.int_1);
    }

    internal int method_2()
    {
        return this.int_0;
    }

    internal void method_3(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_4()
    {
        return this.int_1;
    }

    internal void method_5(int A_0)
    {
        this.int_1 = A_0;
    }

    internal int method_6()
    {
        return (this.int_1 - this.int_0);
    }
}

