using Spire.Doc;
using System;
using System.IO;

internal abstract class Class453
{
    private int int_0;

    protected Class453()
    {
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal void method_1(int A_0)
    {
        this.int_0 = A_0;
    }

    internal string method_2()
    {
        return string.Format(BookmarkStart.b("瀮䨰̲䠴", 9), this.int_0);
    }

    internal abstract string vmethod_0(string A_0);
    internal abstract string vmethod_1(string A_0);
    internal abstract void vmethod_2(Stream A_0, string A_1);
}

