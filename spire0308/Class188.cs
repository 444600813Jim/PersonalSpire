using Spire.Doc;
using System;
using System.Xml;

[CLSCompliant(false)]
internal class Class188
{
    private byte[] byte_0;
    private byte[] byte_1;

    internal Class188()
    {
    }

    internal byte[] method_0()
    {
        return this.byte_0;
    }

    internal void method_1(byte[] A_0)
    {
        this.byte_0 = A_0;
    }

    internal byte[] method_2()
    {
        return this.byte_1;
    }

    internal void method_3(byte[] A_0)
    {
        this.byte_1 = A_0;
    }

    internal void method_4(XmlReader A_0)
    {
        this.byte_0 = Convert.FromBase64String(A_0.GetAttribute(BookmarkStart.b("䠬䄮到䄲䰴䜶䴸帺夼眾ⱀ≂♄ెⱈ㉊", 7)));
        this.byte_1 = Convert.FromBase64String(A_0.GetAttribute(BookmarkStart.b("䠬䄮到䄲䰴䜶䴸帺夼眾ⱀ≂♄ᅆ⡈❊㡌⩎", 7)));
    }

    internal void method_5(XmlWriter A_0)
    {
        A_0.WriteStartElement(BookmarkStart.b("刵夷丹崻眽⸿㙁⅃ⅅ㩇⍉㡋㝍", 0x10));
        A_0.WriteAttributeString(BookmarkStart.b("匵嘷夹主䜽〿㙁⅃≅G❉ⵋⵍ᭏㝑ⵓ", 0x10), Convert.ToBase64String(this.byte_0));
        A_0.WriteAttributeString(BookmarkStart.b("匵嘷夹主䜽〿㙁⅃≅G❉ⵋⵍُ㍑㡓⍕㵗", 0x10), Convert.ToBase64String(this.byte_1));
        A_0.WriteEndElement();
    }
}

