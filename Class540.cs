using System;
using System.IO;

[CLSCompliant(false)]
internal class Class540
{
    private Class299 class299_0;
    private Class494 class494_0;
    private Class709 class709_0;
    private int int_0;
    private int int_1;

    internal Class540()
    {
        this.class494_0 = new Class494();
        this.class709_0 = new Class709();
        this.class299_0 = new Class299();
    }

    internal Class540(Stream A_0)
    {
        this.class494_0 = new Class494();
        this.class709_0 = new Class709();
        this.class299_0 = new Class299();
        byte[] buffer = new byte[4];
        this.int_0 = this.class299_0.method_1(A_0, buffer);
        if (this.method_3() == 2)
        {
            this.int_1 = this.class299_0.method_1(A_0, buffer);
            this.class494_0.method_22(A_0);
            this.class709_0.method_8(A_0);
        }
        else
        {
            this.class709_0.method_9(A_0, true);
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

    internal Class494 method_6()
    {
        return this.class494_0;
    }

    internal Class709 method_7()
    {
        return this.class709_0;
    }

    internal void method_8(Stream A_0)
    {
        this.class299_0.method_4(A_0, this.int_0);
        this.class299_0.method_4(A_0, this.int_1);
        this.class494_0.method_23(A_0);
        this.class709_0.method_10(A_0);
    }
}

