using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Drawing;

internal class Form3 : CellFormat
{
    internal Form3(IDocument A_0)
    {
    }

    internal Color method_60()
    {
        return base.Shading.method_56();
    }

    internal void method_61(Color A_0)
    {
        base.Shading.method_57(A_0);
    }

    internal Color method_62()
    {
        return base.Shading.method_60();
    }

    internal void method_63(Color A_0)
    {
        base.Shading.method_61(A_0);
    }

    internal TextureStyle method_64()
    {
        return base.Shading.method_62();
    }

    internal void method_65(TextureStyle A_0)
    {
        base.Shading.method_63(A_0);
    }

    internal Borders method_66()
    {
        return (this.method_72(1) as Borders);
    }

    internal Paddings method_67()
    {
        return (this.method_72(2) as Paddings);
    }

    internal VerticalAlignment method_68()
    {
        return (VerticalAlignment) this.method_72(0xbf4);
    }

    internal void method_69(VerticalAlignment A_0)
    {
        this.method_73(0xbf4, A_0);
    }

    internal bool method_70()
    {
        return (bool) base[0xc6c];
    }

    internal void method_71(bool A_0)
    {
        base[0xc6c] = A_0;
    }

    internal object method_72(int A_0)
    {
        this.method_74(A_0);
        return base[A_0];
    }

    internal void method_73(int A_0, object A_1)
    {
        base[A_0] = A_1;
    }

    internal void method_74(int A_0)
    {
        base.IsPropertyUpdated(A_0);
    }

    bool CellFormat.HasValue(int A_0)
    {
        return base.HasKey(A_0);
    }
}

