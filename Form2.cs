using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Drawing;

internal class Form2 : RowFormat
{
    internal Form2(IDocument A_0) : base(A_0)
    {
    }

    internal Color method_65()
    {
        return this.method_71().method_56();
    }

    internal void method_66(Color A_0)
    {
        this.method_71().method_57(A_0);
    }

    internal Color method_67()
    {
        return this.method_71().method_60();
    }

    internal void method_68(Color A_0)
    {
        this.method_71().method_61(A_0);
    }

    internal TextureStyle method_69()
    {
        return this.method_71().method_62();
    }

    internal void method_70(TextureStyle A_0)
    {
        this.method_71().method_63(A_0);
    }

    internal Class16 method_71()
    {
        return (Class16) this.method_85(0x10ea);
    }

    internal Borders method_72()
    {
        return (this.method_85(1) as Borders);
    }

    internal Paddings method_73()
    {
        return (this.method_85(3) as Paddings);
    }

    internal float method_74()
    {
        return (float) this.method_85(0x10c2);
    }

    internal void method_75(float A_0)
    {
        this.method_86(0x10c2, A_0);
    }

    internal float method_76()
    {
        return (float) this.method_85(0x10f4);
    }

    internal void method_77(float A_0)
    {
        this.method_86(0x10f4, A_0);
    }

    internal RowAlignment method_78()
    {
        return (RowAlignment) this.method_85(0xfaa);
    }

    internal void method_79(RowAlignment A_0)
    {
        this.method_86(0xfaa, A_0);
    }

    internal long method_80()
    {
        return (long) this.method_85(0x119e);
    }

    internal void method_81(long A_0)
    {
        this.method_86(0x119e, A_0);
    }

    internal long method_82()
    {
        return (long) this.method_85(0x1194);
    }

    internal void method_83(long A_0)
    {
        this.method_86(0x1194, A_0);
    }

    internal FormatBase method_84()
    {
        RowFormat format = new RowFormat(base.Document);
        format.method_24(this);
        if (base.BaseFormat != null)
        {
            format.ApplyBase((base.BaseFormat as Form2).method_84());
        }
        return format;
    }

    internal object method_85(int A_0)
    {
        this.method_87(A_0);
        return base[A_0];
    }

    internal void method_86(int A_0, object A_1)
    {
        base[A_0] = A_1;
    }

    internal void method_87(int A_0)
    {
        base.IsPropertyUpdated(A_0);
    }

    bool RowFormat.HasValue(int A_0)
    {
        return base.HasKey(A_0);
    }
}

