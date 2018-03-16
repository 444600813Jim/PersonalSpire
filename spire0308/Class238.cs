using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class238
{
    private static readonly Class181 class181_0 = new Class181(false);
    private static readonly Class181 class181_1 = new Class181(false);
    private static readonly Class656 class656_0 = new Class656(50);
    private static readonly Class656 class656_1 = new Class656();
    private static readonly Class656 class656_2 = new Class656();

    static Class238()
    {
        object[] objArray = new object[0x30];
        objArray[0] = FileFormat.Xml;
        objArray[1] = BookmarkStart.b("氳嬵吷", 14);
        objArray[2] = BookmarkStart.b("䀳匵䀷丹ጻ䘽ⴿ⹁", 14);
        objArray[4] = FileFormat.Xml;
        objArray[5] = BookmarkStart.b("氳嬵吷", 14);
        objArray[6] = BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉㑋⍍㱏", 14);
        objArray[8] = FileFormat.Html;
        objArray[9] = BookmarkStart.b("簳䈵唷嘹", 14);
        objArray[10] = BookmarkStart.b("䀳匵䀷丹ጻ嘽㐿⽁⡃", 14);
        objArray[11] = BookmarkStart.b("尳䈵唷嘹", 14);
        objArray[12] = FileFormat.Html;
        objArray[13] = BookmarkStart.b("簳䈵唷嘹", 14);
        objArray[15] = BookmarkStart.b("尳䈵唷", 14);
        objArray[0x10] = FileFormat.Html;
        objArray[0x11] = BookmarkStart.b("簳䈵唷嘹", 14);
        objArray[0x13] = BookmarkStart.b("䰳帵䰷圹倻", 14);
        objArray[20] = FileFormat.Txt;
        objArray[0x15] = BookmarkStart.b("怳丵䰷", 14);
        objArray[0x16] = BookmarkStart.b("䀳匵䀷丹ጻ丽ⰿ⍁ⵃ⡅", 14);
        objArray[0x17] = BookmarkStart.b("䀳丵䰷", 14);
        objArray[0x18] = FileFormat.Doc;
        objArray[0x19] = BookmarkStart.b("瀳夵嬷", 14);
        objArray[0x1a] = BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉⅋㵍❏㵑♓㉕", 14);
        objArray[0x1b] = BookmarkStart.b("倳夵嬷", 14);
        objArray[0x1c] = FileFormat.Dot;
        objArray[0x1d] = BookmarkStart.b("瀳夵䰷", 14);
        objArray[30] = BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉⅋㵍❏㵑♓㉕", 14);
        objArray[0x1f] = BookmarkStart.b("倳夵䰷", 14);
        objArray[0x20] = FileFormat.Docx;
        objArray[0x21] = BookmarkStart.b("瀳夵嬷䈹", 14);
        objArray[0x22] = BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉㩋⁍㑏籑㭓♕㵗㑙⑛㍝౟ѡୣᑥէ୩ᡫᵭ嵯ᵱታၵᅷ᥹᥻᩽ꂍ﶑ﶝ얟톡힣쾥욧충솫슭麯횱\udbb3\ud5b5춷ힹ\ud9bb\ud0bd뒿", 14);
        objArray[0x23] = BookmarkStart.b("倳夵嬷䈹", 14);
        objArray[0x24] = FileFormat.Docm;
        objArray[0x25] = BookmarkStart.b("瀳夵嬷圹", 14);
        objArray[0x26] = BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉㩋⁍㑏籑㥓╕畗ⵙ㍛ⱝџ䱡c॥୧Ὡū୭ṯٱ婳᭵᥷᥹๻ᅽ앿ꂍꆏꂑ", 14);
        objArray[0x27] = BookmarkStart.b("倳夵嬷圹", 14);
        objArray[40] = FileFormat.Dotx;
        objArray[0x29] = BookmarkStart.b("瀳夵䰷䈹", 14);
        objArray[0x2a] = BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉㩋⁍㑏籑㭓♕㵗㑙⑛㍝౟ѡୣᑥէ୩ᡫᵭ嵯ᵱታၵᅷ᥹᥻᩽ꂍ﶑ﶝ얟톡힣쾥욧충솫슭麯욱톳\udbb5\uc8b7횹\uddbb\ucabdꖿ", 14);
        objArray[0x2b] = BookmarkStart.b("倳夵䰷䈹", 14);
        objArray[0x2c] = FileFormat.Dotm;
        objArray[0x2d] = BookmarkStart.b("瀳夵䰷圹", 14);
        objArray[0x2e] = BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉㩋⁍㑏籑㥓╕畗ⵙ㍛ⱝџ䱡ၣͥէᩩk཭ѯ᝱婳᭵᥷᥹๻ᅽ앿ꂍꆏꂑ", 14);
        objArray[0x2f] = BookmarkStart.b("倳夵䰷圹", 14);
        smethod_5(objArray);
    }

    private Class238()
    {
    }

    public static FileFormat smethod_0(string A_0)
    {
        if (Class567.smethod_16(A_0))
        {
            object obj2 = class181_0[A_0];
            if (obj2 != null)
            {
                return (FileFormat) obj2;
            }
        }
        return FileFormat.Auto;
    }

    public static ImageFormat smethod_1(string A_0)
    {
        int num = 7;
        if (Class567.smethod_16(A_0))
        {
            if (A_0.StartsWith(BookmarkStart.b("̬", num)))
            {
                A_0 = A_0.Substring(1);
            }
            object obj2 = class181_1[A_0];
            if (obj2 != null)
            {
                return (ImageFormat) obj2;
            }
        }
        return ImageFormat.Unknown;
    }

    public static string smethod_2(FileFormat A_0)
    {
        return (string) class656_1.method_3((int) A_0);
    }

    public static string smethod_3(ImageFormat A_0)
    {
        return (string) class656_2.method_3((int) A_0);
    }

    public static string smethod_4(FileFormat A_0)
    {
        return (string) class656_0.method_3((int) A_0);
    }

    private static void smethod_5(params object[] A_0)
    {
        for (int i = 0; i < A_0.Length; i += 4)
        {
            FileFormat format = (FileFormat) A_0[i];
            string str3 = (string) A_0[i + 1];
            string str2 = (string) A_0[i + 2];
            string str = (string) A_0[i + 3];
            if (!class656_0.method_8((int) format))
            {
                class656_0.method_5((int) format, str3);
            }
            if (str2 != null)
            {
                if (!class656_1.method_8((int) format))
                {
                    class656_1.method_5((int) format, str2);
                }
                if (!class181_0.Contains(str2))
                {
                    class181_0.Add(str2, format);
                }
            }
            if (str != null)
            {
                if (!class656_2.method_8((int) format))
                {
                    class656_2.method_5((int) format, str);
                }
                if (!class181_1.Contains(str))
                {
                    class181_1.Add(str, format);
                }
            }
        }
    }
}

