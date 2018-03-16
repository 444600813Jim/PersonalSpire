using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;

internal class Class700
{
    private readonly Class151 class151_0;
    private readonly Class161 class161_0;
    private readonly FootnoteType footnoteType_0;

    internal Class700(FootnoteType A_0)
    {
        this.footnoteType_0 = A_0;
        this.class161_0 = new Class161();
        this.class151_0 = new Class151();
    }

    internal Class700(FootnoteType A_0, Class703 A_1, BinaryReader A_2) : this(A_0)
    {
        bool flag = A_0 == FootnoteType.Footnote;
        this.class161_0.method_23(A_2, flag ? A_1.class597_0.class1111_2 : A_1.class597_0.class1111_46);
        this.class151_0.method_23(A_2, flag ? A_1.class597_0.class1111_3 : A_1.class597_0.class1111_47);
    }

    internal void method_0(Class703 A_0, BinaryWriter A_1)
    {
        int num = 13;
        int position = (int) A_1.BaseStream.Position;
        int num3 = this.class161_0.vmethod_1(A_1);
        Class1111 class2 = new Class1111(position, num3);
        position = (int) A_1.BaseStream.Position;
        num3 = this.class151_0.vmethod_1(A_1);
        Class1111 class3 = new Class1111(position, num3);
        switch (this.footnoteType_0)
        {
            case FootnoteType.Footnote:
                A_0.class597_0.class1111_2 = class2;
                A_0.class597_0.class1111_3 = class3;
                return;

            case FootnoteType.Endnote:
                A_0.class597_0.class1111_46 = class2;
                A_0.class597_0.class1111_47 = class3;
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("昲嬴尶圸吺䨼儾慀╂⩄⡆㵈╊≌㭎㑐絒", num));
    }

    internal Class762 method_1(int A_0)
    {
        int num = this.class161_0.method_12(A_0);
        if (num < 0)
        {
            return null;
        }
        return new Class762(this.class151_0.method_16(num), this.class151_0.method_16(num + 1), this.class161_0.method_25(num).bool_0);
    }

    internal void method_2(int A_0, bool A_1)
    {
        Class1059 class2 = new Class1059 {
            bool_0 = A_1
        };
        this.class161_0.method_6(A_0, class2);
    }

    internal void method_3(int A_0)
    {
        this.class151_0.method_6(A_0, null);
    }

    internal void method_4(int A_0)
    {
        this.class151_0.method_8(A_0);
    }

    internal FootnoteType method_5()
    {
        return this.footnoteType_0;
    }

    internal Class161 method_6()
    {
        return this.class161_0;
    }

    internal Class151 method_7()
    {
        return this.class151_0;
    }

    internal static SubDocumentType smethod_0(FootnoteType A_0)
    {
        if (A_0 != FootnoteType.Footnote)
        {
            return SubDocumentType.Endnote;
        }
        return SubDocumentType.Footnote;
    }
}

