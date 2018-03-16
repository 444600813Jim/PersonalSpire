using Spire.Doc;
using System;
using System.IO;

[CLSCompliant(false)]
internal class Class610
{
    private Class299 class299_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private string string_0;
    private string string_1;

    internal Class610()
    {
        this.int_0 = 1;
        this.int_1 = 1;
        this.int_2 = 1;
        this.int_3 = 1;
        this.class299_0 = new Class299();
    }

    internal Class610(Stream A_0)
    {
        int num = 14;
        this.int_0 = 1;
        this.int_1 = 1;
        this.int_2 = 1;
        this.int_3 = 1;
        this.class299_0 = new Class299();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䜳䈵䨷弹崻匽", num));
        }
        byte[] buffer = new byte[4];
        this.class299_0.method_1(A_0, buffer);
        this.int_0 = this.class299_0.method_1(A_0, buffer);
        this.string_0 = this.class299_0.method_2(A_0);
        this.string_1 = this.class299_0.method_2(A_0);
        this.int_1 = this.class299_0.method_1(A_0, buffer);
        this.int_2 = this.class299_0.method_1(A_0, buffer);
        this.int_3 = this.class299_0.method_1(A_0, buffer);
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

    internal void method_12(Stream A_0)
    {
        int num4 = 7;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("帬嬮䌰嘲吴娶", num4));
        }
        long position = A_0.Position;
        A_0.Position += 4L;
        this.class299_0.method_4(A_0, this.int_0);
        this.class299_0.method_5(A_0, this.string_0);
        long num2 = A_0.Position;
        int num3 = (int) (num2 - position);
        A_0.Position = position;
        this.class299_0.method_4(A_0, num3);
        A_0.Position = num2;
        this.class299_0.method_5(A_0, this.string_1);
        this.class299_0.method_4(A_0, this.int_1);
        this.class299_0.method_4(A_0, this.int_2);
        this.class299_0.method_4(A_0, this.int_3);
    }

    internal string method_2()
    {
        return this.string_0;
    }

    internal void method_3(string A_0)
    {
        this.string_0 = A_0;
    }

    internal string method_4()
    {
        return this.string_1;
    }

    internal void method_5(string A_0)
    {
        this.string_1 = A_0;
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

