using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using System;
using System.IO;
using System.Text;

internal class Class287 : Class266
{
    private readonly Class657 class657_0;

    internal Class287() : this(false)
    {
    }

    internal Class287(bool A_0) : base(A_0 ? EscherRecordType.ShapeOptionsEx : EscherRecordType.ShapeOptions, 3)
    {
        this.class657_0 = new Class657();
    }

    internal Class657 method_4()
    {
        return this.class657_0;
    }

    public override string System.Object.ToString()
    {
        int num = 11;
        StringBuilder builder = new StringBuilder();
        builder.Append(base.System.Object.ToString());
        builder.Append(BookmarkStart.b("㰰㤲", 11));
        for (int i = 0; i < this.class657_0.method_2(); i++)
        {
            Class171 class2 = (Class171) this.class657_0.method_3(this.class657_0.method_13(i));
            builder.AppendFormat(BookmarkStart.b("ᄰጲԴ伶䈸଺ܼ䜾畀㹂罄睆ㅈお籌畎⥐⹒祔睖≘楚⁜", num), class2.method_0(), class2.vmethod_1(), class2.vmethod_0() ? BookmarkStart.b("到尲場䜶唸帺䔼", num) : BookmarkStart.b("䈰娲場䜶唸帺", num));
            switch (class2.method_0())
            {
                case 0x1ff:
                    builder.AppendFormat(BookmarkStart.b("ᄰᬲ临ܶ䐸ሺ", num), (EscherLineFlags) class2.vmethod_1());
                    break;

                case 0x33f:
                    builder.AppendFormat(BookmarkStart.b("ᄰᬲ临ܶ䐸ሺ", num), (EscherShapeFlags) class2.vmethod_1());
                    break;

                case 0x3bf:
                    builder.AppendFormat(BookmarkStart.b("ᄰᬲ临ܶ䐸ሺ", num), (EscherGroupShapeFlags) class2.vmethod_1());
                    break;
            }
            builder.Append(BookmarkStart.b("㰰㤲", num));
        }
        return builder.ToString();
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        this.class657_0.method_6();
        this.class657_0.method_26(A_0, base.method_3().method_6());
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        base.method_3().method_7(this.class657_0.method_2());
        this.class657_0.method_27(A_0);
    }
}

