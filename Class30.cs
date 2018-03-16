using Spire.Doc.Fields.Caculation;
using System;

internal class Class30 : Class18
{
    internal const char char_1 = '(';
    internal const char char_2 = ')';
    internal const char char_3 = '│';

    internal char method_46()
    {
        return (char) base.method_32(0x3b4c);
    }

    internal void method_47(char A_0)
    {
        base.SetAttr(0x3b4c, A_0, A_0 != '(');
    }

    internal char method_48()
    {
        return (char) base.method_32(0x3b56);
    }

    internal void method_49(char A_0)
    {
        base.SetAttr(0x3b56, A_0, A_0 != ')');
    }

    internal char method_50()
    {
        return (char) base.method_32(0x3b60);
    }

    internal void method_51(char A_0)
    {
        base.SetAttr(0x3b60, A_0, A_0 != '│');
    }

    internal bool method_52()
    {
        return (bool) base.method_32(0x3b6a);
    }

    internal void method_53(bool A_0)
    {
        base.SetAttr(0x3b6a, A_0, A_0);
    }

    internal MathDelimiterShape method_54()
    {
        return (MathDelimiterShape) base.method_32(0x3b74);
    }

    internal void method_55(MathDelimiterShape A_0)
    {
        base.SetAttr(0x3b74, A_0, A_0 != MathDelimiterShape.Centered);
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.Delimiter;
    }
}

