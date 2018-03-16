using Spire.Doc;
using System;
using System.Drawing;

internal class Class891
{
    private readonly Class623 class623_0;
    private readonly Class623 class623_1;

    internal Class891() : this(Point.Empty)
    {
    }

    internal Class891(Point A_0) : this(new Class623(A_0.X, false), new Class623(A_0.Y, false))
    {
    }

    internal Class891(Class623 A_0, Class623 A_1)
    {
        this.class623_0 = A_0;
        this.class623_1 = A_1;
    }

    internal Class891(int A_0, int A_1) : this(new Point(A_0, A_1))
    {
    }

    internal Class623 method_0()
    {
        return this.class623_0;
    }

    internal Class623 method_1()
    {
        return this.class623_1;
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("漶̸䀺഼䈾浀捂᱄絆㉈穊が", 0x11), this.method_0().ToString(), this.method_1().ToString());
    }
}

