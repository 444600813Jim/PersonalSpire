using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;

internal class Class12 : Style
{
    private Class47 class47_0;
    internal int int_10;
    private int int_11;
    private int int_12;
    private int int_13;
    private int int_14;
    internal int int_9;

    internal Class12(Document A_0) : base(A_0)
    {
        this.class47_0 = new Class47(A_0);
        this.class47_0.method_0(this);
    }

    internal Class12(Document A_0, int A_1) : this(A_0)
    {
        this.int_13 = A_1;
    }

    internal Class47 method_23()
    {
        return this.class47_0;
    }

    internal int method_24()
    {
        return this.int_13;
    }

    internal void method_25(int A_0)
    {
        this.int_13 = A_0;
    }

    internal int method_26()
    {
        return this.int_14;
    }

    internal void method_27(int A_0)
    {
        this.int_14 = A_0;
    }

    internal void method_28()
    {
        if ((this.class47_0 != null) && (this.class47_0.Count != 0))
        {
            OverrideLevelFormat format = null;
            int count = this.class47_0.Count;
            foreach (KeyValuePair<int, int> pair in this.class47_0.method_7())
            {
                this.class47_0.method_5(pair.Key).method_5();
                format = null;
            }
        }
        else
        {
            this.class47_0 = null;
        }
    }

    internal ListLevel method_29(int A_0)
    {
        int num = 8;
        if (A_0 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䀭䔯弱嘳匵䨷", num), BookmarkStart.b("砭儯帱䄳匵ᠷ夹崻倽怿ⱁ⭃㉅桇⡉⥋湍㱏㝑❓╕硗⹙㑛㽝๟䉡呣", num));
        }
        if (A_0 > (this.class47_0.Count - 1))
        {
            A_0 = this.class47_0.Count - 1;
        }
        return this.class47_0.method_5(A_0).OverrideListLevel;
    }

    public override IStyle Spire.Doc.Documents.Style.Clone()
    {
        return (IStyle) this.CloneImpl();
    }

    object Style.CloneImpl()
    {
        Class12 class2 = (Class12) base.CloneImpl();
        class2.class47_0 = new Class47(base.Document);
        class2.class47_0.method_0(class2);
        this.class47_0.CloneToImpl(class2.class47_0);
        return class2;
    }

    void Style.InitXDLSHolder()
    {
        base.InitXDLSHolder();
        base.XDLSHolder.AddElement(BookmarkStart.b("䄭䘯圱䘳䐵儷帹夻ጽⰿ❁㉃⍅⑇㥉", 8), this.class47_0);
    }

    void Style.ReadXmlAttributes(IXDLSAttributeReader A_0)
    {
        int num = 14;
        base.ReadXmlAttributes(A_0);
        if (A_0.HasAttribute(BookmarkStart.b("昳匵䬷ହ", 14)))
        {
            this.int_9 = A_0.ReadInt(BookmarkStart.b("昳匵䬷ହ", num));
        }
        if (A_0.HasAttribute(BookmarkStart.b("昳匵䬷࠹", num)))
        {
            this.int_10 = A_0.ReadInt(BookmarkStart.b("昳匵䬷࠹", num));
        }
        if (A_0.HasAttribute(BookmarkStart.b("愳堵䴷䤹夻娽焿", num)))
        {
            this.int_11 = A_0.ReadInt(BookmarkStart.b("愳堵䴷䤹夻娽焿", num));
        }
        if (A_0.HasAttribute(BookmarkStart.b("愳堵䴷䤹夻娽爿", num)))
        {
            this.int_12 = A_0.ReadInt(BookmarkStart.b("愳堵䴷䤹夻娽爿", num));
        }
    }

    void Style.WriteXmlAttributes(IXDLSAttributeWriter A_0)
    {
        int num = 0x12;
        base.WriteXmlAttributes(A_0);
        if (this.int_9 != 0)
        {
            A_0.WriteValue(BookmarkStart.b("樷弹伻༽", num), this.int_9);
        }
        if (this.int_10 != 0)
        {
            A_0.WriteValue(BookmarkStart.b("樷弹伻ఽ", num), this.int_10);
        }
        if (this.int_11 != 0)
        {
            A_0.WriteValue(BookmarkStart.b("洷吹䤻䴽┿♁畃", num), this.int_11);
        }
        if (this.int_12 != 0)
        {
            A_0.WriteValue(BookmarkStart.b("洷吹䤻䴽┿♁癃", num), this.int_12);
        }
    }

    public override StyleType Spire.Doc.Interface.IStyle.StyleType
    {
        get
        {
            return StyleType.ListStyle;
        }
    }
}

