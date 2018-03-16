using Spire.Doc.Fields.Caculation;
using System;

internal class Class35 : Class18
{
    internal const char char_1 = '̂';

    internal char method_46()
    {
        return (char) base.method_32(0x3ac0);
    }

    internal void method_47(char A_0)
    {
        char ch = smethod_6(A_0);
        base.SetAttr(0x3ac0, ch, ch != '̂');
    }

    private static char smethod_6(char A_0)
    {
        if (A_0 < '̀')
        {
            return '̀';
        }
        if ((A_0 > 'ͯ') && (A_0 < '⃐'))
        {
            return ((A_0 < 'ሟ') ? 'ͯ' : '⃐');
        }
        if (A_0 > '⃯')
        {
            return '⃯';
        }
        return A_0;
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.Accent;
    }
}

