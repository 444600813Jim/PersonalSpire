using Spire.Doc.Fields.Caculation;
using System;

internal class Class24 : Class18
{
    internal bool method_46()
    {
        return (bool) base.method_32(0x3b24);
    }

    internal void method_47(bool A_0)
    {
        base.SetAttr(0x3b24, A_0, A_0);
    }

    internal Class828 method_48()
    {
        return (Class828) base.method_32(0x3b2e);
    }

    internal void method_49(Class828 A_0)
    {
        base.SetAttr(0x3b2e, A_0, A_0 != null);
    }

    internal bool method_50()
    {
        return (bool) base.method_32(0x3b42);
    }

    internal void method_51(bool A_0)
    {
        base.SetAttr(0x3b42, A_0, A_0);
    }

    internal bool method_52()
    {
        return (bool) base.method_32(0x3b38);
    }

    internal void method_53(bool A_0)
    {
        base.SetAttr(0x3b38, A_0, A_0);
    }

    internal bool method_54()
    {
        return (bool) base.method_32(0x3b1a);
    }

    internal void method_55(bool A_0)
    {
        base.SetAttr(0x3b1a, A_0, A_0);
        if (!A_0)
        {
            base.SetAttr(0x3b24, false, false);
        }
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.Box;
    }
}

