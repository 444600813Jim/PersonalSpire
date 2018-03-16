using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Caculation;
using System;

internal class Class41 : Class18
{
    internal const char char_1 = '∫';

    internal char method_46()
    {
        return (char) base.method_32(0x3ac5);
    }

    internal void method_47(char A_0)
    {
        base.SetAttr(0x3ac5, A_0, A_0 != '∫');
    }

    internal bool method_48()
    {
        return (bool) base.method_32(0x3b6a);
    }

    internal void method_49(bool A_0)
    {
        base.SetAttr(0x3b6a, A_0, A_0);
    }

    internal MathLimitLocation method_50()
    {
        return (MathLimitLocation) base.method_32(0x3c96);
    }

    internal void method_51(MathLimitLocation A_0)
    {
        base.SetAttr(0x3c96, A_0, A_0 != MathLimitLocation.Undefined);
    }

    internal bool method_52()
    {
        return (bool) base.method_32(0x3ca0);
    }

    internal void method_53(bool A_0)
    {
        base.SetAttr(0x3ca0, A_0, A_0);
    }

    internal bool method_54()
    {
        return (bool) base.method_32(0x3caa);
    }

    internal void method_55(bool A_0)
    {
        base.SetAttr(0x3caa, A_0, A_0);
    }

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
        return MathObjectType.NAry;
    }
}

