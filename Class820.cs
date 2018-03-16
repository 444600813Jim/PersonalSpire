using System;

internal class Class820 : Interface1
{
    private Class65[] class65_0;
    private int int_0;
    private int int_1;
    private Interface4 interface4_0;

    public Class820(Interface4 A_0, int A_1) : this(A_0, A_1, 0)
    {
    }

    public Class820(Interface4 A_0, int A_1, Class65[] A_2) : this(A_0, A_1, 0)
    {
        this.class65_0 = A_2;
    }

    public Class820(Interface4 A_0, int A_1, int A_2)
    {
        this.interface4_0 = A_0;
        this.int_0 = A_1;
        this.int_1 = A_2;
    }

    public void imethod_1(Class196 A_0, Class375 A_1)
    {
        throw new NotImplementedException();
    }

    public void imethod_2(Class196 A_0, Class375 A_1)
    {
        throw new NotImplementedException();
    }

    Interface23 Interface1.imethod_0()
    {
        return null;
    }

    public Interface4 method_0()
    {
        return this.interface4_0;
    }

    public int method_1()
    {
        return this.int_0;
    }

    public int method_2()
    {
        return this.int_1;
    }

    public Class65[] method_3()
    {
        return this.class65_0;
    }
}

