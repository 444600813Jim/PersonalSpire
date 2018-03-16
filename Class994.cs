using System;
using System.IO;

[CLSCompliant(false)]
internal class Class994
{
    private Class991 class991_0;
    private Class992 class992_0;
    private Class993 class993_0;
    private int int_0;
    private int int_1;

    internal Class994()
    {
        this.class993_0 = new Class993();
        this.class992_0 = new Class992();
        this.class991_0 = new Class991();
    }

    internal Class994(Stream A_0)
    {
        this.class993_0 = new Class993();
        this.class992_0 = new Class992();
        this.class991_0 = new Class991();
        byte[] buffer = new byte[4];
        this.int_0 = this.class991_0.method_0(A_0, buffer);
        if (this.method_3() == 2)
        {
            this.int_1 = this.class991_0.method_0(A_0, buffer);
            this.class993_0.method_22(A_0);
            this.class992_0.method_8(A_0);
        }
        else
        {
            this.class992_0.method_9(A_0, true);
        }
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
        return (this.int_0 & 0xff);
    }

    internal int method_3()
    {
        return (this.int_0 >> 0x10);
    }

    internal int method_4()
    {
        return this.int_1;
    }

    internal void method_5(int A_0)
    {
        this.int_1 = A_0;
    }

    internal Class993 method_6()
    {
        return this.class993_0;
    }

    internal Class992 method_7()
    {
        return this.class992_0;
    }

    internal void method_8(Stream A_0)
    {
        this.class991_0.method_3(A_0, this.int_0);
        this.class991_0.method_3(A_0, this.int_1);
        this.class993_0.method_23(A_0);
        this.class992_0.method_10(A_0);
    }
}

