using System;

internal class Class145
{
    public Class146 class146_0;
    public int int_0;
    public int int_1;

    public Class145(Class146 A_0, int A_1, int A_2)
    {
        this.class146_0 = A_0;
        this.int_0 = A_1;
        this.int_1 = A_2;
    }

    public bool method_0()
    {
        return (this.class146_0.method_4() <= this.int_0);
    }

    public void method_1()
    {
        this.int_0++;
        this.int_1 = this.class146_0.method_16(this.int_0);
    }
}

