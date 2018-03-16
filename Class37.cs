using Spire.Doc.Fields.Caculation;
using System;

internal class Class37 : Class18
{
    internal MathPosition method_46()
    {
        return (MathPosition) base.method_32(0x3ab6);
    }

    internal void method_47(MathPosition A_0)
    {
        base.SetAttr(0x3ab6, A_0, A_0 != MathPosition.Bottom);
    }

    internal override MathObjectType vmethod_1()
    {
        return MathObjectType.Bar;
    }
}

