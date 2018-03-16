using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;

internal class Form4 : FormatBase, IDisposable
{
    private Class815 class815_0;
    internal const int int_7 = 10;
    internal const int int_8 = 0x18;
    internal const short short_0 = 0;
    internal const short short_1 = 1;
    internal const short short_2 = 2;
    internal const short short_3 = 3;
    internal const short short_4 = 4;
    internal const short short_5 = 5;
    internal const short short_6 = 6;
    internal const short short_7 = 7;
    internal const short short_8 = 8;

    internal Form4()
    {
    }

    public Form4(IDocument A_0) : base(A_0)
    {
    }

    public Form4(IDocument A_0, string A_1) : this(A_0)
    {
        int num = 10;
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("嘯崱娳䈵瘷嬹儻嬽", num));
        }
        base[0] = A_1;
    }

    public string method_31()
    {
        return (string) base[0];
    }

    public void method_32(string A_0)
    {
        base[0] = A_0;
        base.SetPropUpdateFlag(0);
    }

    public string method_33()
    {
        return (string) base[1];
    }

    public void method_34(string A_0)
    {
        base[1] = A_0;
        base.SetPropUpdateFlag(1);
    }

    public byte[] method_35()
    {
        return (byte[]) base[2];
    }

    public void method_36(byte[] A_0)
    {
        int num = 8;
        if ((A_0 != null) && (A_0.Length != 10))
        {
            throw new ArgumentException(BookmarkStart.b("札帯儱嬳䐵䨷弹弻䨽怿⍁㙃㑅⥇㍉汋≍㕏㱑㍓≕し瑙", num));
        }
        base[2] = A_0;
        base.SetPropUpdateFlag(2);
    }

    public int method_37()
    {
        return (int) base[3];
    }

    public void method_38(int A_0)
    {
        base[3] = A_0;
        base.SetPropUpdateFlag(3);
    }

    public FontFamily method_39()
    {
        return (FontFamily) base[4];
    }

    public void method_40(FontFamily A_0)
    {
        base[4] = A_0;
        base.SetPropUpdateFlag(4);
    }

    public FontPitch method_41()
    {
        return (FontPitch) base[5];
    }

    public void method_42(FontPitch A_0)
    {
        base[5] = A_0;
        base.SetPropUpdateFlag(5);
    }

    public bool method_43()
    {
        return (bool) base[7];
    }

    public void method_44(bool A_0)
    {
        base[7] = A_0;
        base.SetPropUpdateFlag(7);
    }

    public byte[] method_45()
    {
        return (byte[]) base[6];
    }

    public void method_46(byte[] A_0)
    {
        int num = 6;
        if ((A_0 != null) && (A_0.Length != 0x18))
        {
            throw new ArgumentException(BookmarkStart.b("攫䀭匯崱䘳䐵崷夹䠻ḽℿぁ㙃❅ㅇ橉⁋⭍㹏㕑⁓㹕癗", num));
        }
        base[6] = A_0;
        base.SetPropUpdateFlag(6);
    }

    public int method_47()
    {
        return (int) base[8];
    }

    public void method_48(int A_0)
    {
        base[8] = A_0;
        base.SetPropUpdateFlag(8);
    }

    public Class815 method_49()
    {
        return this.class815_0;
    }

    internal List<string> method_50()
    {
        List<string> list = new List<string>();
        foreach (string str2 in this.method_33().Split(new char[] { ',' }))
        {
            string str3 = str2.Trim(new char[] { ' ' });
            if (!string.IsNullOrEmpty(str3))
            {
                list.Add(str3);
            }
        }
        return list;
    }

    internal void method_51(Form4 A_0)
    {
        this.method_58(A_0);
        if (A_0.class815_0 != null)
        {
            if (this.class815_0 == null)
            {
                this.class815_0 = new Class815();
            }
            this.class815_0.method_1(A_0.class815_0);
        }
    }

    internal Class827[] method_52(EmbeddedFontFormat A_0)
    {
        if (this.class815_0 != null)
        {
            return this.class815_0.method_2(A_0);
        }
        return null;
    }

    internal Class827[] method_53()
    {
        if (this.class815_0 != null)
        {
            return this.class815_0.method_3();
        }
        return null;
    }

    internal byte[] method_54(EmbeddedFontFormat A_0, EmbeddedFontStyle A_1)
    {
        if (this.class815_0 != null)
        {
            Class827 class2 = this.class815_0.method_4(A_0, A_1);
            if (class2 != null)
            {
                return class2.method_0();
            }
        }
        return null;
    }

    internal Class827 method_55(EmbeddedFontStyle A_0)
    {
        if (this.class815_0 != null)
        {
            Class827 class2 = this.class815_0.method_4(EmbeddedFontFormat.OpenType, A_0);
            if ((class2 != null) && (class2.method_0() != null))
            {
                return class2;
            }
            class2 = this.class815_0.method_4(EmbeddedFontFormat.EmbeddedOpenType, A_0);
            if ((class2 != null) && (class2.method_0() != null))
            {
                return class2;
            }
        }
        return null;
    }

    internal void method_56(byte[] A_0, EmbeddedFontFormat A_1, EmbeddedFontStyle A_2, bool A_3)
    {
        if (this.class815_0 == null)
        {
            this.class815_0 = new Class815();
        }
        this.class815_0.method_5(new Class827(A_0, A_1, A_2, A_3));
    }

    internal void method_57(string A_0)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䄮倰帲倴", num));
        }
        this.method_32(A_0);
    }

    private void method_58(Form4 A_0)
    {
        if (!this.HasValue(5))
        {
            base[5] = A_0.method_41();
        }
        if (!this.HasValue(1))
        {
            base[1] = A_0.method_33();
        }
        if (!this.HasValue(4))
        {
            base[4] = A_0.method_39();
        }
        if (!this.HasValue(8))
        {
            base[8] = A_0.method_47();
        }
        if (!this.HasValue(7) && this.method_43())
        {
            base[7] = A_0.method_43();
        }
        if (!this.HasValue(3))
        {
            base[3] = A_0.method_37();
        }
        if (!this.HasValue(2))
        {
            base[2] = A_0.method_35();
        }
        if (!this.HasValue(6))
        {
            base[6] = A_0.method_45();
        }
    }

    public Form4 method_59()
    {
        Form4 form = (Form4) base.CloneImpl();
        form.method_21(this);
        if (this.class815_0 != null)
        {
            form.class815_0 = this.class815_0.method_0();
        }
        return form;
    }

    object FormatBase.GetDefValue(int A_0)
    {
        int num = 9;
        switch (A_0)
        {
            case 0:
            case 1:
                return string.Empty;

            case 2:
                return new byte[10];

            case 3:
            case 8:
                return 0;

            case 4:
                return FontFamily.Auto;

            case 5:
                return FontPitch.Default;

            case 6:
                return new byte[0x18];

            case 7:
                return true;
        }
        throw new ArgumentException(BookmarkStart.b("䐮吰䨲ᔴ弶堸䠺ᴼ嘾⽀㕂⑄⭆⁈⽊浌㥎ぐ㽒⁔㉖", num));
    }

    void IDisposable.Dispose()
    {
        base.Close();
    }
}

