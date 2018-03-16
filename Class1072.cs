using Spire.Doc;
using System;
using System.IO;

[CLSCompliant(false)]
internal class Class1072
{
    private Class299 class299_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private string string_0;

    internal Class1072()
    {
        this.int_2 = 4;
        this.class299_0 = new Class299();
    }

    internal Class1072(Stream A_0)
    {
        int num = 14;
        this.int_2 = 4;
        this.class299_0 = new Class299();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䜳䈵䨷弹崻匽", num));
        }
        byte[] buffer = new byte[4];
        this.string_0 = this.class299_0.method_2(A_0);
        this.int_0 = this.class299_0.method_1(A_0, buffer);
        this.int_1 = this.class299_0.method_1(A_0, buffer);
        this.int_2 = this.class299_0.method_1(A_0, buffer);
    }

    internal string method_0()
    {
        return this.string_0;
    }

    internal void method_1(string A_0)
    {
        this.string_0 = A_0;
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

    internal int method_5()
    {
        return this.int_2;
    }

    internal void method_6(Stream A_0)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尮䔰䄲倴嘶吸", num));
        }
        this.class299_0.method_5(A_0, this.string_0);
        this.class299_0.method_4(A_0, this.int_0);
        this.class299_0.method_4(A_0, this.int_1);
        this.class299_0.method_4(A_0, this.int_2);
    }
}

