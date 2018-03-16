using Spire.Doc;
using System;
using System.Collections;

internal class Class117
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private bool bool_0;
    private string string_0;
    private string string_1;

    internal Class117(string A_0, ArrayList A_1, string A_2)
    {
        this.string_0 = A_0;
        this.arrayList_0 = A_1;
        this.string_1 = A_2;
    }

    internal string method_0()
    {
        return this.string_0;
    }

    internal void method_1(string A_0)
    {
        this.string_0 = A_0;
    }

    internal string method_2()
    {
        return Class956.smethod_0(this.string_0).Split(new char[] { '?' })[0];
    }

    internal string method_3()
    {
        return this.string_1;
    }

    internal void method_4(string A_0)
    {
        this.string_1 = A_0;
    }

    internal ArrayList method_5()
    {
        return this.arrayList_0;
    }

    internal bool method_6()
    {
        return !this.string_0.StartsWith(BookmarkStart.b("༫", 6));
    }

    internal bool method_7()
    {
        return this.bool_0;
    }

    internal void method_8(bool A_0)
    {
        this.bool_0 = A_0;
    }
}

