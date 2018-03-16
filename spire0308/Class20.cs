using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Caculation;
using System;

internal class Class20 : Class18
{
    internal MathJustification method_46()
    {
        return (MathJustification) base.method_32(0x3aa2);
    }

    internal void method_47(MathJustification A_0)
    {
        base.SetAttr(0x3aa2, A_0, A_0 != MathJustification.CenterGroup);
    }

    internal override bool vmethod_0(DocumentObject A_0)
    {
        return ((A_0.DocumentObjectType == DocumentObjectType.OfficeMath) && (((Class5) A_0).method_32().vmethod_1() == MathObjectType.OMath));
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.OMathPara;
    }
}

