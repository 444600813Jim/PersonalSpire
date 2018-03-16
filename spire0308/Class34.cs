using Spire.Doc;
using Spire.Doc.Fields.Caculation;
using System;

internal class Class34 : Class18
{
    internal const int int_7 = 0;
    private int int_8;
    private readonly MathObjectType mathObjectType_0;

    internal Class34(MathObjectType A_0)
    {
        int num = 12;
        switch (A_0)
        {
            case MathObjectType.Degree:
            case MathObjectType.Argument:
            case MathObjectType.Denominator:
            case MathObjectType.Numerator:
            case MathObjectType.FunctionName:
            case MathObjectType.Limit:
            case MathObjectType.SubscriptPart:
            case MathObjectType.SuperscriptPart:
                this.mathObjectType_0 = A_0;
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("戱堳匵夷䤹夻ḽ㈿❁㑃⥅㩇㹉汋⭍⡏ㅑㅓ♕ⱗ㍙㍛そ", num));
    }

    internal int method_46()
    {
        return this.int_8;
    }

    internal void method_47(int A_0)
    {
        int num = (A_0 < -2) ? -2 : ((A_0 > 2) ? 2 : A_0);
        if (num != 0)
        {
            this.int_8 = num;
        }
    }

    internal override bool vmethod_0(DocumentObject A_0)
    {
        return Class18.smethod_5(A_0);
    }

    internal override MathObjectType vmethod_1()
    {
        return this.mathObjectType_0;
    }

    internal override bool vmethod_2()
    {
        return false;
    }

    internal override bool vmethod_3()
    {
        return false;
    }
}

