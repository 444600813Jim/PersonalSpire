using Spire.Doc;
using Spire.Doc.Formatting;
using System;

internal class Class15 : WordAttrCollection
{
    internal const short short_0 = 1;
    internal const short short_1 = 2;

    internal Class15()
    {
    }

    public Class15(FormatBase A_0, int A_1) : base(A_0, A_1)
    {
    }

    internal Class15(FtsWidth A_0, int A_1)
    {
        this.method_52(A_0);
        this.method_50((float) A_1);
    }

    internal float method_49()
    {
        return (float) base[1];
    }

    internal void method_50(float A_0)
    {
        base[1] = A_0;
    }

    internal FtsWidth method_51()
    {
        FtsWidth width = (FtsWidth) base[2];
        if ((this.method_49() > 0f) || ((width != FtsWidth.Point) && (width != FtsWidth.Percentage)))
        {
            return width;
        }
        return FtsWidth.Auto;
    }

    internal void method_52(FtsWidth A_0)
    {
        base[2] = A_0;
    }

    internal FtsWidth method_53()
    {
        return (FtsWidth) base[2];
    }

    internal void method_54(FtsWidth A_0)
    {
        base[2] = A_0;
    }

    internal bool method_55()
    {
        return ((this.method_49() != 0f) && (this.method_51() != FtsWidth.Auto));
    }

    internal float method_56()
    {
        if (this.method_51() == FtsWidth.Point)
        {
            return (this.method_49() / 20f);
        }
        return 0f;
    }

    internal bool method_57()
    {
        return (this.method_53() == FtsWidth.Point);
    }

    object FormatBase.GetDefValue(int A_0)
    {
        switch (A_0)
        {
            case 1:
                return 0f;

            case 2:
                return FtsWidth.Auto;
        }
        throw new NotImplementedException();
    }
}

