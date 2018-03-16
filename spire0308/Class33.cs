using Spire.Doc.Fields.Caculation;
using System;

internal class Class33 : Class18
{
    internal MathBaseJustification method_46()
    {
        return (MathBaseJustification) base.method_32(0x3b7e);
    }

    internal void method_47(MathBaseJustification A_0)
    {
        base.SetAttr(0x3b7e, A_0, A_0 != MathBaseJustification.Center);
    }

    internal bool method_48()
    {
        return (bool) base.method_32(0x3b88);
    }

    internal void method_49(bool A_0)
    {
        base.SetAttr(0x3b88, A_0, A_0);
    }

    internal bool method_50()
    {
        return (bool) base.method_32(0x3b92);
    }

    internal void method_51(bool A_0)
    {
        base.SetAttr(0x3b92, A_0, A_0);
    }

    internal MathSpacingRule method_52()
    {
        return (MathSpacingRule) base.method_32(0x3ba6);
    }

    internal void method_53(MathSpacingRule A_0)
    {
        base.SetAttr(0x3ba6, A_0, A_0 != MathSpacingRule.Single);
    }

    internal int method_54()
    {
        return (int) base.method_32(0x3b9c);
    }

    internal void method_55(int A_0)
    {
        base.SetAttr(0x3b9c, A_0, A_0 != 0);
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.Array;
    }
}

