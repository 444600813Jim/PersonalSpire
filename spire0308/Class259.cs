using Spire.Doc;
using Spire.Doc.Documents.Converters.Encryption;
using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Class259
{
    private ArrayList arrayList_0;
    private static readonly byte[] byte_0 = new byte[] { 
        60, 0, 0, 0, 0x4d, 0, 0x69, 0, 0x63, 0, 0x72, 0, 0x6f, 0, 0x73, 0, 
        0x6f, 0, 0x66, 0, 0x74, 0, 0x2e, 0, 0x43, 0, 0x6f, 0, 110, 0, 0x74, 0, 
        0x61, 0, 0x69, 0, 110, 0, 0x65, 0, 0x72, 0, 0x2e, 0, 0x44, 0, 0x61, 0, 
        0x74, 0, 0x61, 0, 0x53, 0, 0x70, 0, 0x61, 0, 0x63, 0, 0x65, 0, 0x73, 0, 
        1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0
     };
    private static readonly byte[] byte_1 = new byte[] { 
        8, 0, 0, 0, 1, 0, 0, 0, 0x68, 0, 0, 0, 1, 0, 0, 0, 
        0, 0, 0, 0, 0x20, 0, 0, 0, 0x45, 0, 110, 0, 0x63, 0, 0x72, 0, 
        0x79, 0, 0x70, 0, 0x74, 0, 0x65, 0, 100, 0, 80, 0, 0x61, 0, 0x63, 0, 
        0x6b, 0, 0x61, 0, 0x67, 0, 0x65, 0, 50, 0, 0, 0, 0x53, 0, 0x74, 0, 
        0x72, 0, 0x6f, 0, 110, 0, 0x67, 0, 0x45, 0, 110, 0, 0x63, 0, 0x72, 0, 
        0x79, 0, 0x70, 0, 0x74, 0, 0x69, 0, 0x6f, 0, 110, 0, 0x44, 0, 0x61, 0, 
        0x74, 0, 0x61, 0, 0x53, 0, 0x70, 0, 0x61, 0, 0x63, 0, 0x65, 0, 0, 0
     };
    private static readonly byte[] byte_2 = new byte[] { 
        8, 0, 0, 0, 1, 0, 0, 0, 50, 0, 0, 0, 0x53, 0, 0x74, 0, 
        0x72, 0, 0x6f, 0, 110, 0, 0x67, 0, 0x45, 0, 110, 0, 0x63, 0, 0x72, 0, 
        0x79, 0, 0x70, 0, 0x74, 0, 0x69, 0, 0x6f, 0, 110, 0, 0x54, 0, 0x72, 0, 
        0x61, 0, 110, 0, 0x73, 0, 0x66, 0, 0x6f, 0, 0x72, 0, 0x6d, 0, 0, 0
     };
    private static readonly byte[] byte_3 = new byte[] { 
        0x58, 0, 0, 0, 1, 0, 0, 0, 0x4c, 0, 0, 0, 0x7b, 0, 70, 0, 
        70, 0, 0x39, 0, 0x41, 0, 0x33, 0, 70, 0, 0x30, 0, 0x33, 0, 0x2d, 0, 
        0x35, 0, 0x36, 0, 0x45, 0, 70, 0, 0x2d, 0, 0x34, 0, 0x36, 0, 0x31, 0, 
        0x33, 0, 0x2d, 0, 0x42, 0, 0x44, 0, 0x44, 0, 0x35, 0, 0x2d, 0, 0x35, 0, 
        0x41, 0, 0x34, 0, 0x31, 0, 0x43, 0, 0x31, 0, 0x44, 0, 0x30, 0, 0x37, 0, 
        50, 0, 0x34, 0, 0x36, 0, 0x7d, 0, 0x4e, 0, 0, 0, 0x4d, 0, 0x69, 0, 
        0x63, 0, 0x72, 0, 0x6f, 0, 0x73, 0, 0x6f, 0, 0x66, 0, 0x74, 0, 0x2e, 0, 
        0x43, 0, 0x6f, 0, 110, 0, 0x74, 0, 0x61, 0, 0x69, 0, 110, 0, 0x65, 0, 
        0x72, 0, 0x2e, 0, 0x45, 0, 110, 0, 0x63, 0, 0x72, 0, 0x79, 0, 0x70, 0, 
        0x74, 0, 0x69, 0, 0x6f, 0, 110, 0, 0x54, 0, 0x72, 0, 0x61, 0, 110, 0, 
        0x73, 0, 0x66, 0, 0x6f, 0, 0x72, 0, 0x6d, 0, 0, 0, 1, 0, 0, 0, 
        1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
        0, 0, 0, 0, 4, 0, 0, 0
     };
    private readonly Class1089 class1089_0;
    private readonly Class1132 class1132_0;

    internal Class259(Class1132 A_0)
    {
        this.class1132_0 = A_0;
        this.class1089_0 = A_0.method_0().method_7(BookmarkStart.b("⴪椬丮䔰刲昴䜶堸堺堼䰾", 5));
        this.method_4();
        this.method_5();
    }

    internal bool method_0()
    {
        int num = 8;
        if (this.arrayList_0.Count != 1)
        {
            return false;
        }
        Class754 class2 = (Class754) this.arrayList_0[0];
        if (class2.string_0 != BookmarkStart.b("紭䐯䀱嬳堵強缹刻崽㈿㭁㑃㉅ⅇ╉≋੍ㅏ♑㕓Օ⡗㭙㽛㭝", num))
        {
            return false;
        }
        if (class2.arrayList_0.Count != 1)
        {
            return false;
        }
        if (((string) class2.arrayList_0[0]) != BookmarkStart.b("欭帯儱䘳伵䠷丹夻娽ဿ⍁❃ⵅ⥇ⵉ⥋", num))
        {
            return false;
        }
        return true;
    }

    internal MemoryStream method_1(string A_0)
    {
        this.method_2();
        Stream stream = this.class1132_0.method_0().method_5(BookmarkStart.b("渪䌬䰮䌰䨲䔴䌶倸吺匼瘾⽀╂⩄", 5));
        Stream stream2 = this.class1132_0.method_0().method_5(BookmarkStart.b("渪䌬䰮䌰䨲䔴䌶尸强洼帾≀⡂⑄⁆ⱈ", 5));
        Interface13 interface2 = smethod_2(stream);
        MemoryStream stream3 = new MemoryStream();
        interface2.imethod_0(stream, stream2, stream3, A_0);
        return stream3;
    }

    private void method_2()
    {
        int num = 14;
        string[] strArray = this.method_3(BookmarkStart.b("朳䈵䨷唹刻夽Կⱁ❃㑅ㅇ㩉㡋❍㽏㱑ၓ㝕ⱗ㭙ཛ⹝şšţ", 14));
        if ((strArray.Length != 1) || (strArray[0] != BookmarkStart.b("朳䈵䨷唹刻夽Կⱁ❃㑅ㅇ㩉㡋❍㽏㱑S⑕㥗㑙⽛㡝ཟၡॣ", num)))
        {
            throw new InvalidOperationException(BookmarkStart.b("愳堵崷䈹䰻嬽⌿㙁⅃≅桇㹉㹋⽍㹏⅑㉓㥕⩗㝙籛ⱝ՟ѡţᑥ൧ѩཫ୭ͯ山", num));
        }
        BinaryReader reader = new BinaryReader(this.class1089_0.method_7(BookmarkStart.b("怳䐵夷吹伻堽⼿ぁ⥃ཅ♇ⱉ⍋", num)).method_7(strArray[0]).method_5(BookmarkStart.b("㈳昵䨷匹儻弽㈿㭁", num)));
        reader.ReadInt32();
        if (reader.ReadInt32() != 1)
        {
            throw new InvalidOperationException(BookmarkStart.b("愳堵崷䈹䰻嬽⌿㙁⅃≅桇㹉㹋⽍㹏⅑㉓㥕⩗㝙籛⩝ᥟቡţ䡥", num));
        }
        if (smethod_4(reader) != BookmarkStart.b("伳瀵縷̹紻ഽؿ牁睃歅絇籉ोࡍ絏晑打杕歗睙ṛᩝ⑟坡䥣卥⥧幩嵫⵭䅯㙱䑳䅵䩷乹䩻ͽ", num))
        {
            throw new InvalidOperationException(BookmarkStart.b("愳堵崷䈹䰻嬽⌿㙁⅃≅桇㹉㹋⽍㹏⅑㉓㥕⩗㝙籛㝝џ䱡", num));
        }
        if (smethod_4(reader) != BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ桅େ╉≋㩍ㅏ㭑㩓㍕⩗瑙ᥛそ͟ၡᵣᙥᱧͩͫm⑯qᕳᡵ୷ᱹ፻౽", num))
        {
            throw new InvalidOperationException(BookmarkStart.b("愳堵崷䈹䰻嬽⌿㙁⅃≅桇㹉㹋⽍㹏⅑㉓㥕⩗㝙籛そşཡţ䡥", num));
        }
        smethod_3(reader);
    }

    private string[] method_3(string A_0)
    {
        int num = 0x12;
        BinaryReader reader = new BinaryReader(this.class1089_0.method_7(BookmarkStart.b("簷嬹䠻弽ጿ㉁╃╅ⵇ͉≋⡍㽏", 0x12)).method_5(A_0));
        if (reader.ReadInt32() != 8)
        {
            throw new InvalidOperationException(BookmarkStart.b("洷吹夻䘽〿❁❃㉅ⵇ⹉汋♍㕏㍑こ㍕⩗穙せ㭝๟աၣ๥䙧", num));
        }
        int num4 = reader.ReadInt32();
        string[] strArray = new string[num4];
        for (int i = 0; i < num4; i++)
        {
            strArray[i] = smethod_4(reader);
        }
        return strArray;
    }

    private void method_4()
    {
        int num = 12;
        BinaryReader reader = new BinaryReader(this.class1089_0.method_5(BookmarkStart.b("搱儳䐵䬷匹医倽", 12)));
        if (smethod_4(reader) != BookmarkStart.b("缱崳唵䨷唹伻儽☿㙁橃Յ❇⑉㡋⽍㥏㱑ㅓ⑕癗ṙ㵛⩝şㅡᑣݥ୧ཀྵὫ", 12))
        {
            throw new InvalidOperationException(BookmarkStart.b("朱娳匵䀷䨹夻崽㐿❁⁃晅็⽉ⵋ㩍╏⁑ㅓὕ㱗㽙㉛⩝य़ѡൣͥᩧ䑩", num));
        }
        smethod_3(reader);
    }

    private void method_5()
    {
        int num = 13;
        BinaryReader reader = new BinaryReader(this.class1089_0.method_5(BookmarkStart.b("眲吴䌶堸栺䴼帾≀♂ࡄ♆㥈", 13)));
        if (reader.ReadInt32() != 8)
        {
            throw new InvalidOperationException(BookmarkStart.b("昲嬴制䄸䬺堼尾㕀♂⅄杆ⅈ⹊ⱌ⭎㑐⅒畔㭖㱘㕚㩜⭞ॠ䵢", num));
        }
        this.arrayList_0 = new ArrayList();
        int num4 = reader.ReadInt32();
        for (int i = 0; i < num4; i++)
        {
            Class754 class2 = smethod_6(reader);
            this.arrayList_0.Add(class2);
        }
    }

    private static void smethod_0(Class1132 A_0)
    {
        Class1089 class2 = new Class1089();
        class2.method_2(BookmarkStart.b("缫娭䈯崱娳儵紷吹弻䰽㤿㉁ぃ⽅❇⑉ࡋ⽍⑏㍑ݓ♕㥗㥙㥛", 6), new MemoryStream(byte_2));
        Class1089 class3 = new Class1089();
        class3.method_2(BookmarkStart.b("⨫縭䈯嬱夳圵䨷䌹", 6), new MemoryStream(byte_3));
        Class1089 class4 = new Class1089();
        class4.method_3(BookmarkStart.b("缫娭䈯崱娳儵紷吹弻䰽㤿㉁ぃ⽅❇⑉ᡋ㱍ㅏ㱑❓さ㝗⡙ㅛ", 6), class3);
        Class1089 class5 = new Class1089();
        class5.method_3(BookmarkStart.b("栫伭䐯匱朳䘵夷夹夻眽⸿⑁⭃", 6), class2);
        class5.method_2(BookmarkStart.b("栫伭䐯匱朳䘵夷夹夻猽ℿ㉁", 6), new MemoryStream(byte_1));
        class5.method_2(BookmarkStart.b("稫䬭䈯䄱崳夵嘷", 6), new MemoryStream(byte_0));
        class5.method_3(BookmarkStart.b("砫尭儯就䜳倵圷䠹儻眽⸿⑁⭃", 6), class4);
        A_0.method_0().method_3(BookmarkStart.b("⨫樭儯䘱唳攵䠷嬹弻嬽㌿", 6), class5);
    }

    internal static Class1132 smethod_1(Stream A_0, string A_1)
    {
        Class1132 class2 = new Class1132(new Guid(BookmarkStart.b("ᠧᨩᰫḭ/ȱгصᔷਹ఻฽瀿潁瑃癅硇穉態繍恏扑摓筕桗橙汛湝偟剡呣噥塧婩屫幭", 2)));
        smethod_0(class2);
        Interface13 interface2 = new Class864();
        MemoryStream stream = new MemoryStream();
        MemoryStream stream2 = new MemoryStream();
        interface2.imethod_1(stream, A_0, stream2, A_1);
        class2.method_0().method_2(BookmarkStart.b("洧䐩伫尭䤯䈱䀳張圷吹画倽☿ⵁ", 2), stream);
        class2.method_0().method_2(BookmarkStart.b("洧䐩伫尭䤯䈱䀳匵尷樹崻崽⬿⍁⍃⍅", 2), stream2);
        return class2;
    }

    private static Interface13 smethod_2(Stream A_0)
    {
        Interface13 interface2;
        int num = 9;
        BinaryReader reader = new BinaryReader(A_0);
        switch (((VersionInfo) reader.ReadInt32()))
        {
            case VersionInfo.CryptoApi2007:
            case VersionInfo.CryptoApi2010:
                interface2 = new Class864();
                break;

            case VersionInfo.Extensible:
            case VersionInfo.Extensible2010:
                throw new Exception(BookmarkStart.b("笮夰嘲ᔴ匶嘸堺䠼刾⑀ⵂㅄ杆⁈㡊浌⩎㽐げ❔⹖⥘⽚㡜㭞䅠ᙢᙤ๦ݨ౪䵬᭮ᥰᙲ啴㉶Ÿེ᡼ᅾꮊ좌膠슢쮤쎦覨\udfaa\uc5ac욮슰鎲\udcb4\uc4b6馸햺튼쮾ꃂ냄뗆믈껊ꏌ믎뷐꫒ꓖ곘ꯚ규냞鏠韢胤菦쟨", num));

            case VersionInfo.Agile:
                interface2 = new Class118();
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("種弰嘲䴴䜶尸堺䤼娾╀捂⁄⥆⩈㥊㑌㽎═㩒㩔㥖祘ⵚ㡜ⵞበ੢੤०䝨", num));
        }
        A_0.Position = 0L;
        return interface2;
    }

    private static void smethod_3(BinaryReader A_0)
    {
        int num = 0;
        if (A_0.ReadInt32() != 1)
        {
            throw new InvalidOperationException(BookmarkStart.b("猥䘧伩含席唯儱䀳匵尷ᨹ画倽〿㝁ぃ晅㹇⽉㹋㵍㥏㵑㩓硕", num));
        }
        if (A_0.ReadInt32() != 1)
        {
            throw new InvalidOperationException(BookmarkStart.b("猥䘧伩含席唯儱䀳匵尷ᨹ䤻丽␿⍁ぃ⍅ⱇ橉㩋⭍≏⅑㵓㥕㙗瑙", num));
        }
        if (A_0.ReadInt32() != 1)
        {
            throw new InvalidOperationException(BookmarkStart.b("猥䘧伩含席唯儱䀳匵尷ᨹ猻䬽㐿㉁ㅃ㉅桇㱉⥋㱍⍏㭑㭓㡕癗", num));
        }
    }

    private static string smethod_4(BinaryReader A_0)
    {
        int count = A_0.ReadInt32();
        byte[] bytes = A_0.ReadBytes(count);
        Class567.smethod_6(A_0.BaseStream, 4);
        return Encoding.Unicode.GetString(bytes);
    }

    private static string smethod_5(BinaryReader A_0)
    {
        int count = A_0.ReadInt32();
        byte[] bytes = A_0.ReadBytes(count);
        Class567.smethod_6(A_0.BaseStream, 4);
        return Encoding.UTF8.GetString(bytes);
    }

    private static Class754 smethod_6(BinaryReader A_0)
    {
        Class754 class2 = new Class754();
        A_0.ReadInt32();
        int num = A_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            A_0.ReadInt32();
            string str = smethod_4(A_0);
            class2.arrayList_0.Add(str);
        }
        class2.string_0 = smethod_4(A_0);
        return class2;
    }
}

