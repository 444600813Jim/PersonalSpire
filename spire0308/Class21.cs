using Spire.Doc.Fields.Caculation;
using System;

internal class Class21 : Class18
{
    internal const char char_1 = '⏟';

    internal char method_46()
    {
        return (char) base.method_32(0x3bb0);
    }

    internal void method_47(char A_0)
    {
        base.SetAttr(0x3bb0, A_0, A_0 != '⏟');
    }

    internal MathPosition method_48()
    {
        return (MathPosition) base.method_32(0x3bba);
    }

    internal void method_49(MathPosition A_0)
    {
        base.SetAttr(0x3bba, A_0, A_0 != MathPosition.Bottom);
    }

    internal MathVerticalJustification method_50()
    {
        return (MathVerticalJustification) base.method_32(0x3bc4);
    }

    internal void method_51(MathVerticalJustification A_0)
    {
        base.SetAttr(0x3bc4, A_0, A_0 != MathVerticalJustification.Top);
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.GroupCharacter;
    }
}

