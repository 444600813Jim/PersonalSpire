using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class66
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private int int_0;
    private readonly StyleIdentifier styleIdentifier_0;

    internal Class66(StyleIdentifier A_0, bool A_1, bool A_2, bool A_3, int A_4, bool A_5)
    {
        int num = 4;
        if (A_0 == StyleIdentifier.User)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("天堫圭尯圱紳刵崷吹䠻圽☿⭁⅃㑅", num));
        }
        this.styleIdentifier_0 = A_0;
        this.int_0 = A_4;
        this.bool_0 = A_1;
        this.bool_2 = A_3;
        this.bool_3 = A_5;
        this.bool_1 = A_2;
    }

    internal Class66 method_0()
    {
        return (Class66) base.MemberwiseClone();
    }

    internal bool method_1(Class66 A_0)
    {
        return ((((A_0.bool_0 == this.bool_0) && (A_0.bool_1 == this.bool_1)) && ((A_0.bool_2 == this.bool_2) && (A_0.int_0 == this.int_0))) && (A_0.bool_3 == this.bool_3));
    }

    internal void method_10(int A_0)
    {
        this.int_0 = A_0;
    }

    internal bool method_11()
    {
        return this.bool_3;
    }

    internal void method_12(bool A_0)
    {
        this.bool_3 = A_0;
    }

    internal StyleIdentifier method_2()
    {
        return this.styleIdentifier_0;
    }

    internal bool method_3()
    {
        return this.bool_0;
    }

    internal void method_4(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal bool method_5()
    {
        return this.bool_1;
    }

    internal void method_6(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal bool method_7()
    {
        return this.bool_2;
    }

    internal void method_8(bool A_0)
    {
        this.bool_2 = A_0;
    }

    internal int method_9()
    {
        return this.int_0;
    }
}

