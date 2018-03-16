using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Caculation;
using System;

internal class Class40 : Class18
{
    internal bool method_46()
    {
        return (bool) base.method_32(0x3cb4);
    }

    internal void method_47(bool A_0)
    {
        base.SetAttr(0x3cb4, A_0, A_0);
    }

    internal override bool vmethod_0(DocumentObject A_0)
    {
        return (base.vmethod_0(A_0) || ((A_0.DocumentObjectType == DocumentObjectType.OfficeMath) && (((Class5) A_0).method_32().vmethod_1() == MathObjectType.Degree)));
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.Radical;
    }
}

