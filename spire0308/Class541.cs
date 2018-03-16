using Spire.Doc;
using System;
using System.IO;

[CLSCompliant(false)]
internal class Class541
{
    private Class299 class299_0;
    private int int_0;
    private string string_0;

    internal Class541(Stream A_0)
    {
        this.class299_0 = new Class299();
        byte[] buffer = new byte[4];
        this.int_0 = this.class299_0.method_1(A_0, buffer);
        this.string_0 = this.class299_0.method_2(A_0);
    }

    internal Class541(int A_0, string A_1)
    {
        this.class299_0 = new Class299();
        this.int_0 = A_0;
        this.string_0 = A_1;
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal string method_1()
    {
        return this.string_0;
    }

    internal void method_2(Stream A_0)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("否崨太䠬丮尰", num));
        }
        this.class299_0.method_4(A_0, this.int_0);
        this.class299_0.method_5(A_0, this.string_0);
    }
}

