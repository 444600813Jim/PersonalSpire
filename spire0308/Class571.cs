using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class571 : ArrayList
{
    private int int_0 = 1;
    private RowFormat rowFormat_0 = new RowFormat();
    private string string_0;

    internal Class571()
    {
    }

    public Class1140 method_0(int A_0)
    {
        return (Class1140) base[A_0];
    }

    public void method_1(int A_0, Class1140 A_1)
    {
        base[A_0] = A_1;
    }

    internal RowFormat method_2()
    {
        return this.rowFormat_0;
    }

    internal void method_3(RowFormat A_0)
    {
        this.rowFormat_0 = A_0;
    }

    internal int method_4()
    {
        return this.int_0;
    }

    internal void method_5(int A_0)
    {
        this.int_0 = A_0;
    }

    internal string method_6()
    {
        return this.string_0;
    }

    internal void method_7(string A_0)
    {
        this.string_0 = A_0;
    }
}

