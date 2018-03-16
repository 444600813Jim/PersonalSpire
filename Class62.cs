using System;
using System.IO;

[CLSCompliant(false)]
internal class Class62
{
    private Class186 class186_0;
    private Class299 class299_0;
    private int int_0;
    private int int_1;

    internal Class62()
    {
        this.class186_0 = new Class186();
        this.class299_0 = new Class299();
    }

    internal Class62(Stream A_0)
    {
        this.class186_0 = new Class186();
        this.class299_0 = new Class299();
        byte[] buffer = new byte[4];
        this.int_0 = this.class299_0.method_1(A_0, buffer);
        this.int_1 = this.class299_0.method_1(A_0, buffer);
        this.class186_0.method_6(A_0);
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal void method_1(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_2()
    {
        return this.int_1;
    }

    internal void method_3(int A_0)
    {
        this.int_1 = A_0;
    }

    internal Class186 method_4()
    {
        return this.class186_0;
    }

    internal void method_5(Stream A_0)
    {
        this.class299_0.method_4(A_0, this.int_0);
        this.class299_0.method_4(A_0, this.int_1);
        this.class186_0.method_7(A_0);
    }
}

