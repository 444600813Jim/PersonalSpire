using Spire.Doc;
using System;

internal class Class388
{
    private Class72 class72_0;
    private Class72 class72_1;

    internal Class388(Class72 A_0, Class72 A_1)
    {
        this.class72_1 = A_0;
        this.class72_0 = A_1;
    }

    internal void method_0(Class72 A_0)
    {
        this.class72_1 = A_0;
    }

    internal Class72 method_1()
    {
        return this.class72_1;
    }

    internal void method_2(Class72 A_0)
    {
        this.class72_0 = A_0;
    }

    internal Class72 method_3()
    {
        return this.class72_0;
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("洴ശ䈸଺䀼ጾ慀ᩂ罄㱆硈㙊", 15), this.method_1().ToString(), this.method_3().ToString());
    }
}

