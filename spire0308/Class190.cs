using Spire.Doc;
using System;
using System.Xml;

[CLSCompliant(false)]
internal class Class190
{
    private byte[] byte_0;
    private byte[] byte_1;
    private byte[] byte_2;
    private byte[] byte_3;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private int int_4;
    private string string_0;
    private string string_1;
    private string string_2;

    internal Class190()
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
        return this.string_0;
    }

    internal void method_11(string A_0)
    {
        this.string_0 = A_0;
    }

    internal string method_12()
    {
        return this.string_1;
    }

    internal void method_13(string A_0)
    {
        this.string_1 = A_0;
    }

    internal string method_14()
    {
        return this.string_2;
    }

    internal void method_15(string A_0)
    {
        this.string_2 = A_0;
    }

    internal byte[] method_16()
    {
        return this.byte_0;
    }

    internal void method_17(byte[] A_0)
    {
        this.byte_0 = A_0;
    }

    internal byte[] method_18()
    {
        return this.byte_1;
    }

    internal void method_19(byte[] A_0)
    {
        this.byte_1 = A_0;
    }

    internal int method_2()
    {
        return this.int_1;
    }

    internal byte[] method_20()
    {
        return this.byte_2;
    }

    internal void method_21(byte[] A_0)
    {
        this.byte_2 = A_0;
    }

    internal byte[] method_22()
    {
        return this.byte_3;
    }

    internal void method_23(byte[] A_0)
    {
        this.byte_3 = A_0;
    }

    internal void method_24(XmlReader A_0)
    {
        this.int_0 = int.Parse(A_0.GetAttribute(BookmarkStart.b("䐶䤸刺匼簾⹀㙂⭄㍆", 0x11)));
        this.int_1 = int.Parse(A_0.GetAttribute(BookmarkStart.b("䐶堸场䤼氾⡀㥂⁄", 0x11)));
        this.int_2 = int.Parse(A_0.GetAttribute(BookmarkStart.b("唶唸吺帼吾ቀ⩂㽄≆", 0x11)));
        this.int_3 = int.Parse(A_0.GetAttribute(BookmarkStart.b("尶尸䈺缼嘾㕀あ", 0x11)));
        this.int_4 = int.Parse(A_0.GetAttribute(BookmarkStart.b("弶堸䠺唼氾⡀㥂⁄", 0x11)));
        this.string_0 = A_0.GetAttribute(BookmarkStart.b("吶倸䬺唼娾㍀ɂ⥄⁆♈㥊⑌㭎㥐㹒", 0x11));
        this.string_1 = A_0.GetAttribute(BookmarkStart.b("吶倸䬺唼娾㍀Bⵄ♆⁈╊⑌ⅎ㙐", 0x11));
        this.string_2 = A_0.GetAttribute(BookmarkStart.b("弶堸䠺唼績ⵀ⑂⩄㕆⁈㽊╌≎", 0x11));
        this.byte_0 = Convert.FromBase64String(A_0.GetAttribute(BookmarkStart.b("䐶堸场䤼椾⁀⽂い≆", 0x11)));
        this.byte_1 = Convert.FromBase64String(A_0.GetAttribute(BookmarkStart.b("制圸堺似䘾ㅀ㝂⁄⍆Ὀ⹊㽌♎㝐㩒ご╖ᅘ㩚⹜㝞⡠ൢᕤቦᵨ", 0x11)));
        this.byte_2 = Convert.FromBase64String(A_0.GetAttribute(BookmarkStart.b("制圸堺似䘾ㅀ㝂⁄⍆Ὀ⹊㽌♎㝐㩒ご╖ᅘ㩚⹜㝞㝠ɢ।ቦ౨", 0x11)));
        this.byte_3 = Convert.FromBase64String(A_0.GetAttribute(BookmarkStart.b("制圸堺似䘾ㅀ㝂⁄⍆Ɉ⹊㑌᥎ぐ㽒⁔㉖", 0x11)));
    }

    internal void method_25(XmlWriter A_0)
    {
        A_0.WriteStartElement(BookmarkStart.b("䠷", 0x12), BookmarkStart.b("崷吹弻䰽㤿㉁ぃ⍅ⱇŉ⥋㝍", 0x12), BookmarkStart.b("倷丹䠻丽稿流歃㕅⭇≉⥋⍍ㅏ⅑穓㭕ㅗ㥙⹛ㅝ፟ൡɣብ䙧३ͫͭ彯ᵱታၵᅷ᥹᥻兽뉿늁뒃낅ꞇ햏ﲑ튟趡풣장\udba7\ud9a9\udbab\uc1ad슯횱", 0x12));
        A_0.WriteAttributeString(BookmarkStart.b("䬷䨹唻倽̿ⵁㅃ⡅㱇", 0x12), this.int_0.ToString());
        A_0.WriteAttributeString(BookmarkStart.b("䬷嬹倻䨽ጿ⭁㹃⍅", 0x12), this.int_1.ToString());
        A_0.WriteAttributeString(BookmarkStart.b("娷嘹医崽⬿ᅁⵃ㱅ⵇ", 0x12), this.int_2.ToString());
        A_0.WriteAttributeString(BookmarkStart.b("匷弹䔻簽⤿㙁㝃", 0x12), this.int_3.ToString());
        A_0.WriteAttributeString(BookmarkStart.b("倷嬹伻嘽ጿ⭁㹃⍅", 0x12), this.int_4.ToString());
        A_0.WriteAttributeString(BookmarkStart.b("嬷匹䰻嘽┿ぁՃ⩅⽇╉㹋❍⑏㩑㥓", 0x12), this.string_0);
        A_0.WriteAttributeString(BookmarkStart.b("嬷匹䰻嘽┿ぁ݃⹅⥇⍉≋❍㹏㕑", 0x12), this.string_1);
        A_0.WriteAttributeString(BookmarkStart.b("倷嬹伻嘽Ŀ⹁⍃⥅㩇⍉㡋♍㵏", 0x12), this.string_2);
        A_0.WriteAttributeString(BookmarkStart.b("䬷嬹倻䨽ᘿ⍁⡃㍅ⵇ", 0x12), Convert.ToBase64String(this.byte_0));
        A_0.WriteAttributeString(BookmarkStart.b("崷吹弻䰽㤿㉁ぃ⍅ⱇ᱉⥋㱍㥏㑑㵓㍕⩗቙㵛ⵝ࡟⭡੣ᙥᵧṩ", 0x12), Convert.ToBase64String(this.byte_1));
        A_0.WriteAttributeString(BookmarkStart.b("崷吹弻䰽㤿㉁ぃ⍅ⱇ᱉⥋㱍㥏㑑㵓㍕⩗቙㵛ⵝ࡟㑡գ੥ᵧཀྵ", 0x12), Convert.ToBase64String(this.byte_2));
        A_0.WriteAttributeString(BookmarkStart.b("崷吹弻䰽㤿㉁ぃ⍅ⱇŉ⥋㝍ُ㍑㡓⍕㵗", 0x12), Convert.ToBase64String(this.byte_3));
        A_0.WriteEndElement();
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

    internal int method_8()
    {
        return this.int_4;
    }

    internal void method_9(int A_0)
    {
        this.int_4 = A_0;
    }
}

