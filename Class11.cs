using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Interface;
using System;

internal class Class11 : Style
{
    internal Class11(Document A_0) : base(A_0)
    {
    }

    public Class11 method_23()
    {
        return (base.BaseStyle as Class11);
    }

    public override IStyle Spire.Doc.Interface.IStyle.Clone()
    {
        return (IStyle) this.CloneImpl();
    }

    public override StyleType Spire.Doc.Interface.IStyle.StyleType
    {
        get
        {
            return StyleType.CharacterStyle;
        }
    }
}

