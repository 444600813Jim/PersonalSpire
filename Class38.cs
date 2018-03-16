using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Caculation;
using System;

internal class Class38 : Class18
{
    internal MathFractionType method_46()
    {
        return (MathFractionType) base.method_32(0x3c64);
    }

    internal void method_47(MathFractionType A_0)
    {
        base.SetAttr(0x3c64, A_0, A_0 != MathFractionType.Bar);
    }

    internal override bool vmethod_0(DocumentObject A_0)
    {
        if (A_0.DocumentObjectType != DocumentObjectType.OfficeMath)
        {
            return false;
        }
        Class18 class2 = ((Class5) A_0).method_32();
        if (class2.vmethod_1() != MathObjectType.Numerator)
        {
            return (class2.vmethod_1() == MathObjectType.Denominator);
        }
        return true;
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.Fraction;
    }
}

