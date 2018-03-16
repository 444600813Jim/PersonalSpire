using Spire.Doc;
using System;

internal class Class623
{
    private readonly bool bool_0;
    private readonly int int_0;

    internal Class623() : this(0, false)
    {
    }

    internal Class623(int A_0) : this(A_0, false)
    {
    }

    internal Class623(int A_0, bool A_1)
    {
        this.int_0 = A_0;
        this.bool_0 = A_1;
    }

    internal bool method_0()
    {
        return this.bool_0;
    }

    internal int method_1()
    {
        return this.int_0;
    }

    string object.ToString()
    {
        int num = 0x13;
        return string.Format(BookmarkStart.b("䈸଺䀼䐾灀㹂", 0x13), this.method_0() ? BookmarkStart.b("礸", num) : "", this.method_1());
    }
}

