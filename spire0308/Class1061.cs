using Spire.Doc;
using System;

internal class Class1061
{
    private string string_0;

    internal Class1061()
    {
        this.string_0 = string.Empty;
    }

    internal Class1061(string A_0)
    {
        this.string_0 = string.Empty;
        this.method_1(A_0);
    }

    internal string method_0()
    {
        return this.string_0;
    }

    internal void method_1(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("伸娺儼䨾⑀", 0x13));
        this.string_0 = A_0;
    }

    internal static string smethod_0(string A_0)
    {
        Class1061 class2 = new Class1061(A_0);
        return class2.ToString();
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("ᘵ紷眹縻笽п扁㽃癅㕇橉", 0x10), this.method_0());
    }
}

