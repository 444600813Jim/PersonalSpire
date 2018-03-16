using System;
using System.IO;

[CLSCompliant(false)]
internal class Class993
{
    private Class991 class991_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private int int_4;
    private int int_5;
    private int int_6;
    private int int_7;
    private string string_0;

    internal Class993()
    {
        this.class991_0 = new Class991();
    }

    internal Class993(Stream A_0)
    {
        this.class991_0 = new Class991();
        this.method_22(A_0);
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal void method_1(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_10()
    {
        return this.int_3;
    }

    internal void method_11(int A_0)
    {
        this.int_3 = A_0;
    }

    internal int method_12()
    {
        return this.int_4;
    }

    internal void method_13(int A_0)
    {
        this.int_4 = A_0;
    }

    internal int method_14()
    {
        return this.int_5;
    }

    internal void method_15(int A_0)
    {
        this.int_5 = A_0;
    }

    internal int method_16()
    {
        return this.int_6;
    }

    internal void method_17(int A_0)
    {
        this.int_6 = A_0;
    }

    internal int method_18()
    {
        return this.int_7;
    }

    internal void method_19(int A_0)
    {
        this.int_7 = A_0;
    }

    internal bool method_2()
    {
        return (((this.method_0() >> 2) & 1) == 1);
    }

    internal string method_20()
    {
        return this.string_0;
    }

    internal void method_21(string A_0)
    {
        if ((A_0 == null) || (A_0.Length == 0))
        {
            throw new ArgumentOutOfRangeException();
        }
        this.string_0 = A_0;
    }

    internal void method_22(Stream A_0)
    {
        byte[] buffer = new byte[4];
        long position = A_0.Position;
        int num2 = this.class991_0.method_0(A_0, buffer);
        this.int_0 = this.class991_0.method_0(A_0, buffer);
        this.int_1 = this.class991_0.method_0(A_0, buffer);
        this.int_2 = this.class991_0.method_0(A_0, buffer);
        this.int_3 = this.class991_0.method_0(A_0, buffer);
        this.int_4 = this.class991_0.method_0(A_0, buffer);
        this.int_5 = this.class991_0.method_0(A_0, buffer);
        this.int_6 = this.class991_0.method_0(A_0, buffer);
        this.int_7 = this.class991_0.method_0(A_0, buffer);
        this.string_0 = this.class991_0.method_2(A_0);
        A_0.Position = (position + num2) + 4L;
    }

    internal void method_23(Stream A_0)
    {
        long position = A_0.Position;
        A_0.Position += 4L;
        this.class991_0.method_3(A_0, this.int_0);
        this.class991_0.method_3(A_0, this.int_1);
        this.class991_0.method_3(A_0, this.int_2);
        this.class991_0.method_3(A_0, this.int_3);
        this.class991_0.method_3(A_0, this.int_4);
        this.class991_0.method_3(A_0, this.int_5);
        this.class991_0.method_3(A_0, this.int_6);
        this.class991_0.method_3(A_0, this.int_7);
        this.class991_0.method_5(A_0, this.string_0);
        long num2 = A_0.Position;
        int num3 = ((int) (num2 - position)) - 4;
        A_0.Position = position;
        this.class991_0.method_3(A_0, num3);
        A_0.Position = num2;
    }

    internal bool method_3()
    {
        return (((this.method_0() >> 3) & 1) == 1);
    }

    internal bool method_4()
    {
        return (((this.method_0() >> 4) & 1) == 1);
    }

    internal bool method_5()
    {
        return (((this.method_0() >> 5) & 1) == 1);
    }

    internal int method_6()
    {
        return this.int_1;
    }

    internal void method_7(int A_0)
    {
        this.int_1 = A_0;
    }

    internal int method_8()
    {
        return this.int_2;
    }

    internal void method_9(int A_0)
    {
        this.int_2 = A_0;
    }
}

