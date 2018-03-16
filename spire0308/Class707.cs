using Spire.Doc;
using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;

internal class Class707 : Class706
{
    protected const string string_4 = "Spire.Doc.Resources";

    public XmlSchema method_10()
    {
        XmlDocument document = Class706.smethod_2(smethod_5(BookmarkStart.b("夭弯䀱倳椵唷弹䠻弽㌿⅁ⱃ⍅╇⭉手㙍㵏㹑", 8)));
        return base.method_1(document);
    }

    public static XmlSchema smethod_4()
    {
        return XmlSchema.Read(smethod_5(BookmarkStart.b("䐲娴䔶崸携丼尾⥀♂⡄♆", 13)), new ValidationEventHandler(Class706.smethod_3));
    }

    protected static Stream smethod_5(string A_0)
    {
        return Assembly.GetExecutingAssembly().GetManifestResourceStream(BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙", 14) + A_0);
    }

    protected override Stream vmethod_0(string A_0, string A_1)
    {
        if (A_1 == BookmarkStart.b("稨嬪䐬崮吰ᴲ焴堶娸", 3))
        {
            return smethod_5(A_0);
        }
        return base.vmethod_0(A_0, A_1);
    }
}

