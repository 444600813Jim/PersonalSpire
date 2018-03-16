using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Interface;
using System;

internal class Class3 : Field
{
    protected internal bool bool_35;
    protected internal int int_6;

    internal Class3(IDocument A_0) : base(A_0)
    {
        base.m_paraItemType = ParagraphItemType.EmbedField;
    }

    internal int method_235()
    {
        return this.int_6;
    }

    internal void method_236(int A_0)
    {
        this.int_6 = A_0;
    }

    internal bool method_237()
    {
        return this.bool_35;
    }

    internal void method_238(bool A_0)
    {
        this.bool_35 = A_0;
    }

    object Field.CloneImpl()
    {
        return (Class3) base.CloneImpl();
    }

    void Field.ReadXmlAttributes(IXDLSAttributeReader A_0)
    {
        int num = 0x12;
        base.ReadXmlAttributes(A_0);
        if (A_0.HasAttribute(BookmarkStart.b("欷丹医䰽ℿ╁⅃ᙅⅇ⥉K⅍㍏㍑⁓㽕㝗㑙", 0x12)))
        {
            this.int_6 = A_0.ReadInt(BookmarkStart.b("欷丹医䰽ℿ╁⅃ᙅⅇ⥉K⅍㍏㍑⁓㽕㝗㑙", num));
            this.bool_35 = A_0.ReadBoolean(BookmarkStart.b("眷嘹夻ఽ༿⁁⹃⍅⭇㹉", num));
        }
    }

    void Field.WriteXmlAttributes(IXDLSAttributeWriter A_0)
    {
        int num = 7;
        base.WriteXmlAttributes(A_0);
        if (this.int_6 > 0)
        {
            A_0.WriteValue(BookmarkStart.b("縬嬮帰䄲吴倶尸欺吼尾ീⱂ♄♆㵈≊≌ⅎ", num), this.int_6);
            A_0.WriteValue(BookmarkStart.b("戬䌮吰Ĳ稴唶匸帺帼䬾", num), this.bool_35);
        }
    }

    void TextRange.InitXDLSHolder()
    {
        base.InitXDLSHolder();
    }

    public override DocumentObjectType Spire.Doc.Fields.Field.DocumentObjectType
    {
        get
        {
            return DocumentObjectType.EmbededField;
        }
    }
}

