using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Caculation;
using System;

internal class Class22 : Class18
{
    internal override bool vmethod_0(DocumentObject A_0)
    {
        return (base.vmethod_0(A_0) || ((A_0.DocumentObjectType == DocumentObjectType.OfficeMath) && (((Class5) A_0).method_32().vmethod_1() == MathObjectType.Limit)));
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.UpperLimit;
    }
}

