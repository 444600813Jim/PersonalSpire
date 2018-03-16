using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;

internal class Form1 : RowFormat
{
    internal Form1(IDocument A_0) : base(A_0)
    {
    }

    internal bool method_65()
    {
        return (bool) this.method_76(0x11a8);
    }

    internal void method_66(bool A_0)
    {
        this.method_77(0x11a8, A_0);
    }

    internal bool method_67()
    {
        return (bool) this.method_76(0xfc8);
    }

    internal void method_68(bool A_0)
    {
        this.method_77(0xfc8, A_0);
    }

    internal bool method_69()
    {
        return (bool) this.method_76(0x1108);
    }

    internal void method_70(bool A_0)
    {
        this.method_77(0x1108, A_0);
    }

    internal float method_71()
    {
        return (float) this.method_76(0x10c2);
    }

    internal void method_72(float A_0)
    {
        this.method_77(0x10c2, A_0);
    }

    internal RowAlignment method_73()
    {
        return (RowAlignment) this.method_76(0xfaa);
    }

    internal void method_74(RowAlignment A_0)
    {
        this.method_77(0xfaa, A_0);
    }

    internal FormatBase method_75()
    {
        RowFormat format = new RowFormat(base.Document);
        format.method_24(this);
        if (base.BaseFormat != null)
        {
            format.ApplyBase((base.BaseFormat as Form1).method_75());
        }
        return format;
    }

    internal object method_76(int A_0)
    {
        this.method_78(A_0);
        return base[A_0];
    }

    internal void method_77(int A_0, object A_1)
    {
        base[A_0] = A_1;
    }

    internal void method_78(int A_0)
    {
        base.IsPropertyUpdated(A_0);
    }

    bool RowFormat.HasValue(int A_0)
    {
        return base.HasKey(A_0);
    }
}

