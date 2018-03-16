using Spire.Doc;
using System;
using System.Xml;

[CLSCompliant(false)]
internal class Class187
{
    private byte[] byte_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private string string_0;
    private string string_1;
    private string string_2;

    internal Class187()
    {
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal void method_1(int A_0)
    {
        this.int_0 = A_0;
    }

    internal string method_10()
    {
        return this.string_1;
    }

    internal void method_11(string A_0)
    {
        this.string_1 = A_0;
    }

    internal string method_12()
    {
        return this.string_2;
    }

    internal void method_13(string A_0)
    {
        this.string_2 = A_0;
    }

    internal byte[] method_14()
    {
        return this.byte_0;
    }

    internal void method_15(byte[] A_0)
    {
        this.byte_0 = A_0;
    }

    internal void method_16(XmlReader A_0)
    {
        this.int_0 = int.Parse(A_0.GetAttribute(BookmarkStart.b("䬷嬹倻䨽ጿ⭁㹃⍅", 0x12)));
        this.int_1 = int.Parse(A_0.GetAttribute(BookmarkStart.b("娷嘹医崽⬿ᅁⵃ㱅ⵇ", 0x12)));
        this.int_2 = int.Parse(A_0.GetAttribute(BookmarkStart.b("匷弹䔻簽⤿㙁㝃", 0x12)));
        this.int_3 = int.Parse(A_0.GetAttribute(BookmarkStart.b("倷嬹伻嘽ጿ⭁㹃⍅", 0x12)));
        this.string_0 = A_0.GetAttribute(BookmarkStart.b("嬷匹䰻嘽┿ぁՃ⩅⽇╉㹋❍⑏㩑㥓", 0x12));
        this.string_1 = A_0.GetAttribute(BookmarkStart.b("嬷匹䰻嘽┿ぁ݃⹅⥇⍉≋❍㹏㕑", 0x12));
        this.string_2 = A_0.GetAttribute(BookmarkStart.b("倷嬹伻嘽Ŀ⹁⍃⥅㩇⍉㡋♍㵏", 0x12));
        this.byte_0 = Convert.FromBase64String(A_0.GetAttribute(BookmarkStart.b("䬷嬹倻䨽ᘿ⍁⡃㍅ⵇ", 0x12)));
    }

    internal void method_17(XmlWriter A_0)
    {
        A_0.WriteStartElement(BookmarkStart.b("弳匵䄷縹崻䨽ℿ", 14));
        A_0.WriteAttributeString(BookmarkStart.b("䜳圵吷丹漻圽㨿❁", 14), this.int_0.ToString());
        A_0.WriteAttributeString(BookmarkStart.b("嘳娵圷夹圻洽⤿㡁⅃", 14), this.int_1.ToString());
        A_0.WriteAttributeString(BookmarkStart.b("弳匵䄷砹唻䨽㌿", 14), this.int_2.ToString());
        A_0.WriteAttributeString(BookmarkStart.b("尳圵䬷刹漻圽㨿❁", 14), this.int_3.ToString());
        A_0.WriteAttributeString(BookmarkStart.b("圳張䠷刹夻䰽Ŀ⹁⍃⥅㩇⍉㡋♍㵏", 14), this.string_0);
        A_0.WriteAttributeString(BookmarkStart.b("圳張䠷刹夻䰽̿⩁╃⽅♇⍉≋⥍", 14), this.string_1);
        A_0.WriteAttributeString(BookmarkStart.b("尳圵䬷刹紻刽✿ⵁ㙃⽅㱇≉⅋", 14), this.string_2);
        A_0.WriteAttributeString(BookmarkStart.b("䜳圵吷丹樻弽ⰿ㝁⅃", 14), Convert.ToBase64String(this.byte_0));
        A_0.WriteEndElement();
    }

    internal int method_2()
    {
        return this.int_1;
    }

    internal void method_3(int A_0)
    {
        this.int_1 = A_0;
    }

    internal int method_4()
    {
        return this.int_2;
    }

    internal void method_5(int A_0)
    {
        this.int_2 = A_0;
    }

    internal int method_6()
    {
        return this.int_3;
    }

    internal void method_7(int A_0)
    {
        this.int_3 = A_0;
    }

    internal string method_8()
    {
        return this.string_0;
    }

    internal void method_9(string A_0)
    {
        this.string_0 = A_0;
    }
}

