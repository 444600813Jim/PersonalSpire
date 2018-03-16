using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Caculation;
using System;

internal class Class26 : Class18
{
    internal override bool vmethod_0(DocumentObject A_0)
    {
        if (!base.vmethod_0(A_0))
        {
            if (A_0.DocumentObjectType != DocumentObjectType.OfficeMath)
            {
                return false;
            }
            MathObjectType type = ((Class5) A_0).method_32().vmethod_1();
            if (type != MathObjectType.SubscriptPart)
            {
                return (type == MathObjectType.SuperscriptPart);
            }
        }
        return true;
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.PreSubSuperscript;
    }
}

