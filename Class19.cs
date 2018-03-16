using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Caculation;
using Spire.Doc.Formatting;
using System;

internal class Class19 : Class18
{
    private Class461 class461_0 = new Class461();
    private const int int_7 = 0x7bc0;

    internal MathBaseJustification method_46()
    {
        return (MathBaseJustification) base.method_32(0x3b7e);
    }

    internal void method_47(MathBaseJustification A_0)
    {
        base.SetAttr(0x3b7e, A_0, A_0 != MathBaseJustification.Center);
    }

    internal int method_48()
    {
        return (int) base.method_32(0x3c8c);
    }

    internal void method_49(int A_0)
    {
        base.SetAttr(0x3c8c, A_0, A_0 != 0);
    }

    internal MathSpacingRule method_50()
    {
        return (MathSpacingRule) base.method_32(0x3c82);
    }

    internal void method_51(MathSpacingRule A_0)
    {
        base.SetAttr(0x3c82, A_0, A_0 != MathSpacingRule.Single);
    }

    internal int method_52()
    {
        return (int) base.method_32(0x3c78);
    }

    internal void method_53(int A_0)
    {
        if (A_0 > 0x7bc0)
        {
            A_0 = 0x7bc0;
        }
        base.SetAttr(0x3c78, A_0, A_0 != 0);
    }

    internal bool method_54()
    {
        return (bool) base.method_32(0x3c6e);
    }

    internal void method_55(bool A_0)
    {
        base.SetAttr(0x3c6e, A_0, A_0);
    }

    internal MathSpacingRule method_56()
    {
        return (MathSpacingRule) base.method_32(0x3ba6);
    }

    internal void method_57(MathSpacingRule A_0)
    {
        base.SetAttr(0x3ba6, A_0, A_0 != MathSpacingRule.Single);
    }

    internal int method_58()
    {
        return (int) base.method_32(0x3b9c);
    }

    internal void method_59(int A_0)
    {
        base.SetAttr(0x3b9c, A_0, A_0 != 0);
    }

    internal Class461 method_60()
    {
        return this.class461_0;
    }

    AttrCollection AttrCollection.Clone()
    {
        Class19 class2 = (Class19) base.Clone();
        class2.class461_0 = this.class461_0.method_0();
        return class2;
    }

    internal override bool vmethod_0(DocumentObject A_0)
    {
        return ((A_0.DocumentObjectType == DocumentObjectType.OfficeMath) && (((Class5) A_0).method_32().vmethod_1() == MathObjectType.MatrixRow));
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.Matrix;
    }
}

