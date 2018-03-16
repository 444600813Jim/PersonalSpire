using Spire.Doc;
using System;
using System.IO;
using System.Xml;

[CLSCompliant(false)]
internal class Class186
{
    private Class187 class187_0 = new Class187();
    private Class188 class188_0 = new Class188();
    private Class189 class189_0 = new Class189();
    private const string string_0 = "xmlns";

    internal Class187 method_0()
    {
        return this.class187_0;
    }

    internal void method_1(Class187 A_0)
    {
        this.class187_0 = A_0;
    }

    internal Class188 method_2()
    {
        return this.class188_0;
    }

    internal void method_3(Class188 A_0)
    {
        this.class188_0 = A_0;
    }

    internal Class189 method_4()
    {
        return this.class189_0;
    }

    internal void method_5(Class189 A_0)
    {
        this.class189_0 = A_0;
    }

    public void method_6(Stream A_0)
    {
        int num = 6;
        XmlReader reader = this.method_9(A_0);
        reader.Read();
        while (reader.LocalName != BookmarkStart.b("䤫䀭匯䀱䴳䘵䰷匹医倽", num))
        {
            if (reader.NodeType == XmlNodeType.Element)
            {
                string localName = reader.LocalName;
                if (localName != null)
                {
                    if (localName != BookmarkStart.b("䜫䬭䤯瘱唳䈵夷", num))
                    {
                        if (!(localName == BookmarkStart.b("䠫伭䐯匱紳堵䰷弹嬻䰽⤿㙁㵃", num)))
                        {
                            if (localName == BookmarkStart.b("䜫䬭䤯眱娳唵䨷䌹䰻䨽⼿ぁ㝃", num))
                            {
                                this.class189_0.method_1(reader);
                            }
                        }
                        else
                        {
                            this.class188_0.method_4(reader);
                        }
                    }
                    else
                    {
                        this.class187_0.method_16(reader);
                    }
                }
                reader.Read();
            }
            else
            {
                reader.Read();
            }
        }
    }

    public void method_7(Stream A_0)
    {
        int num = 10;
        XmlWriter writer = this.method_8(A_0);
        writer.WriteStartElement(BookmarkStart.b("唯就圳䐵䄷䨹䠻圽⼿ⱁ", 10), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧թ੫࡭᥯ᅱᅳ奵䩷䩹䱻䡽꽿慎ﲋ揄憐﶑望", 10));
        writer.WriteAttributeString(BookmarkStart.b("䠯弱堳堵䬷", 10), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧թ੫࡭᥯ᅱᅳ奵䩷䩹䱻䡽꽿慎ﲋ揄憐﶑望", 10));
        writer.WriteAttributeString(BookmarkStart.b("䠯弱堳堵䬷", 10), BookmarkStart.b("䀯", 10), null, BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧թ੫࡭᥯ᅱᅳ奵䩷䩹䱻䡽꽿ﾅ춇ﲍ秊떙ﾝ펟톡펣즥\udaa7\ucea9", 10));
        if (this.class187_0.method_4() == 0x100)
        {
            writer.WriteAttributeString(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("匯", num), null, BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧թ੫࡭᥯ᅱᅳ奵䩷䩹䱻䡽꽿ﾅ춇ﲍ秊떙ﾛﮝ튟횡춣삥솧즩춫\udaad\ud5af", num));
        }
        this.class187_0.method_17(writer);
        this.class188_0.method_5(writer);
        this.class189_0.method_2(writer);
        writer.WriteEndElement();
        writer.Flush();
    }

    private XmlWriter method_8(Stream A_0)
    {
        XmlWriterSettings settings = new XmlWriterSettings();
        XmlWriter writer = XmlWriter.Create(A_0, settings);
        writer.WriteProcessingInstruction(BookmarkStart.b("帥䔧䘩", 0), BookmarkStart.b("倥䴧堩弫䜭弯就ळᐵषᐹ఻᰽怿❁⩃╅❇⹉╋⁍㝏潑癓͕౗᱙煛晝䉟䉡ᝣብ१ѩ࡫཭ᱯᵱᩳ፵䕷塹ջ᭽ꂁ", 0));
        return writer;
    }

    public XmlReader method_9(Stream A_0)
    {
        XmlReader reader = XmlReader.Create(A_0);
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        return reader;
    }
}

